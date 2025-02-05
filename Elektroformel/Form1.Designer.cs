namespace Elektroformel
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox8 = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            textBox9 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textBox10 = new TextBox();
            checkBox2 = new CheckBox();
            label15 = new Label();
            label16 = new Label();
            textBox11 = new TextBox();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // textBox1
            // 
            textBox1.Location = new Point(441, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 15);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Valgt formel:";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(441, 41);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 3;
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
            label3.Location = new Point(362, 232);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Utregning:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(441, 232);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 111);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 359);
            label4.Name = "label4";
            label4.Size = new Size(373, 15);
            label4.TabIndex = 0;
            label4.Text = "Single Phase AC Motor FLA (Amperes) = (P [kW] × 1000) / (V × cos ϕ)";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 385);
            label5.Name = "label5";
            label5.Size = new Size(387, 15);
            label5.TabIndex = 7;
            label5.Text = "Single Phase AC Motor FLA (Amperes) = (P [HP] × 746) / (V × cos ϕ × η)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 410);
            label6.Name = "label6";
            label6.Size = new Size(411, 15);
            label6.TabIndex = 8;
            label6.Text = "Three Phase AC Motor FLA (Amperes) = (P [kW] × 1000) / (V × 1.732 × cos ϕ)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 434);
            label7.Name = "label7";
            label7.Size = new Size(425, 15);
            label7.TabIndex = 9;
            label7.Text = "Three Phase AC Motor FLA (Amperes) = (P [HP] × 746) / (V × 1.732 × cos ϕ × η)";
            // 
            // button1
            // 
            button1.Location = new Point(663, 203);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Regn ut";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(441, 88);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(286, 23);
            textBox5.TabIndex = 16;
            textBox5.Text = "R1=2.0,R2=3.0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(342, 88);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 17;
            label10.Text = "Verdier";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(441, 117);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(286, 23);
            textBox4.TabIndex = 18;
            textBox4.Text = "12V";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(441, 146);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(286, 23);
            textBox6.TabIndex = 19;
            textBox6.Text = "400A";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(441, 174);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(286, 23);
            textBox7.TabIndex = 20;
            textBox7.Text = "300W";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(411, 91);
            label8.Name = "label8";
            label8.Size = new Size(22, 15);
            label8.TabIndex = 21;
            label8.Text = "R=";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(411, 120);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 22;
            label9.Text = "U=";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(411, 146);
            label11.Name = "label11";
            label11.Size = new Size(18, 15);
            label11.TabIndex = 23;
            label11.Text = "I=";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(411, 177);
            label12.Name = "label12";
            label12.Size = new Size(22, 15);
            label12.TabIndex = 24;
            label12.Text = "P=";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(401, 531);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(297, 111);
            textBox8.TabIndex = 25;
            // 
            // button2
            // 
            button2.Location = new Point(118, 643);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "Regn ut";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(211, 574);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 19);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "3 Fase?\r\n";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(105, 541);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(52, 544);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 29;
            label13.Text = "P(kW)=";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(66, 578);
            label14.Name = "label14";
            label14.Size = new Size(23, 15);
            label14.TabIndex = 30;
            label14.Text = "U=";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(105, 575);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 31;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(211, 541);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(95, 19);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "Hestekrefter?";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(322, 510);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 33;
            label15.Text = "Utregning:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(67, 510);
            label16.Name = "label16";
            label16.Size = new Size(181, 15);
            label16.TabIndex = 34;
            label16.Text = "Motor full last ampere beregning";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(105, 604);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 35;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(67, 607);
            label17.Name = "label17";
            label17.Size = new Size(22, 15);
            label17.TabIndex = 36;
            label17.Text = "η=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 678);
            Controls.Add(label17);
            Controls.Add(textBox11);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(checkBox2);
            Controls.Add(textBox10);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(textBox9);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(textBox8);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(label10);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private TextBox textBox8;
        private Button button2;
        private CheckBox checkBox1;
        private TextBox textBox9;
        private Label label13;
        private Label label14;
        private TextBox textBox10;
        private CheckBox checkBox2;
        private Label label15;
        private Label label16;
        private TextBox textBox11;
        private Label label17;
    }
}
