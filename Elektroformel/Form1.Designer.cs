namespace Elektroformel
{
    partial class hovedside
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hovedside));
            pictureBox1 = new PictureBox();
            valgtformel = new TextBox();
            label1 = new Label();
            formalohm = new TextBox();
            label2 = new Label();
            label3 = new Label();
            utregningohm = new TextBox();
            Motstander = new TextBox();
            label10 = new Label();
            spenning = new TextBox();
            ampere = new TextBox();
            effekt = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            utregningfullast = new TextBox();
            regnutfulllast = new Button();
            fulllast3fas = new CheckBox();
            fulllastkw = new TextBox();
            label13 = new Label();
            label14 = new Label();
            fullastspenning = new TextBox();
            label15 = new Label();
            label16 = new Label();
            cosphimotorfullast = new TextBox();
            label4 = new Label();
            label5 = new Label();
            utregningmoment = new TextBox();
            label6 = new Label();
            momkw = new TextBox();
            label7 = new Label();
            motorvi = new TextBox();
            motor3fasvirking = new CheckBox();
            motorspenningu = new TextBox();
            label18 = new Label();
            momrpm = new TextBox();
            label19 = new Label();
            label21 = new Label();
            cosP = new TextBox();
            regnutvirkingsgrad = new Button();
            panel2 = new Panel();
            fulllasthp = new TextBox();
            label17 = new Label();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            label20 = new Label();
            regnutmoment = new Button();
            toolTip1 = new ToolTip(components);
            label22 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ohm;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 331);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // valgtformel
            // 
            valgtformel.Location = new Point(441, 12);
            valgtformel.Name = "valgtformel";
            valgtformel.ReadOnly = true;
            valgtformel.Size = new Size(286, 23);
            valgtformel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 15);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Valgt formel:";
            // 
            // formalohm
            // 
            formalohm.Location = new Point(441, 41);
            formalohm.Name = "formalohm";
            formalohm.ReadOnly = true;
            formalohm.Size = new Size(286, 23);
            formalohm.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 49);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Formål:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 207);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Utregning:";
            // 
            // utregningohm
            // 
            utregningohm.Location = new Point(441, 207);
            utregningohm.Multiline = true;
            utregningohm.Name = "utregningohm";
            utregningohm.ReadOnly = true;
            utregningohm.ScrollBars = ScrollBars.Vertical;
            utregningohm.Size = new Size(330, 131);
            utregningohm.TabIndex = 6;
            // 
            // Motstander
            // 
            Motstander.Location = new Point(441, 88);
            Motstander.Name = "Motstander";
            Motstander.PlaceholderText = "2.0,3.0,1";
            Motstander.Size = new Size(286, 23);
            Motstander.TabIndex = 16;
            Motstander.TextChanged += OmhRevurdering;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(339, 73);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 17;
            label10.Text = "Verdier";
            // 
            // spenning
            // 
            spenning.Location = new Point(441, 117);
            spenning.Name = "spenning";
            spenning.PlaceholderText = "12V";
            spenning.Size = new Size(286, 23);
            spenning.TabIndex = 18;
            spenning.TextChanged += OmhRevurdering;
            // 
            // ampere
            // 
            ampere.Location = new Point(441, 146);
            ampere.Name = "ampere";
            ampere.PlaceholderText = "400A";
            ampere.Size = new Size(286, 23);
            ampere.TabIndex = 19;
            ampere.TextChanged += OmhRevurdering;
            // 
            // effekt
            // 
            effekt.Location = new Point(441, 174);
            effekt.Name = "effekt";
            effekt.PlaceholderText = "300W";
            effekt.Size = new Size(286, 23);
            effekt.TabIndex = 20;
            effekt.TextChanged += OmhRevurdering;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(380, 91);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 21;
            label8.Text = "R(ohm)=";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 120);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 22;
            label9.Text = "U(V/mv)=";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(371, 146);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 23;
            label11.Text = "I(A/mA)=";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(386, 177);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 24;
            label12.Text = "P(W)=";
            // 
            // utregningfullast
            // 
            utregningfullast.Location = new Point(354, 37);
            utregningfullast.Multiline = true;
            utregningfullast.Name = "utregningfullast";
            utregningfullast.ReadOnly = true;
            utregningfullast.ScrollBars = ScrollBars.Vertical;
            utregningfullast.Size = new Size(404, 117);
            utregningfullast.TabIndex = 25;
            // 
            // regnutfulllast
            // 
            regnutfulllast.Location = new Point(76, 139);
            regnutfulllast.Name = "regnutfulllast";
            regnutfulllast.Size = new Size(75, 23);
            regnutfulllast.TabIndex = 26;
            regnutfulllast.Text = "Regn ut";
            regnutfulllast.UseVisualStyleBackColor = true;
            regnutfulllast.Click += motorfulllastampRegnUt;
            // 
            // fulllast3fas
            // 
            fulllast3fas.AutoSize = true;
            fulllast3fas.Location = new Point(204, 114);
            fulllast3fas.Name = "fulllast3fas";
            fulllast3fas.Size = new Size(63, 19);
            fulllast3fas.TabIndex = 27;
            fulllast3fas.Text = "3 Fase?\r\n";
            fulllast3fas.UseVisualStyleBackColor = true;
            // 
            // fulllastkw
            // 
            fulllastkw.Location = new Point(76, 47);
            fulllastkw.Name = "fulllastkw";
            fulllastkw.PlaceholderText = "2";
            fulllastkw.Size = new Size(100, 23);
            fulllastkw.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 50);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 29;
            label13.Text = "P(kW)=";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 84);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 30;
            label14.Text = "U(V/mv)=";
            // 
            // fullastspenning
            // 
            fullastspenning.Location = new Point(76, 81);
            fullastspenning.Name = "fullastspenning";
            fullastspenning.PlaceholderText = "1V";
            fullastspenning.Size = new Size(100, 23);
            fullastspenning.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(275, 16);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 33;
            label15.Text = "Utregning:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(20, 16);
            label16.Name = "label16";
            label16.Size = new Size(181, 15);
            label16.TabIndex = 34;
            label16.Text = "Motor full last ampere beregning";
            // 
            // cosphimotorfullast
            // 
            cosphimotorfullast.Location = new Point(76, 110);
            cosphimotorfullast.Name = "cosphimotorfullast";
            cosphimotorfullast.Size = new Size(100, 23);
            cosphimotorfullast.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 63);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 37;
            label4.Text = "P(kW)=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 2);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 38;
            label5.Text = "Motor Moment";
            // 
            // utregningmoment
            // 
            utregningmoment.Location = new Point(398, 20);
            utregningmoment.Multiline = true;
            utregningmoment.Name = "utregningmoment";
            utregningmoment.ReadOnly = true;
            utregningmoment.ScrollBars = ScrollBars.Vertical;
            utregningmoment.Size = new Size(360, 191);
            utregningmoment.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 2);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 40;
            label6.Text = "Utregning:";
            // 
            // momkw
            // 
            momkw.Location = new Point(133, 63);
            momkw.Name = "momkw";
            momkw.PlaceholderText = "1";
            momkw.Size = new Size(100, 23);
            momkw.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 34);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 42;
            label7.Text = "Hastighet(RPM) =";
            // 
            // motorvi
            // 
            motorvi.Location = new Point(39, 37);
            motorvi.Name = "motorvi";
            motorvi.PlaceholderText = "1A";
            motorvi.Size = new Size(100, 23);
            motorvi.TabIndex = 43;
            // 
            // motor3fasvirking
            // 
            motor3fasvirking.AutoSize = true;
            motor3fasvirking.Location = new Point(211, 66);
            motor3fasvirking.Name = "motor3fasvirking";
            motor3fasvirking.Size = new Size(63, 19);
            motor3fasvirking.TabIndex = 44;
            motor3fasvirking.Text = "3 Fase?\r\n";
            motor3fasvirking.UseVisualStyleBackColor = true;
            // 
            // motorspenningu
            // 
            motorspenningu.Location = new Point(39, 66);
            motorspenningu.Name = "motorspenningu";
            motorspenningu.PlaceholderText = "1V";
            motorspenningu.Size = new Size(100, 23);
            motorspenningu.TabIndex = 46;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(0, 69);
            label18.Name = "label18";
            label18.Size = new Size(23, 15);
            label18.TabIndex = 45;
            label18.Text = "U=";
            // 
            // momrpm
            // 
            momrpm.Location = new Point(133, 34);
            momrpm.Name = "momrpm";
            momrpm.PlaceholderText = "1";
            momrpm.Size = new Size(100, 23);
            momrpm.TabIndex = 48;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(2, 37);
            label19.Name = "label19";
            label19.Size = new Size(18, 15);
            label19.TabIndex = 47;
            label19.Text = "I=";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ImeMode = ImeMode.NoControl;
            label21.Location = new Point(23, 113);
            label21.Name = "label21";
            label21.Size = new Size(40, 15);
            label21.TabIndex = 54;
            label21.Text = "cosP=";
            // 
            // cosP
            // 
            cosP.Location = new Point(211, 37);
            cosP.Name = "cosP";
            cosP.PlaceholderText = "0.9";
            cosP.Size = new Size(100, 23);
            cosP.TabIndex = 53;
            // 
            // regnutvirkingsgrad
            // 
            regnutvirkingsgrad.Location = new Point(52, 95);
            regnutvirkingsgrad.Name = "regnutvirkingsgrad";
            regnutvirkingsgrad.Size = new Size(75, 23);
            regnutvirkingsgrad.TabIndex = 52;
            regnutvirkingsgrad.Text = "Regn ut";
            regnutvirkingsgrad.UseVisualStyleBackColor = true;
            regnutvirkingsgrad.Click += MotorVirkingsgradRegnut;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(fulllasthp);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(utregningfullast);
            panel2.Controls.Add(regnutfulllast);
            panel2.Controls.Add(fulllast3fas);
            panel2.Controls.Add(fulllastkw);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(fullastspenning);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(cosphimotorfullast);
            panel2.Location = new Point(12, 563);
            panel2.Name = "panel2";
            panel2.Size = new Size(763, 168);
            panel2.TabIndex = 50;
            // 
            // fulllasthp
            // 
            fulllasthp.Location = new Point(204, 68);
            fulllasthp.Name = "fulllasthp";
            fulllasthp.Size = new Size(100, 23);
            fulllasthp.TabIndex = 56;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ImeMode = ImeMode.NoControl;
            label17.Location = new Point(182, 50);
            label17.Name = "label17";
            label17.Size = new Size(111, 15);
            label17.TabIndex = 55;
            label17.Text = "HP(virkningsgrad)=";
            toolTip1.SetToolTip(label17, "Beregning av HP, da trenger man virkningraden");
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(regnutmoment);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(utregningmoment);
            panel3.Controls.Add(momrpm);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(momkw);
            panel3.Location = new Point(12, 344);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(763, 216);
            panel3.TabIndex = 51;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(motorspenningu);
            groupBox1.Controls.Add(cosP);
            groupBox1.Controls.Add(motor3fasvirking);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(regnutvirkingsgrad);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(motorvi);
            groupBox1.Location = new Point(3, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 120);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Motor virkningsgrad";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ImeMode = ImeMode.NoControl;
            label20.Location = new Point(165, 37);
            label20.Name = "label20";
            label20.Size = new Size(40, 15);
            label20.TabIndex = 57;
            label20.Text = "cosP=";
            // 
            // regnutmoment
            // 
            regnutmoment.Location = new Point(239, 63);
            regnutmoment.Name = "regnutmoment";
            regnutmoment.Size = new Size(75, 23);
            regnutmoment.TabIndex = 53;
            regnutmoment.Text = "Regn ut";
            regnutmoment.UseVisualStyleBackColor = true;
            regnutmoment.Click += MotorMomentRegnut;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(347, 323);
            label22.Name = "label22";
            label22.Size = new Size(0, 15);
            label22.TabIndex = 52;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.Location = new Point(782, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(271, 326);
            richTextBox1.TabIndex = 53;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.Info;
            richTextBox2.Location = new Point(782, 347);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(271, 379);
            richTextBox2.TabIndex = 54;
            richTextBox2.Text = "";
            // 
            // hovedside
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 730);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label22);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(effekt);
            Controls.Add(ampere);
            Controls.Add(spenning);
            Controls.Add(label10);
            Controls.Add(Motstander);
            Controls.Add(utregningohm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(formalohm);
            Controls.Add(label1);
            Controls.Add(valgtformel);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "hovedside";
            Text = "Elektroformler pt1 (Produsert av Aleksander TH)";
            Load += hovedside_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox valgtformel;
        private Label label1;
        private TextBox formalohm;
        private Label label2;
        private Label label3;
        private TextBox utregningohm;
        private TextBox Motstander;
        private Label label10;
        private TextBox spenning;
        private TextBox ampere;
        private TextBox effekt;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private TextBox utregningfullast;
        private Button regnutfulllast;
        private CheckBox fulllast3fas;
        private TextBox fulllastkw;
        private Label label13;
        private Label label14;
        private TextBox fullastspenning;
        private Label label15;
        private Label label16;
        private TextBox cosphimotorfullast;
        private Label label4;
        private Label label5;
        private TextBox utregningmoment;
        private Label label6;
        private TextBox momkw;
        private Label label7;
        private TextBox motorvi;
        private CheckBox motor3fasvirking;
        private TextBox motorspenningu;
        private Label label18;
        private TextBox momrpm;
        private Label label19;
        private Panel panel2;
        private Panel panel3;
        private Button regnutvirkingsgrad;
        private Button regnutmoment;
        private Label label21;
        private TextBox cosP;
        private GroupBox groupBox1;
        private ToolTip toolTip1;
        private Label label17;
        private TextBox fulllasthp;
        private Label label20;
        private Label label22;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}
