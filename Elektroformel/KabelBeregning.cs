using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elektroformel
{
    public partial class KabelBeregning : Form
    {
        public KabelBeregning()
        {
            InitializeComponent();
            AttachRadioButtonEvents();
            materialvalg.SelectedIndexChanged += Materialvalg_SelectedIndexChanged;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string lengdeText = kabellengde.Text.Replace(",", ".");
            string stromText = strøm.Text.Replace(",", ".");
            string phiText = cosphi.Text.Replace(",", ".");
            string motstandText = motstandpermeter.Text.Replace(",", ".");

            kabellengde.Text = lengdeText;
            strøm.Text = stromText;
            cosphi.Text = phiText;
            motstandpermeter.Text = motstandText;

            List<string> errorList = new List<string>();

            if (!double.TryParse(lengdeText, out double lengde) || lengdeText == "")
                errorList.Add("Ugyldig kabellengde");

            if (!double.TryParse(stromText, out double strom) || stromText == "")
                errorList.Add("Ugyldig strømverdi");

            if (!double.TryParse(phiText, out double phi) || phiText == "" || phi < 0 || phi > 1)
                errorList.Add("Ugyldig cos phi");

            if (!double.TryParse(motstandText, out double ro) || motstandText == "")
                errorList.Add("Ugyldig motstandsverdi");

            if (errorList.Count == 0)
            {
                double fase = GetSelectedKjernevalg();
                double tverrsnitt = double.Parse(motstandpermeter.Text);

                double spenningsfall = (strom * ro * fase * phi * lengde) / tverrsnitt;
                resultat.Text = $"Spenningstap: {Math.Round(spenningsfall, 2)} V";

                if (double.TryParse(spenning.Text, out double un))
                {
                    string resultText = resultat.Text;
                    if (spenningsfall < un)
                        resultText += Environment.NewLine + $"Spenningstap prosent: {Math.Round((spenningsfall / un) * 100, 2)} %";
                    else
                        resultText += Environment.NewLine + "Spenningstap prosent: 100 %";

                    resultat.Text = resultText;
                }
            }
            else
            {
                resultat.Text = "Feil:" + Environment.NewLine + string.Join(Environment.NewLine, errorList);
            }
        }

        private double GetSelectedKjernevalg()
        {
            if (kjernevalg1.Checked) return 1;
            if (kjernevalg2.Checked) return 2;
            if (kjernevalg3.Checked) return 3;
            if (kjernevalg4.Checked) return 4;
            if (kjernevalg5.Checked) return 5;
            return 1; // Default to 1 if nothing is selected
        }

        private void AttachRadioButtonEvents()
        {
            kjernevalg1.CheckedChanged += Kjernevalg_CheckedChanged;
            kjernevalg2.CheckedChanged += Kjernevalg_CheckedChanged;
            kjernevalg3.CheckedChanged += Kjernevalg_CheckedChanged;
            kjernevalg4.CheckedChanged += Kjernevalg_CheckedChanged;
            kjernevalg5.CheckedChanged += Kjernevalg_CheckedChanged;
        }

        private void Kjernevalg_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                kjernevalg1.Checked = sender == kjernevalg1;
                kjernevalg2.Checked = sender == kjernevalg2;
                kjernevalg3.Checked = sender == kjernevalg3;
                kjernevalg4.Checked = sender == kjernevalg4;
                kjernevalg5.Checked = sender == kjernevalg5;
            }
        }

        private void Materialvalg_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResistanceValue();
        }

        private void UpdateResistanceValue()
        {
            if (materialvalg.SelectedItem != null)
            {
                if (materialvalg.SelectedItem.ToString() == "Kobber")
                    motstandpermeter.Text = "0.0175";
                else if (materialvalg.SelectedItem.ToString() == "Aluminium")
                    motstandpermeter.Text = "0.029";
            }
        }
    }
}
