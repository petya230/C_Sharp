namespace wfVezerlok1
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
            this.lblCímke = new System.Windows.Forms.Label();
            this.btnGomb = new System.Windows.Forms.Button();
            this.chbHírlevél = new System.Windows.Forms.CheckBox();
            this.cbSzínek = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCímke
            // 
            this.lblCímke.AutoSize = true;
            this.lblCímke.Location = new System.Drawing.Point(10, 13);
            this.lblCímke.Name = "lblCímke";
            this.lblCímke.Size = new System.Drawing.Size(72, 13);
            this.lblCímke.TabIndex = 0;
            this.lblCímke.Text = "Ez egy címke";
            this.lblCímke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGomb
            // 
            this.btnGomb.Location = new System.Drawing.Point(13, 415);
            this.btnGomb.Name = "btnGomb";
            this.btnGomb.Size = new System.Drawing.Size(775, 23);
            this.btnGomb.TabIndex = 1;
            this.btnGomb.Text = "Nem csinál semmit.";
            this.btnGomb.UseVisualStyleBackColor = true;
            // 
            // chbHírlevél
            // 
            this.chbHírlevél.AutoSize = true;
            this.chbHírlevél.Checked = true;
            this.chbHírlevél.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHírlevél.Location = new System.Drawing.Point(91, 13);
            this.chbHírlevél.Name = "chbHírlevél";
            this.chbHírlevél.Size = new System.Drawing.Size(63, 17);
            this.chbHírlevél.TabIndex = 2;
            this.chbHírlevél.Text = "Hírlevél";
            this.chbHírlevél.UseVisualStyleBackColor = true;
            // 
            // cbSzínek
            // 
            this.cbSzínek.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSzínek.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSzínek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSzínek.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSzínek.FormattingEnabled = true;
            this.cbSzínek.Items.AddRange(new object[] {
            "Piros",
            "Fehér",
            "Kék",
            "Fekete"});
            this.cbSzínek.Location = new System.Drawing.Point(667, 13);
            this.cbSzínek.Name = "cbSzínek";
            this.cbSzínek.Size = new System.Drawing.Size(121, 21);
            this.cbSzínek.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 386);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(775, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Egysoros";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::wfVezerlok1.Properties.Resources.paprika;
            this.pictureBox1.Location = new System.Drawing.Point(302, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cbSzínek);
            this.Controls.Add(this.chbHírlevél);
            this.Controls.Add(this.btnGomb);
            this.Controls.Add(this.lblCímke);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCímke;
        private System.Windows.Forms.Button btnGomb;
        private System.Windows.Forms.CheckBox chbHírlevél;
        private System.Windows.Forms.ComboBox cbSzínek;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

