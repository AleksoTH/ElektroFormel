using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;

namespace Elektroformel
{
    public partial class hovedside : Form
    {
        public hovedside()
        {
            InitializeComponent();
        }

        String[] formål = [
            "Beregning av Motstand",
            "Beregning av Spenning",
            "Beregning av Strøm",
            "Beregning av Effekt"];
        String[] ohmMotstand = ["U/I", "P/I^2", "U^2/P"];
        String[] ohmEffekt = ["R*I^2", "U^2/R", "U*I"];
        String[] ohmAmpere = ["U/R", "P/U", "sqrt(P/R)"];
        String[] ohmSPenning = ["P/I", "R*I", "sqrt(R*P)"];
        private Form1 fase3vindu = new Form1();

        private void OmhRevurdering(object sender, EventArgs e)
        {
            var inputs = new Dictionary<string, (string Text, string BaseUnit)>
            {
                ["R"] = (Motstander.Text, "Ω"),
                ["U"] = (spenning.Text, "V"),
                ["I"] = (ampere.Text, "A"),
                ["P"] = (effekt.Text, "W")
            };

            var values = new Dictionary<string, double>();
            var steps = new List<string>();
            bool hasUnknownResistor = false;
            bool isSeriesUnknown = false;
            List<double> knownResistorsInParallelGroup = null;
            double sumKnownSeriesResistors = 0;
            double sumKnownResistors = 0;

            if (!string.IsNullOrEmpty(inputs["R"].Text))
            {
                string inputText = inputs["R"].Text.Replace(" ", "");
                if (inputText.Contains("+") && inputText.Contains(","))
                {
                    utregningohm.Text = "Serie og parellel er ikke støttet i samme utregning.";
                    return;
                }
                if (inputText.Contains("+") || inputText.Contains(","))
                {
                    var seriesParts = inputText.Split('+');
                    foreach (var seriesPart in seriesParts)
                    {
                        if (seriesPart.Contains(","))
                        {
                            var resistors = seriesPart.Split(',')
                                .Select(s =>
                                {
                                    if (s.Trim() == "?")
                                        return (Value: (double?)null, IsUnknown: true);
                                    else if (double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out double r))
                                        return (Value: r, IsUnknown: false);
                                    else
                                        return (Value: (double?)null, IsUnknown: false);
                                })
                                .ToList();

                            if (resistors.Any(r => r.Value == null && !r.IsUnknown))
                            {
                                utregningohm.Text = "Ugyldig motstandsverdi";
                                return;
                            }

                            int unknownCount = resistors.Count(r => r.IsUnknown);

                            knownResistorsInParallelGroup = resistors.Where(r => !r.IsUnknown).Select(r => r.Value.Value).ToList();

                            if (unknownCount > 1)
                            {
                                utregningohm.Text = "Maks én ukjent motstand per parallellgruppe.";
                                return;
                            }
                            else if (unknownCount == 1)
                            {
                                if (hasUnknownResistor)
                                {
                                    utregningohm.Text = "Bare én ukjent motstand tillatt totalt.";
                                    return;
                                }
                                hasUnknownResistor = true;
                                steps.Add($"Parallellkobling med ukjent: {seriesPart}");
                            }
                            else
                            {
                                double parallelTotal = 1.0 / resistors.Sum(r => 1.0 / r.Value.Value);
                                sumKnownResistors += parallelTotal;
                                steps.Add($"Parallellkobling: {string.Join(", ", resistors.Select(r => r.Value.Value))} → {FormatNumber(parallelTotal)} Ω");
                            }
                        }
                        else
                        {
                            if (seriesPart.Trim() == "?")
                            {
                                if (hasUnknownResistor)
                                {
                                    utregningohm.Text = "Bare én ukjent motstand tillatt totalt.";
                                    return;
                                }
                                hasUnknownResistor = true;
                                isSeriesUnknown = true;
                                steps.Add($"Seriekobling med ukjent: {seriesPart}");
                            }
                            else if (double.TryParse(seriesPart, NumberStyles.Any, CultureInfo.InvariantCulture, out double r))
                            {
                                sumKnownSeriesResistors += r;
                                sumKnownResistors += r;
                                steps.Add($"Seriekobling: + {FormatNumber(r)} Ω");
                            }
                            else
                            {
                                utregningohm.Text = "Ugyldig motstandsverdi";
                                return;
                            }
                        }
                    }

                    if (!hasUnknownResistor)
                    {
                        values["R"] = sumKnownResistors;
                        steps.Add($"Total motstand: {FormatNumber(sumKnownResistors)} Ω");
                    }
                }
                else if (double.TryParse(inputText, NumberStyles.Any, CultureInfo.InvariantCulture, out double singleR))
                {
                    values["R"] = singleR;
                    steps.Add($"Motstand: {FormatNumber(singleR)} Ω");
                }
                else
                {
                    utregningohm.Text = "Ugyldig motstandsverdi";
                    return;
                }
            }

