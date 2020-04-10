namespace Dolgozok
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.LanyokCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FiukCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HatEveLBL = new System.Windows.Forms.Label();
            this.OsszesKorLBL = new System.Windows.Forms.Label();
            this.legidosebbLBL = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Adatok = new System.Windows.Forms.GroupBox();
            this.miotaLBL = new System.Windows.Forms.Label();
            this.KorLBL = new System.Windows.Forms.Label();
            this.MentesBTN = new System.Windows.Forms.Button();
            this.Mindekettonem = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.Adatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lányok:";
            // 
            // LanyokCombo
            // 
            this.LanyokCombo.FormattingEnabled = true;
            this.LanyokCombo.Location = new System.Drawing.Point(61, 10);
            this.LanyokCombo.Name = "LanyokCombo";
            this.LanyokCombo.Size = new System.Drawing.Size(137, 21);
            this.LanyokCombo.TabIndex = 1;
            this.LanyokCombo.SelectedIndexChanged += new System.EventHandler(this.LanyokCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiúk:";
            // 
            // FiukCombo
            // 
            this.FiukCombo.FormattingEnabled = true;
            this.FiukCombo.Location = new System.Drawing.Point(281, 10);
            this.FiukCombo.Name = "FiukCombo";
            this.FiukCombo.Size = new System.Drawing.Size(141, 21);
            this.FiukCombo.TabIndex = 3;
            this.FiukCombo.SelectedIndexChanged += new System.EventHandler(this.FiukCombo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HatEveLBL);
            this.groupBox1.Controls.Add(this.OsszesKorLBL);
            this.groupBox1.Controls.Add(this.legidosebbLBL);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(16, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Összesítő";
            // 
            // HatEveLBL
            // 
            this.HatEveLBL.AutoSize = true;
            this.HatEveLBL.Location = new System.Drawing.Point(7, 111);
            this.HatEveLBL.Name = "HatEveLBL";
            this.HatEveLBL.Size = new System.Drawing.Size(77, 13);
            this.HatEveLBL.TabIndex = 4;
            this.HatEveLBL.Text = "6 éve dolgozó:";
            // 
            // OsszesKorLBL
            // 
            this.OsszesKorLBL.AutoSize = true;
            this.OsszesKorLBL.Location = new System.Drawing.Point(7, 84);
            this.OsszesKorLBL.Name = "OsszesKorLBL";
            this.OsszesKorLBL.Size = new System.Drawing.Size(62, 13);
            this.OsszesKorLBL.TabIndex = 3;
            this.OsszesKorLBL.Text = "Összes kor:";
            // 
            // legidosebbLBL
            // 
            this.legidosebbLBL.AutoSize = true;
            this.legidosebbLBL.Location = new System.Drawing.Point(7, 57);
            this.legidosebbLBL.Name = "legidosebbLBL";
            this.legidosebbLBL.Size = new System.Drawing.Size(65, 13);
            this.legidosebbLBL.TabIndex = 2;
            this.legidosebbLBL.Text = "Legidősebb:";
            this.legidosebbLBL.Click += new System.EventHandler(this.legidosebbLBL_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(62, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fiú";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lány";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Adatok
            // 
            this.Adatok.Controls.Add(this.miotaLBL);
            this.Adatok.Controls.Add(this.KorLBL);
            this.Adatok.Location = new System.Drawing.Point(248, 68);
            this.Adatok.Name = "Adatok";
            this.Adatok.Size = new System.Drawing.Size(174, 100);
            this.Adatok.TabIndex = 5;
            this.Adatok.TabStop = false;
            this.Adatok.Text = "Adatok";
            // 
            // miotaLBL
            // 
            this.miotaLBL.AutoSize = true;
            this.miotaLBL.Location = new System.Drawing.Point(6, 57);
            this.miotaLBL.Name = "miotaLBL";
            this.miotaLBL.Size = new System.Drawing.Size(78, 13);
            this.miotaLBL.TabIndex = 1;
            this.miotaLBL.Text = "Mióta dolgozik:";
            // 
            // KorLBL
            // 
            this.KorLBL.AutoSize = true;
            this.KorLBL.Location = new System.Drawing.Point(6, 24);
            this.KorLBL.Name = "KorLBL";
            this.KorLBL.Size = new System.Drawing.Size(26, 13);
            this.KorLBL.TabIndex = 0;
            this.KorLBL.Text = "Kor:";
            // 
            // MentesBTN
            // 
            this.MentesBTN.Location = new System.Drawing.Point(248, 224);
            this.MentesBTN.Name = "MentesBTN";
            this.MentesBTN.Size = new System.Drawing.Size(174, 23);
            this.MentesBTN.TabIndex = 6;
            this.MentesBTN.Text = "Mentes";
            this.MentesBTN.UseVisualStyleBackColor = true;
            this.MentesBTN.Click += new System.EventHandler(this.MentesBTN_Click);
            // 
            // Mindekettonem
            // 
            this.Mindekettonem.AutoSize = true;
            this.Mindekettonem.Location = new System.Drawing.Point(248, 179);
            this.Mindekettonem.Name = "Mindekettonem";
            this.Mindekettonem.Size = new System.Drawing.Size(96, 17);
            this.Mindekettonem.TabIndex = 7;
            this.Mindekettonem.Text = "Mindkettő nem";
            this.Mindekettonem.UseVisualStyleBackColor = true;
            this.Mindekettonem.CheckedChanged += new System.EventHandler(this.Mindekettonem_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mindekettonem);
            this.Controls.Add(this.MentesBTN);
            this.Controls.Add(this.Adatok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FiukCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LanyokCombo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dolgozók";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Adatok.ResumeLayout(false);
            this.Adatok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LanyokCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiukCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label HatEveLBL;
        private System.Windows.Forms.Label OsszesKorLBL;
        private System.Windows.Forms.Label legidosebbLBL;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox Adatok;
        private System.Windows.Forms.Label miotaLBL;
        private System.Windows.Forms.Label KorLBL;
        private System.Windows.Forms.Button MentesBTN;
        private System.Windows.Forms.CheckBox Mindekettonem;
    }
}

