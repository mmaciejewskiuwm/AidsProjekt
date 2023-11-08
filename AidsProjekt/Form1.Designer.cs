namespace AidsProjekt
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
            tbxLiczba = new TextBox();
            tbxWynik = new TextBox();
            btSB = new Button();
            btSS = new Button();
            btSI = new Button();
            btSM = new Button();
            btSQ = new Button();
            chbPrzelacz = new CheckBox();
            nudDlugosc = new NumericUpDown();
            btGen = new Button();
            lbNapis = new Label();
            lbCzas = new Label();
            lbNapisLewa = new Label();
            lbNapisPrawa = new Label();
            btWyswietl = new Button();
            btWyczysc = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btCzyscListy = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDlugosc).BeginInit();
            SuspendLayout();
            // 
            // tbxLiczba
            // 
            tbxLiczba.Location = new Point(76, 86);
            tbxLiczba.Multiline = true;
            tbxLiczba.Name = "tbxLiczba";
            tbxLiczba.Size = new Size(185, 37);
            tbxLiczba.TabIndex = 0;
            tbxLiczba.TextChanged += tbxLiczba_TextChanged;
            // 
            // tbxWynik
            // 
            tbxWynik.Location = new Point(76, 169);
            tbxWynik.Multiline = true;
            tbxWynik.Name = "tbxWynik";
            tbxWynik.Size = new Size(185, 39);
            tbxWynik.TabIndex = 1;
            tbxWynik.TextChanged += tbxWynik_TextChanged;
            // 
            // btSB
            // 
            btSB.Location = new Point(98, 315);
            btSB.Name = "btSB";
            btSB.Size = new Size(75, 47);
            btSB.TabIndex = 2;
            btSB.Text = "Bubble Sort";
            btSB.UseVisualStyleBackColor = true;
            btSB.Click += btSB_Click;
            // 
            // btSS
            // 
            btSS.Location = new Point(239, 315);
            btSS.Name = "btSS";
            btSS.Size = new Size(75, 47);
            btSS.TabIndex = 3;
            btSS.Text = "Selection  Sort";
            btSS.UseVisualStyleBackColor = true;
            btSS.Click += btSS_Click;
            // 
            // btSI
            // 
            btSI.Location = new Point(378, 315);
            btSI.Name = "btSI";
            btSI.Size = new Size(75, 47);
            btSI.TabIndex = 4;
            btSI.Text = "Insertion Sort";
            btSI.UseVisualStyleBackColor = true;
            btSI.Click += btSI_Click;
            // 
            // btSM
            // 
            btSM.Location = new Point(521, 315);
            btSM.Name = "btSM";
            btSM.Size = new Size(75, 47);
            btSM.TabIndex = 5;
            btSM.Text = "Merge Sort";
            btSM.UseVisualStyleBackColor = true;
            btSM.Click += btSM_Click;
            // 
            // btSQ
            // 
            btSQ.Location = new Point(659, 315);
            btSQ.Name = "btSQ";
            btSQ.Size = new Size(75, 47);
            btSQ.TabIndex = 6;
            btSQ.Text = "Quick Sort";
            btSQ.UseVisualStyleBackColor = true;
            btSQ.Click += btSQ_Click;
            // 
            // chbPrzelacz
            // 
            chbPrzelacz.AutoSize = true;
            chbPrzelacz.Location = new Point(329, 86);
            chbPrzelacz.Name = "chbPrzelacz";
            chbPrzelacz.Size = new Size(148, 19);
            chbPrzelacz.TabIndex = 7;
            chbPrzelacz.Text = "Aktualnie wybrana lista";
            chbPrzelacz.UseVisualStyleBackColor = true;
            chbPrzelacz.CheckedChanged += chbPrzelacz_CheckedChanged;
            // 
            // nudDlugosc
            // 
            nudDlugosc.Location = new Point(538, 86);
            nudDlugosc.Name = "nudDlugosc";
            nudDlugosc.Size = new Size(182, 23);
            nudDlugosc.TabIndex = 8;
            nudDlugosc.ValueChanged += nudDlugosc_ValueChanged;
            // 
            // btGen
            // 
            btGen.Location = new Point(560, 115);
            btGen.Name = "btGen";
            btGen.Size = new Size(116, 43);
            btGen.TabIndex = 9;
            btGen.Text = "Generuj!";
            btGen.UseVisualStyleBackColor = true;
            btGen.Click += btGen_Click;
            // 
            // lbNapis
            // 
            lbNapis.AutoSize = true;
            lbNapis.Location = new Point(329, 172);
            lbNapis.Name = "lbNapis";
            lbNapis.Size = new Size(94, 15);
            lbNapis.TabIndex = 10;
            lbNapis.Text = "Czas wykonania:";
            // 
            // lbCzas
            // 
            lbCzas.AutoSize = true;
            lbCzas.Location = new Point(441, 172);
            lbCzas.Name = "lbCzas";
            lbCzas.Size = new Size(12, 15);
            lbCzas.TabIndex = 11;
            lbCzas.Text = "-";
            lbCzas.Click += lbCzas_Click;
            // 
            // lbNapisLewa
            // 
            lbNapisLewa.AutoSize = true;
            lbNapisLewa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNapisLewa.Location = new Point(130, 9);
            lbNapisLewa.Name = "lbNapisLewa";
            lbNapisLewa.Size = new Size(71, 32);
            lbNapisLewa.TabIndex = 12;
            lbNapisLewa.Text = "Lewa";
            lbNapisLewa.Click += label1_Click;
            // 
            // lbNapisPrawa
            // 
            lbNapisPrawa.AutoSize = true;
            lbNapisPrawa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNapisPrawa.ForeColor = SystemColors.AppWorkspace;
            lbNapisPrawa.Location = new Point(592, 9);
            lbNapisPrawa.Name = "lbNapisPrawa";
            lbNapisPrawa.Size = new Size(84, 32);
            lbNapisPrawa.TabIndex = 13;
            lbNapisPrawa.Text = "Prawa";
            // 
            // btWyswietl
            // 
            btWyswietl.Location = new Point(538, 183);
            btWyswietl.Name = "btWyswietl";
            btWyswietl.Size = new Size(95, 58);
            btWyswietl.TabIndex = 14;
            btWyswietl.Text = "Wyswietl wygenerowana liste";
            btWyswietl.UseVisualStyleBackColor = true;
            btWyswietl.Click += btWyswietl_Click;
            // 
            // btWyczysc
            // 
            btWyczysc.Location = new Point(639, 183);
            btWyczysc.Name = "btWyczysc";
            btWyczysc.Size = new Size(95, 58);
            btWyczysc.TabIndex = 15;
            btWyczysc.Text = "Wyczysc wygenerowana liste";
            btWyczysc.UseVisualStyleBackColor = true;
            btWyczysc.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 63);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 16;
            label1.Text = "Twoja lista:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 143);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 17;
            label2.Text = "Wynik sortowania:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(521, 68);
            label3.Name = "label3";
            label3.Size = new Size(215, 15);
            label3.TabIndex = 18;
            label3.Text = "Podaj dlugosc listy do wygenerowania :";
            // 
            // btCzyscListy
            // 
            btCzyscListy.Location = new Point(128, 226);
            btCzyscListy.Name = "btCzyscListy";
            btCzyscListy.Size = new Size(87, 52);
            btCzyscListy.TabIndex = 19;
            btCzyscListy.Text = "Wyczysc pola z listami";
            btCzyscListy.UseVisualStyleBackColor = true;
            btCzyscListy.Click += btCzyscListy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCzyscListy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btWyczysc);
            Controls.Add(btWyswietl);
            Controls.Add(lbNapisPrawa);
            Controls.Add(lbNapisLewa);
            Controls.Add(lbCzas);
            Controls.Add(lbNapis);
            Controls.Add(btGen);
            Controls.Add(nudDlugosc);
            Controls.Add(chbPrzelacz);
            Controls.Add(btSQ);
            Controls.Add(btSM);
            Controls.Add(btSI);
            Controls.Add(btSS);
            Controls.Add(btSB);
            Controls.Add(tbxWynik);
            Controls.Add(tbxLiczba);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDlugosc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxLiczba;
        private TextBox tbxWynik;
        private Button btSB;
        private Button btSS;
        private Button btSI;
        private Button btSM;
        private Button btSQ;
        private CheckBox chbPrzelacz;
        private NumericUpDown nudDlugosc;
        private Button btGen;
        private Label lbNapis;
        private Label lbCzas;
        private Label lbNapisLewa;
        private Label lbNapisPrawa;
        private Button btWyswietl;
        private Button btWyczysc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btCzyscListy;
    }
}