            foreach (var key in inputs.Keys.Where(k => k != "R"))
            {
                if (!string.IsNullOrEmpty(inputs[key].Text))
                {
                    var parsed = ParseUnitValue(inputs[key].Text, inputs[key].BaseUnit);
                    if (!parsed.HasValue)
                    {
                        utregningohm.Text = $"Ugyldig verdi for {key}";
                        return;
                    }
                    values[key] = parsed.Value.Value;
                    steps.Add($"{key} = {inputs[key].Text} ({FormatNumber(parsed.Value.Value)}{inputs[key].BaseUnit})");
                }
            }

            if ((values.Count < 2 && !hasUnknownResistor) || (hasUnknownResistor && values.Count < 2))
            {
                valgtformel.Text = "Mangler inndata";
                utregningohm.Text = "Minimum to verdier kreves for beregning";
                return;
            }

            string resultUnit = "";
            if (!values.ContainsKey("R"))
            {
                formalohm.Text = formål[0];
                resultUnit = "Ω";
                if (values.ContainsKey("U") && values.ContainsKey("I"))
                {
                    values["R"] = values["U"] / values["I"];
                    valgtformel.Text = "R = U / I";
                }
                else if (values.ContainsKey("P") && values.ContainsKey("I"))
                {
                    values["R"] = values["P"] / Math.Pow(values["I"], 2);
                    valgtformel.Text = "R = P / I²";
                }
                else if (values.ContainsKey("U") && values.ContainsKey("P"))
                {
                    values["R"] = Math.Pow(values["U"], 2) / values["P"];
                    valgtformel.Text = "R = U² / P";
                }
            }
            else if (!values.ContainsKey("U"))
            {
                formalohm.Text = formål[1];
                resultUnit = "V";
                if (values.ContainsKey("R") && values.ContainsKey("I"))
                {
                    values["U"] = values["R"] * values["I"];
                    valgtformel.Text = "U = R × I";
                }
                else if (values.ContainsKey("P") && values.ContainsKey("I"))
                {
                    values["U"] = values["P"] / values["I"];
                    valgtformel.Text = "U = P / I";
                }
                else if (values.ContainsKey("R") && values.ContainsKey("P"))
                {
                    values["U"] = Math.Sqrt(values["R"] * values["P"]);
                    valgtformel.Text = "U = sqrt(R × P)";
                }
            }
            else if (!values.ContainsKey("I"))
            {
                formalohm.Text = formål[2];
                resultUnit = "A";
                if (values.ContainsKey("U") && values.ContainsKey("R"))
                {
                    values["I"] = values["U"] / values["R"];
                    valgtformel.Text = "I = U / R";
                }
                else if (values.ContainsKey("P") && values.ContainsKey("U"))
                {
                    values["I"] = values["P"] / values["U"];
                    valgtformel.Text = "I = P / U";
                }
                else if (values.ContainsKey("P") && values.ContainsKey("R"))
                {
                    values["I"] = Math.Sqrt(values["P"] / values["R"]);
                    valgtformel.Text = "I = sqrt(P / R)";
                }
            }
            else if (!values.ContainsKey("P"))
            {
                formalohm.Text = formål[3];
                resultUnit = "W";
                if (values.ContainsKey("U") && values.ContainsKey("I"))
                {
                    values["P"] = values["U"] * values["I"];
                    valgtformel.Text = "P = U × I";
                }
                else if (values.ContainsKey("R") && values.ContainsKey("I"))
                {
                    values["P"] = values["R"] * Math.Pow(values["I"], 2);
                    valgtformel.Text = "P = R × I²";
                }
                else if (values.ContainsKey("U") && values.ContainsKey("R"))
                {
                    values["P"] = Math.Pow(values["U"], 2) / values["R"];
                    valgtformel.Text = "P = U² / R";
                }
            }

