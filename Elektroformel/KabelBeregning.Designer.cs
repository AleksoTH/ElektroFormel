namespace Elektroformel
{
    partial class KabelBeregning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            kjernevalge = new Panel();
            kjernevalg5 = new RadioButton();
            kjernevalg4 = new RadioButton();
            kjernevalg3 = new RadioButton();
            kjernevalg2 = new RadioButton();
            kjernevalg1 = new RadioButton();
            label3 = new Label();
            spenning = new TextBox();
            strøm = new TextBox();
            label4 = new Label();
            materialvalg = new ComboBox();
            label5 = new Label();
            motstandpermeter = new TextBox();
            label6 = new Label();
            resultat = new TextBox();
            kabellengde = new TextBox();
            label8 = new Label();
            cosphi = new TextBox();
            label9 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            tversnittvelger = new ComboBox();
            label2 = new Label();
            kjernevalge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 16);
            label1.Name = "label1";
            label1.Size = new Size(248, 15);
            label1.TabIndex = 0;
            label1.Text = "Hvor mange separerte kjerner i kabel? (ledere)";
            // 
            // kjernevalge
            // 
            kjernevalge.Controls.Add(kjernevalg5);
            kjernevalge.Controls.Add(kjernevalg4);
            kjernevalge.Controls.Add(kjernevalg3);
            kjernevalge.Controls.Add(kjernevalg2);
            kjernevalge.Controls.Add(kjernevalg1);
            kjernevalge.Location = new Point(225, 34);
            kjernevalge.Name = "kjernevalge";
            kjernevalge.Size = new Size(211, 53);
            kjernevalge.TabIndex = 1;
            // 
            // kjernevalg5
            // 
            kjernevalg5.AutoSize = true;
            kjernevalg5.Location = new Point(166, 15);
            kjernevalg5.Name = "kjernevalg5";
            kjernevalg5.Size = new Size(31, 19);
            kjernevalg5.TabIndex = 4;
            kjernevalg5.TabStop = true;
            kjernevalg5.Text = "5";
            kjernevalg5.UseVisualStyleBackColor = true;
            // 
            // kjernevalg4
            // 
            kjernevalg4.AutoSize = true;
            kjernevalg4.Location = new Point(131, 15);
            kjernevalg4.Name = "kjernevalg4";
            kjernevalg4.Size = new Size(31, 19);
            kjernevalg4.TabIndex = 3;
            kjernevalg4.TabStop = true;
            kjernevalg4.Text = "4";
            kjernevalg4.UseVisualStyleBackColor = true;
            // 
            // kjernevalg3
            // 
            kjernevalg3.AutoSize = true;
            kjernevalg3.Location = new Point(94, 15);
            kjernevalg3.Name = "kjernevalg3";
            kjernevalg3.Size = new Size(31, 19);
            kjernevalg3.TabIndex = 2;
            kjernevalg3.TabStop = true;
            kjernevalg3.Text = "3";
            kjernevalg3.UseVisualStyleBackColor = true;
            // 
            // kjernevalg2
            // 
            kjernevalg2.AutoSize = true;
            kjernevalg2.Location = new Point(57, 15);
            kjernevalg2.Name = "kjernevalg2";
            kjernevalg2.Size = new Size(31, 19);
            kjernevalg2.TabIndex = 1;
            kjernevalg2.TabStop = true;
            kjernevalg2.Text = "2";
            kjernevalg2.UseVisualStyleBackColor = true;
            // 
            // kjernevalg1
            // 
            kjernevalg1.AutoSize = true;
            kjernevalg1.Location = new Point(20, 15);
            kjernevalg1.Name = "kjernevalg1";
            kjernevalg1.Size = new Size(31, 19);
            kjernevalg1.TabIndex = 0;
            kjernevalg1.TabStop = true;
            kjernevalg1.Text = "1";
            kjernevalg1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 293);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Spenning (U)";
            // 
            // spenning
            // 
            spenning.Location = new Point(29, 311);
            spenning.Name = "spenning";
            spenning.Size = new Size(100, 23);
            spenning.TabIndex = 5;
            // 
            // strøm
            // 
            strøm.Location = new Point(29, 359);
            strøm.Name = "strøm";
            strøm.Size = new Size(100, 23);
            strøm.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 341);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 6;
            label4.Text = "Strøm (I)";
            // 
            // materialvalg
            // 
            materialvalg.FormattingEnabled = true;
            materialvalg.Items.AddRange(new object[] { "Kobber", "Aluminium" });
            materialvalg.Location = new Point(70, 420);
            materialvalg.Name = "materialvalg";
            materialvalg.Size = new Size(121, 23);
            materialvalg.TabIndex = 8;
            materialvalg.Text = "Kobber";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 402);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 9;
            label5.Text = "Kabel materiale";
            // 
            // motstandpermeter
            // 
            motstandpermeter.Location = new Point(279, 420);
            motstandpermeter.Name = "motstandpermeter";
            motstandpermeter.Size = new Size(100, 23);
            motstandpermeter.TabIndex = 10;
            motstandpermeter.Text = "0.0175";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 402);
            label6.Name = "label6";
            label6.Size = new Size(130, 15);
            label6.TabIndex = 11;
            label6.Text = "Motstand per meter (R)";
            // 
            // resultat
            // 
            resultat.Location = new Point(442, 34);
            resultat.Multiline = true;
            resultat.Name = "resultat";
            resultat.ReadOnly = true;
            resultat.ScrollBars = ScrollBars.Horizontal;
            resultat.Size = new Size(312, 163);
            resultat.TabIndex = 14;
            // 
            // kabellengde
            // 
            kabellengde.Location = new Point(273, 311);
            kabellengde.Name = "kabellengde";
            kabellengde.Size = new Size(100, 23);
            kabellengde.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(249, 293);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 15;
            label8.Text = "Kabellengde (M)";
            // 
            // cosphi
            // 
            cosphi.Location = new Point(273, 359);
            cosphi.Name = "cosphi";
            cosphi.Size = new Size(100, 23);
            cosphi.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(249, 341);
            label9.Name = "label9";
            label9.Size = new Size(116, 15);
            label9.TabIndex = 17;
            label9.Text = "EffektFaktor (cosphi)";
            // 
            // button1
            // 
            button1.Location = new Point(442, 203);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Regn ut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.oNmS9PN;
            pictureBox1.InitialImage = Properties.Resources.oNmS9PN;
            pictureBox1.Location = new Point(5, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.Location = new Point(441, 243);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(313, 209);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "";
            // 
            // tversnittvelger
            // 
            tversnittvelger.FormattingEnabled = true;
            tversnittvelger.Items.AddRange(new object[] { "0.5", "0.75", "1", "1.5", "2.5", "4", "6", "10", "16", "25", "35", "50", "70", "95", "120", "150", "185", " 240" });
            tversnittvelger.Location = new Point(242, 108);
            tversnittvelger.Name = "tversnittvelger";
            tversnittvelger.Size = new Size(121, 23);
            tversnittvelger.TabIndex = 22;
            tversnittvelger.Text = "0.5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 90);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 23;
            label2.Text = "Tverrsnitt på kjerne(leder)";
            // 
            // KabelBeregning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(tversnittvelger);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(cosphi);
            Controls.Add(label9);
            Controls.Add(kabellengde);
            Controls.Add(label8);
            Controls.Add(resultat);
            Controls.Add(label6);
            Controls.Add(motstandpermeter);
            Controls.Add(label5);
            Controls.Add(materialvalg);
            Controls.Add(strøm);
            Controls.Add(label4);
            Controls.Add(spenning);
            Controls.Add(label3);
            Controls.Add(kjernevalge);
            Controls.Add(label1);
            Name = "KabelBeregning";
            Text = "Form2";
            kjernevalge.ResumeLayout(false);
            kjernevalge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel kjernevalge;
        private RadioButton kjernevalg5;
        private RadioButton kjernevalg4;
        private RadioButton kjernevalg3;
        private RadioButton kjernevalg2;
        private RadioButton kjernevalg1;
        private Label label3;
        private TextBox spenning;
        private TextBox strøm;
        private Label label4;
        private ComboBox materialvalg;
        private Label label5;
        private TextBox motstandpermeter;
        private Label label6;
        private TextBox resultat;
        private TextBox kabellengde;
        private Label label8;
        private TextBox cosphi;
        private Label label9;
        private Button button1;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private ComboBox tversnittvelger;
        private Label label2;
    }
}