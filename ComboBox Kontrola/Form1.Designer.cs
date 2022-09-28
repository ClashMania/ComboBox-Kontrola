namespace ComboBox_Kontrola
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
            this.comboBoxProfil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProfil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxProfil
            // 
            this.comboBoxProfil.FormattingEnabled = true;
            this.comboBoxProfil.Items.AddRange(new object[] {
            "IT menadzement",
            "aplikativno programiranje",
            "internet programiranje",
            "informacijski sistemi"});
            this.comboBoxProfil.Location = new System.Drawing.Point(39, 43);
            this.comboBoxProfil.Name = "comboBoxProfil";
            this.comboBoxProfil.Size = new System.Drawing.Size(379, 21);
            this.comboBoxProfil.TabIndex = 0;
            this.comboBoxProfil.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            // 
            // textBoxProfil
            // 
            this.textBoxProfil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxProfil.Location = new System.Drawing.Point(39, 119);
            this.textBoxProfil.Multiline = true;
            this.textBoxProfil.Name = "textBoxProfil";
            this.textBoxProfil.ReadOnly = true;
            this.textBoxProfil.Size = new System.Drawing.Size(370, 108);
            this.textBoxProfil.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odaberite jedan od ponuđenih obrazovnih profila: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProfil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProfil;
        private System.Windows.Forms.Label label2;
    }
}