            steps.Add($"{valgtformel.Text} = {FormatNumber(values[valgtformel.Text.Split('=')[0].Trim()])} {resultUnit}");

            if (hasUnknownResistor)
            {
                if (!values.ContainsKey("R"))
                {
                    utregningohm.Text = "Ukjent motstand krever beregnet totalmotstand";
                    return;
                }

                if (isSeriesUnknown)
                {
                    double R_ukjent = values["R"] - sumKnownSeriesResistors;
                    steps.Add("Beregning av ukjent seriemotstand:");
                    steps.Add($"R_ukjent = R_total(U/I) + sum_kjente_serie");
                    steps.Add($"{FormatNumber(values["R"])}Ω - {FormatNumber(sumKnownSeriesResistors)}Ω = {FormatNumber(R_ukjent)}Ω");
                    values["R"] = sumKnownSeriesResistors + R_ukjent;
                }
                else
                {
                    double R_parallel = values["R"] - sumKnownResistors;
                    steps.Add("Beregning av ukjent parallellmotstand:");
                    steps.Add($"1/R_parallell(U/I) = (1/R_kjent) + 1/R_ukjent");
                    steps.Add($"1/{FormatNumber(R_parallel)} = {string.Join(" + ", knownResistorsInParallelGroup.Select(r => $"1/{r}"))} + 1/R_ukjent");

                    double sumReciprocal = knownResistorsInParallelGroup.Sum(r => 1.0 / r);
                    double reciprocalUnknown = (1.0 / R_parallel) - sumReciprocal;

                    steps.Add($"1/R_ukjent = {FormatNumber(1 / R_parallel)} - {FormatNumber(sumReciprocal)}");
                    steps.Add($"1/R_ukjent = {FormatNumber(reciprocalUnknown)}");

                    if (reciprocalUnknown <= 0)
                    {
                        steps.Add("Ingen gyldig løsning - negativ motstand");
                        utregningohm.Text = string.Join(Environment.NewLine, steps);
                        return;
                    }

                    double unknownResistor = 1.0 / reciprocalUnknown;
                    steps.Add($"R_ukjent = 1 / {FormatNumber(reciprocalUnknown)}");
                    steps.Add($"R_ukjent = {FormatNumber(unknownResistor)}Ω");

                    if (values.ContainsKey("U"))
                    {
                        steps.Add("Strømfordeling med ukjent:");
                        var allResistors = knownResistorsInParallelGroup.Concat(new[] { unknownResistor }).ToList();
                        foreach (var r in allResistors)
                        {
                            double current = values["U"] / r;
                            steps.Add($"I = {FormatNumber(values["U"])}V / {FormatNumber(r)}Ω = {FormatNumber(current)}A");
                        }
                    }
                }
            }
            else if (knownResistorsInParallelGroup != null && values.ContainsKey("U"))
            {
                steps.Add("Strømfordeling:");
                foreach (var r in knownResistorsInParallelGroup)
                {
                    double current = values["U"] / r;
                    steps.Add($"I = {FormatNumber(values["U"])}V / {FormatNumber(r)}Ω = {FormatNumber(current)}A");
                }
            }

            utregningohm.Text = string.Join(Environment.NewLine, steps);
        }



        private string FormatNumber(double value)
        {
            if (Math.Abs(value) < 0.001)
            {
                return value.ToString("0.#####E0", CultureInfo.InvariantCulture);
            }
            else if (Math.Abs(value - Math.Round(value, 2)) >= 0.001)
            {
                return value.ToString("0.#####", CultureInfo.InvariantCulture);
            }
            else
            {
                return value.ToString("0.##", CultureInfo.InvariantCulture);
            }
        }

