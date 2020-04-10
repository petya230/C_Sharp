namespace SocketClientGUI
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
            this.IP_label = new System.Windows.Forms.Label();
            this.PORT_label = new System.Windows.Forms.Label();
            this.IpBE_textBox = new System.Windows.Forms.TextBox();
            this.PortBE_textBox = new System.Windows.Forms.TextBox();
            this.SajatSzoveg_textBox = new System.Windows.Forms.TextBox();
            this.sajatszoveg_label = new System.Windows.Forms.Label();
            this.Ora_checkBox = new System.Windows.Forms.CheckBox();
            this.CPU_checkBox = new System.Windows.Forms.CheckBox();
            this.Idojaras_checkBox = new System.Windows.Forms.CheckBox();
            this.SzobaHo_checkBox = new System.Windows.Forms.CheckBox();
            this.Nevnapok_checkBox = new System.Windows.Forms.CheckBox();
            this.SajatSzoveg_checkBox = new System.Windows.Forms.CheckBox();
            this.Csatlakozas_btn = new System.Windows.Forms.Button();
            this.Lecsatlakozas_btn = new System.Windows.Forms.Button();
            this.kuld_btn = new System.Windows.Forms.Button();
            this.csatlakozva_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kilep_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IP_label
            // 
            this.IP_label.AutoSize = true;
            this.IP_label.Location = new System.Drawing.Point(12, 16);
            this.IP_label.Name = "IP_label";
            this.IP_label.Size = new System.Drawing.Size(20, 13);
            this.IP_label.TabIndex = 0;
            this.IP_label.Text = "IP:";
            // 
            // PORT_label
            // 
            this.PORT_label.AutoSize = true;
            this.PORT_label.Location = new System.Drawing.Point(12, 43);
            this.PORT_label.Name = "PORT_label";
            this.PORT_label.Size = new System.Drawing.Size(29, 13);
            this.PORT_label.TabIndex = 1;
            this.PORT_label.Text = "Port:";
            // 
            // IpBE_textBox
            // 
            this.IpBE_textBox.Location = new System.Drawing.Point(55, 13);
            this.IpBE_textBox.Name = "IpBE_textBox";
            this.IpBE_textBox.Size = new System.Drawing.Size(136, 20);
            this.IpBE_textBox.TabIndex = 2;
            this.IpBE_textBox.Text = "127.0.0.1";
            // 
            // PortBE_textBox
            // 
            this.PortBE_textBox.Location = new System.Drawing.Point(55, 40);
            this.PortBE_textBox.Name = "PortBE_textBox";
            this.PortBE_textBox.Size = new System.Drawing.Size(136, 20);
            this.PortBE_textBox.TabIndex = 3;
            this.PortBE_textBox.Text = "12345";
            this.PortBE_textBox.TextChanged += new System.EventHandler(this.PortBE_textBox_TextChanged);
            this.PortBE_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortBE_textBox_KeyPress_1);
            // 
            // SajatSzoveg_textBox
            // 
            this.SajatSzoveg_textBox.Location = new System.Drawing.Point(300, 13);
            this.SajatSzoveg_textBox.Name = "SajatSzoveg_textBox";
            this.SajatSzoveg_textBox.Size = new System.Drawing.Size(200, 20);
            this.SajatSzoveg_textBox.TabIndex = 4;
            this.SajatSzoveg_textBox.Text = "blablablabla";
            // 
            // sajatszoveg_label
            // 
            this.sajatszoveg_label.AutoSize = true;
            this.sajatszoveg_label.Location = new System.Drawing.Point(223, 16);
            this.sajatszoveg_label.Name = "sajatszoveg_label";
            this.sajatszoveg_label.Size = new System.Drawing.Size(71, 13);
            this.sajatszoveg_label.TabIndex = 5;
            this.sajatszoveg_label.Text = "Saját szöveg:";
            // 
            // Ora_checkBox
            // 
            this.Ora_checkBox.AutoSize = true;
            this.Ora_checkBox.Location = new System.Drawing.Point(6, 21);
            this.Ora_checkBox.Name = "Ora_checkBox";
            this.Ora_checkBox.Size = new System.Drawing.Size(43, 17);
            this.Ora_checkBox.TabIndex = 0;
            this.Ora_checkBox.Text = "Óra";
            this.Ora_checkBox.UseVisualStyleBackColor = true;
            // 
            // CPU_checkBox
            // 
            this.CPU_checkBox.AutoSize = true;
            this.CPU_checkBox.Location = new System.Drawing.Point(6, 45);
            this.CPU_checkBox.Name = "CPU_checkBox";
            this.CPU_checkBox.Size = new System.Drawing.Size(108, 17);
            this.CPU_checkBox.TabIndex = 1;
            this.CPU_checkBox.Text = "CPU hőmérséklet";
            this.CPU_checkBox.UseVisualStyleBackColor = true;
            // 
            // Idojaras_checkBox
            // 
            this.Idojaras_checkBox.AutoSize = true;
            this.Idojaras_checkBox.Location = new System.Drawing.Point(6, 69);
            this.Idojaras_checkBox.Name = "Idojaras_checkBox";
            this.Idojaras_checkBox.Size = new System.Drawing.Size(63, 17);
            this.Idojaras_checkBox.TabIndex = 2;
            this.Idojaras_checkBox.Text = "Időjárás";
            this.Idojaras_checkBox.UseVisualStyleBackColor = true;
            // 
            // SzobaHo_checkBox
            // 
            this.SzobaHo_checkBox.AutoSize = true;
            this.SzobaHo_checkBox.Location = new System.Drawing.Point(6, 93);
            this.SzobaHo_checkBox.Name = "SzobaHo_checkBox";
            this.SzobaHo_checkBox.Size = new System.Drawing.Size(113, 17);
            this.SzobaHo_checkBox.TabIndex = 3;
            this.SzobaHo_checkBox.Text = "Szobahőmérséklet";
            this.SzobaHo_checkBox.UseVisualStyleBackColor = true;
            // 
            // Nevnapok_checkBox
            // 
            this.Nevnapok_checkBox.AutoSize = true;
            this.Nevnapok_checkBox.Location = new System.Drawing.Point(6, 117);
            this.Nevnapok_checkBox.Name = "Nevnapok_checkBox";
            this.Nevnapok_checkBox.Size = new System.Drawing.Size(76, 17);
            this.Nevnapok_checkBox.TabIndex = 4;
            this.Nevnapok_checkBox.Text = "Névnapok";
            this.Nevnapok_checkBox.UseVisualStyleBackColor = true;
            // 
            // SajatSzoveg_checkBox
            // 
            this.SajatSzoveg_checkBox.AutoSize = true;
            this.SajatSzoveg_checkBox.Location = new System.Drawing.Point(6, 141);
            this.SajatSzoveg_checkBox.Name = "SajatSzoveg_checkBox";
            this.SajatSzoveg_checkBox.Size = new System.Drawing.Size(87, 17);
            this.SajatSzoveg_checkBox.TabIndex = 5;
            this.SajatSzoveg_checkBox.Text = "Saját szöveg";
            this.SajatSzoveg_checkBox.UseVisualStyleBackColor = true;
            // 
            // Csatlakozas_btn
            // 
            this.Csatlakozas_btn.Location = new System.Drawing.Point(12, 275);
            this.Csatlakozas_btn.Name = "Csatlakozas_btn";
            this.Csatlakozas_btn.Size = new System.Drawing.Size(75, 23);
            this.Csatlakozas_btn.TabIndex = 7;
            this.Csatlakozas_btn.Text = "Csatlakozás";
            this.Csatlakozas_btn.UseVisualStyleBackColor = true;
            this.Csatlakozas_btn.Click += new System.EventHandler(this.Csatlakozas_btn_Click);
            // 
            // Lecsatlakozas_btn
            // 
            this.Lecsatlakozas_btn.Location = new System.Drawing.Point(93, 275);
            this.Lecsatlakozas_btn.Name = "Lecsatlakozas_btn";
            this.Lecsatlakozas_btn.Size = new System.Drawing.Size(98, 23);
            this.Lecsatlakozas_btn.TabIndex = 8;
            this.Lecsatlakozas_btn.Text = "Lecsatlakozás";
            this.Lecsatlakozas_btn.UseVisualStyleBackColor = true;
            this.Lecsatlakozas_btn.Click += new System.EventHandler(this.Lecsatlakozas_btn_Click);
            // 
            // kuld_btn
            // 
            this.kuld_btn.Location = new System.Drawing.Point(300, 275);
            this.kuld_btn.Name = "kuld_btn";
            this.kuld_btn.Size = new System.Drawing.Size(75, 23);
            this.kuld_btn.TabIndex = 9;
            this.kuld_btn.Text = "Küldés";
            this.kuld_btn.UseVisualStyleBackColor = true;
            this.kuld_btn.Click += new System.EventHandler(this.kuld_btn_Click);
            // 
            // csatlakozva_label
            // 
            this.csatlakozva_label.AutoSize = true;
            this.csatlakozva_label.Location = new System.Drawing.Point(55, 244);
            this.csatlakozva_label.Name = "csatlakozva_label";
            this.csatlakozva_label.Size = new System.Drawing.Size(71, 13);
            this.csatlakozva_label.TabIndex = 10;
            this.csatlakozva_label.Text = "Csatlakozva?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SajatSzoveg_checkBox);
            this.groupBox1.Controls.Add(this.Nevnapok_checkBox);
            this.groupBox1.Controls.Add(this.Ora_checkBox);
            this.groupBox1.Controls.Add(this.SzobaHo_checkBox);
            this.groupBox1.Controls.Add(this.CPU_checkBox);
            this.groupBox1.Controls.Add(this.Idojaras_checkBox);
            this.groupBox1.Location = new System.Drawing.Point(300, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 175);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funkciók";
            // 
            // kilep_btn
            // 
            this.kilep_btn.Location = new System.Drawing.Point(424, 274);
            this.kilep_btn.Name = "kilep_btn";
            this.kilep_btn.Size = new System.Drawing.Size(75, 23);
            this.kilep_btn.TabIndex = 12;
            this.kilep_btn.Text = "Kilépés";
            this.kilep_btn.UseVisualStyleBackColor = true;
            this.kilep_btn.Click += new System.EventHandler(this.kilep_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 310);
            this.Controls.Add(this.kilep_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.csatlakozva_label);
            this.Controls.Add(this.kuld_btn);
            this.Controls.Add(this.Lecsatlakozas_btn);
            this.Controls.Add(this.Csatlakozas_btn);
            this.Controls.Add(this.sajatszoveg_label);
            this.Controls.Add(this.SajatSzoveg_textBox);
            this.Controls.Add(this.PortBE_textBox);
            this.Controls.Add(this.IpBE_textBox);
            this.Controls.Add(this.PORT_label);
            this.Controls.Add(this.IP_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Kijelző konfigurálás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IP_label;
        private System.Windows.Forms.Label PORT_label;
        private System.Windows.Forms.TextBox IpBE_textBox;
        private System.Windows.Forms.TextBox PortBE_textBox;
        private System.Windows.Forms.TextBox SajatSzoveg_textBox;
        private System.Windows.Forms.Label sajatszoveg_label;
        private System.Windows.Forms.CheckBox SajatSzoveg_checkBox;
        private System.Windows.Forms.CheckBox Nevnapok_checkBox;
        private System.Windows.Forms.CheckBox SzobaHo_checkBox;
        private System.Windows.Forms.CheckBox Idojaras_checkBox;
        private System.Windows.Forms.CheckBox CPU_checkBox;
        private System.Windows.Forms.CheckBox Ora_checkBox;
        private System.Windows.Forms.Button Csatlakozas_btn;
        private System.Windows.Forms.Button Lecsatlakozas_btn;
        private System.Windows.Forms.Button kuld_btn;
        private System.Windows.Forms.Label csatlakozva_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kilep_btn;
    }
}

