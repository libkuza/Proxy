namespace KuzaProxy
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewPublicIP = new System.Windows.Forms.Label();
            this.reaperButton1 = new ReaperTheme.Controls.ReaperButton();
            this.reaperButton2 = new ReaperTheme.Controls.ReaperButton();
            this.UpdateBtn = new ReaperTheme.Controls.ReaperButton();
            this.reaperButton3 = new ReaperTheme.Controls.ReaperButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownWidth = 200;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "===SaturnProxy===",
            "",
            "===Asia===",
            "Malediven01",
            "Russia01",
            "Iran01",
            "Singapore01",
            "Thailand01",
            "Thailand02",
            "",
            "===Europe===",
            "Germany01",
            "Germany02",
            "Germany03",
            "France01",
            "France02",
            "Poland01",
            "",
            "===America===",
            "Mexiko01",
            "Brazil01",
            "US01",
            "US02",
            "Honduras01",
            "",
            "===Australia===",
            "",
            "",
            "✔ = Verified"});
            this.comboBox1.Location = new System.Drawing.Point(29, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(356, 22);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Change Proxy";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current IP Address:";
            // 
            // viewPublicIP
            // 
            this.viewPublicIP.AutoSize = true;
            this.viewPublicIP.ForeColor = System.Drawing.Color.White;
            this.viewPublicIP.Location = new System.Drawing.Point(172, 197);
            this.viewPublicIP.Name = "viewPublicIP";
            this.viewPublicIP.Size = new System.Drawing.Size(56, 14);
            this.viewPublicIP.TabIndex = 4;
            this.viewPublicIP.Text = "0.0.0.0";
            // 
            // reaperButton1
            // 
            this.reaperButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reaperButton1.ButtonState = ReaperTheme.ReaperEnums.ReaperButtonState.Normal;
            this.reaperButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.reaperButton1.HoverColor = System.Drawing.Color.White;
            this.reaperButton1.Location = new System.Drawing.Point(29, 77);
            this.reaperButton1.Name = "reaperButton1";
            this.reaperButton1.OverrideBackColor = true;
            this.reaperButton1.OverrideHoverColor = false;
            this.reaperButton1.Size = new System.Drawing.Size(356, 32);
            this.reaperButton1.TabIndex = 5;
            this.reaperButton1.Text = "Connect";
            this.reaperButton1.Theme = ReaperTheme.ReaperEnums.ReaperTheme.Dark;
            this.reaperButton1.UseVisualStyleBackColor = false;
            this.reaperButton1.Click += new System.EventHandler(this.reaperButton1_Click);
            // 
            // reaperButton2
            // 
            this.reaperButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reaperButton2.ButtonState = ReaperTheme.ReaperEnums.ReaperButtonState.Normal;
            this.reaperButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.reaperButton2.HoverColor = System.Drawing.Color.White;
            this.reaperButton2.Location = new System.Drawing.Point(29, 153);
            this.reaperButton2.Name = "reaperButton2";
            this.reaperButton2.OverrideBackColor = true;
            this.reaperButton2.OverrideHoverColor = false;
            this.reaperButton2.Size = new System.Drawing.Size(175, 32);
            this.reaperButton2.TabIndex = 7;
            this.reaperButton2.Text = "Refresh IP";
            this.reaperButton2.Theme = ReaperTheme.ReaperEnums.ReaperTheme.Dark;
            this.reaperButton2.UseVisualStyleBackColor = false;
            this.reaperButton2.Click += new System.EventHandler(this.reaperButton2_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.UpdateBtn.ButtonState = ReaperTheme.ReaperEnums.ReaperButtonState.Normal;
            this.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.UpdateBtn.HoverColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(210, 153);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.OverrideBackColor = true;
            this.UpdateBtn.OverrideHoverColor = false;
            this.UpdateBtn.Size = new System.Drawing.Size(175, 32);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Check for Update";
            this.UpdateBtn.Theme = ReaperTheme.ReaperEnums.ReaperTheme.Dark;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // reaperButton3
            // 
            this.reaperButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reaperButton3.ButtonState = ReaperTheme.ReaperEnums.ReaperButtonState.Normal;
            this.reaperButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.reaperButton3.HoverColor = System.Drawing.Color.White;
            this.reaperButton3.Location = new System.Drawing.Point(29, 115);
            this.reaperButton3.Name = "reaperButton3";
            this.reaperButton3.OverrideBackColor = true;
            this.reaperButton3.OverrideHoverColor = false;
            this.reaperButton3.Size = new System.Drawing.Size(356, 32);
            this.reaperButton3.TabIndex = 9;
            this.reaperButton3.Text = "Disconnect";
            this.reaperButton3.Theme = ReaperTheme.ReaperEnums.ReaperTheme.Dark;
            this.reaperButton3.UseVisualStyleBackColor = false;
            this.reaperButton3.Click += new System.EventHandler(this.reaperButton3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(371, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "i";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(414, 233);
            this.ColorBarColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reaperButton3);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.reaperButton2);
            this.Controls.Add(this.reaperButton1);
            this.Controls.Add(this.viewPublicIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 26, 2, 2);
            this.Text = "SaturnProxy";
            this.onColorBarColorChanged += new System.EventHandler<ReaperTheme.ReaperEvents.OnColorBarColorChanged>(this.Form1_onColorBarColorChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label viewPublicIP;
        private ReaperTheme.Controls.ReaperButton reaperButton1;
        private ReaperTheme.Controls.ReaperButton reaperButton2;
        private ReaperTheme.Controls.ReaperButton UpdateBtn;
        private ReaperTheme.Controls.ReaperButton reaperButton3;
        private System.Windows.Forms.Label label2;
    }
}