        private (double Value, List<double> Components)? ParseResistance(string input)
        {
            try
            {
                var components = input.Split(',')
                    .Select(s => double.Parse(s.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture))
                    .Where(r => r > 0)
                    .ToList();

                if (!components.Any()) return null;

                var reciprocalSum = components.Sum(r => 1 / r);
                var totalResistance = 1 / reciprocalSum;

                return (totalResistance, components);
            }
            catch
            {
                return null;
            }
        }

        private (double Value, string DisplayText)? ParseUnitValue(string input, string baseUnit)
        {
            var match = Regex.Match(input.Trim(), @"^([\d,.]+)\s*([a-zA-Z]*)$");
            if (!match.Success) return null;

            if (!double.TryParse(match.Groups[1].Value.Replace(",", "."),
                               NumberStyles.Any,
                               CultureInfo.InvariantCulture,
                               out double value))
            {
                return null;
            }

            string unit = match.Groups[2].Value;
            double multiplier = 1.0;
            string displayUnit = baseUnit;

            switch (baseUnit)
            {
                case "V":
                    if (unit.Equals("mV", StringComparison.OrdinalIgnoreCase))
                    {
                        multiplier = 0.001;
                        displayUnit = "mV";
                    }
                    break;

                case "A":
                    if (unit.Equals("mA", StringComparison.OrdinalIgnoreCase))
                    {
                        multiplier = 0.001;
                        displayUnit = "mA";
                    }
                    break;
            }

            var baseValue = value * multiplier;
            return (baseValue, $"{input} ({baseValue:N3}{baseUnit})");
        }
        private void MotorMomentRegnut(object sender, EventArgs e)
        {
            string HastighetRPM = momrpm.Text.Replace(',', '.');
            string Pkwm = momkw.Text.Replace(',', '.');

            if (double.TryParse(HastighetRPM, NumberStyles.Any, CultureInfo.InvariantCulture, out double N) &&
                double.TryParse(Pkwm, NumberStyles.Any, CultureInfo.InvariantCulture, out double Pu))
            {
                Pu *= 1000;

                string nl = Environment.NewLine;
                string resultat = $"=== INNDATA ==={nl}" +
                                  $"Hastighet (N) - RPM (omdreininger per minutt): {N}{nl}" +
                                  $"Effekt (Pu) - kW (kilowatt): {Pkwm}{nl}" +
                                  $"================{nl}{nl}";

                double M = (Pu * 60) / (2 * Math.PI * N);
                resultat += $"=== STEG 1 - Beregning av Moment ==={nl}" +
                            $"Formel: M = (Pu * 60) / (2 * π * N){nl}" +
                            $"Utregning: M = ({Pu} * 60) / (2 * {Math.PI} * {N}){nl}" +
                            $"Resultat: M ≈ {M:F2} Nm{nl}" +
                            $"=================================={nl}{nl}";

                utregningmoment.Multiline = true;
                utregningmoment.Text = resultat;
            }
            else
            {
                utregningmoment.Text = "Ugyldig input. Vennligst skriv inn numeriske verdier for hastighet og effekt.";
            }
        }





        private void MotorVirkingsgradRegnut(object sender, EventArgs e)
        {
            // Hent brukerens inputverdier
            string IAmpere = motorvi.Text;
            string Uspenning = motorspenningu.Text;
            bool trefase = motor3fasvirking.Checked;
            string resultat = "";

            // Konverter inputverdier til numeriske typer
            var parsedI = ParseUnitValue(IAmpere, "A");
            var parsedU = ParseUnitValue(Uspenning, "V");

            if (parsedI.HasValue && parsedU.HasValue)
            {
                double I = parsedI.Value.Value;
                double U = parsedU.Value.Value;

                // Hent effektfaktor (cosφ) og valider verdien
                if (double.TryParse(cosP.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double cosPhi) &&
                    cosPhi > 0 && cosPhi <= 1)
                {
                    double Pt;
                    string nl = Environment.NewLine;

                    if (trefase)
                    {
                        // Trefase effektberegning
                        Pt = Math.Sqrt(3) * U * I * cosPhi;
                        resultat += $"=== Tre-fase Effektberegning ==={nl}" +
                                    $"Formel: Pt = √3 × U × I × cosφ{nl}" +
                                    $"Utregning: Pt = {FormatNumber(Math.Sqrt(3))} × {FormatNumber(U)} × {FormatNumber(I)} × {FormatNumber(cosPhi)}{nl}";
                    }
                    else
                    {
                        // Enfase effektberegning
                        Pt = U * I * cosPhi;
                        resultat += $"=== En-fase Effektberegning ==={nl}" +
                                    $"Formel: Pt = U × I × cosφ{nl}" +
                                    $"Utregning: Pt = {FormatNumber(U)} × {FormatNumber(I)} × {FormatNumber(cosPhi)}{nl}";
                    }

                    double Pt_kW = Pt / 1000;
                    resultat += $"Resultat: Pt ≈ {FormatNumber(Pt)} W ({FormatNumber(Pt_kW)} kW){nl}" +
                                $"=================================={nl}";

                    utregningmoment.Multiline = true;
                    utregningmoment.Text = resultat;
                }
                else
                {
                    utregningmoment.Text = "Ugyldig effektfaktor (cosφ). Skriv inn en verdi mellom 0 og 1.";
                }
            }
            else
            {
                utregningmoment.Text = "Ugyldig input. Vennligst skriv inn numeriske verdier for strøm (A/mA) og spenning (V/mV).";
            }
        }



        //Three Phase AC Motor FLA (Amperes) = (P [HP] × 746) / (V × 1.732 × cos ϕ × η)
        //  Three Phase AC Motor FLA(Amperes) = (P[kW] × 1000) / (V × 1.732 × cos ϕ)
        //Single Phase AC Motor FLA(Amperes) = (P[HP] × 746) / (V × cos ϕ × η)
        //Single Phase AC Motor FLA(Amperes) = (P[kW] × 1000) / (V × cos ϕ)
        private void motorfulllastampRegnUt(object sender, EventArgs e)
        {
            var effektInput = ParseUnitValue(fulllastkw.Text, "W");
            var spenningInput = ParseUnitValue(fullastspenning.Text, "V");
            var cosPhiInput = ParseUnitValue(cosphimotorfullast.Text, ""); // Effektfaktor (cosφ)
            bool trefaser = fulllast3fas.Checked;
            bool brukerHP = !string.IsNullOrWhiteSpace(fulllasthp.Text);

            var hpInput = brukerHP ? ParseUnitValue(fulllasthp.Text, "") : null;

            string resultat = "";

            if (!effektInput.HasValue)
            {
                utregningfullast.Text = "Ugyldig effektverdi";
                return;
            }

            if (!spenningInput.HasValue || spenningInput.Value.Value == 0)
            {
                utregningfullast.Text = "Ugyldig spenningsverdi";
                return;
            }

            if (!cosPhiInput.HasValue || cosPhiInput.Value.Value <= 0 || cosPhiInput.Value.Value > 1)
            {
                utregningfullast.Text = "Ugyldig effektfaktor (cosφ)";
                return;
            }

            double P_watts;
            double η = 1;

            if (brukerHP)
            {
                if (!hpInput.HasValue || hpInput.Value.Value <= 0)
                {
                    utregningfullast.Text = "Ugyldig HP/virkningsgrad-verdi";
                    return;
                }
                η = hpInput.Value.Value / 100;
                P_watts = effektInput.Value.Value * 746;
            }
            else
            {
                P_watts = effektInput.Value.Value;
            }

            double V = spenningInput.Value.Value;
            double cosPhi = cosPhiInput.Value.Value;

            resultat += "Inndata:" + Environment.NewLine;
            resultat += "Effekt: " + effektInput.Value.DisplayText + Environment.NewLine;
            resultat += "Spenning: " + spenningInput.Value.DisplayText + Environment.NewLine;
            resultat += "Effektfaktor (cosφ): " + FormatNumber(cosPhi) + Environment.NewLine;

            if (brukerHP)
                resultat += "Virkningsgrad: " + FormatNumber(η * 100) + "%" + Environment.NewLine;

            double FLA;
            if (trefaser)
            {
                double denominator = V * Math.Sqrt(3) * cosPhi;
                if (brukerHP) denominator *= η; // Kun ved HP
                resultat += Environment.NewLine + "Tre-fase beregning:" + Environment.NewLine;
                resultat += "FLA = P / (V * sqrt(3) * cosφ" + (brukerHP ? " * η" : "") + ")" + Environment.NewLine;
                resultat += "FLA = " + FormatNumber(P_watts) + " / (" + FormatNumber(V) + " * " + FormatNumber(Math.Sqrt(3)) + " * " + FormatNumber(cosPhi) + (brukerHP ? " * " + FormatNumber(η) : "") + ")" + Environment.NewLine;
                FLA = P_watts / denominator;
            }
            else
            {
                double denominator = V * cosPhi;
                if (brukerHP) denominator *= η; // Kun ved HP
                resultat += Environment.NewLine + "En-fase beregning:" + Environment.NewLine;
                resultat += "FLA = P / (V * cosφ" + (brukerHP ? " * η" : "") + ")" + Environment.NewLine;
                resultat += "FLA = " + FormatNumber(P_watts) + " / (" + FormatNumber(V) + " * " + FormatNumber(cosPhi) + (brukerHP ? " * " + FormatNumber(η) : "") + ")" + Environment.NewLine;
                FLA = P_watts / denominator;
            }

            resultat += Environment.NewLine + "Resultat:" + Environment.NewLine;
            resultat += "FLA ≈ " + FormatNumber(FLA) + " A";
            utregningfullast.Text = resultat;
        }

        private void hovedside_Load(object sender, EventArgs e)
        {
            richTextBox1.Rtf = GenerateHelpRtf();
        }

        private string GenerateHelpRtf()
        {
            return @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat{\fonttbl{\f0\fnil Segoe UI; } }
                {\colortbl;\red23\green54\blue93;\red215\green55\blue35; }
\viewkind4\uc1
\pard\sa120\sl276\slmult1\cf1\b\f0\fs24 Ohm-kalkulator instruksjoner\cf0\b0\par

\pard\sa120\sl276\slmult1\cf1\b Motstand(R):\cf0\b0\par
\pard\sa80\sl220\slmult1\bullet\tab Komma , for parallelle motstander\par
\pard\sa80\sl220\slmult1\tab Eksempel: \cf2 1, 2.5,?\cf0\par
\pard\sa80\sl220\slmult1\bullet\tab Plus(+) for seriekoblinger\par
\pard\sa80\sl220\slmult1\tab Eksempel: \cf2 10 + 20 +?\cf0\par
\pard\sa80\sl220\slmult1\bullet\tab Kun en ukjent(?) tillatt\par
\pard\sa80\sl220\slmult1\bullet\tab Ved bruk av ?, m\u197? U og I fylles ut.\par

\pard\sa120\sl276\slmult1\cf1\b Spenning(V):\cf0\b0\par
\pard\sa80\sl220\slmult1\bullet\tab Bruk V eller mV\par
\pard\sa80\sl220\slmult1\tab Eksempel: \cf2 12V\cf0, \cf2 0.1mV\cf0, \cf2 3.7\cf0\par

\pard\sa120\sl276\slmult1\cf1\b Str\u248?m(I):\cf0\b0\par
\pard\sa80\sl220\slmult1\bullet\tab Bruk A eller mA\par
\pard\sa80\sl220\slmult1\tab Eksempel: \cf2 2A\cf0, \cf2 500mA\cf0, \cf2 0.05\cf0\par
}
            ";
        }

        private void kabelberegning(object sender, EventArgs e)
        {
            if (!kabelber.Visible)
            {
                if (kabelber.IsDisposed) kabelber = new KabelBeregning();
                kabelber.Show();
            }
        }

        private void Åpne3fase(object sender, EventArgs e)
        {
            if (!fase3vindu.Visible)
            {
                if (fase3vindu.IsDisposed) fase3vindu = new Form1();
                fase3vindu.Show();
            }
        }
    }
}
