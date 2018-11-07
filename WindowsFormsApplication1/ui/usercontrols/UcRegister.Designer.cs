namespace Seriendatenbank.ui.userControls
{
    partial class UcRegister
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
        	this.txt_username = new System.Windows.Forms.TextBox();
        	this.txt_password = new System.Windows.Forms.TextBox();
        	this.txt_password2 = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.btn_registrieren = new System.Windows.Forms.Button();
        	this.btn_abbrechen = new System.Windows.Forms.Button();
        	this.pnl_content = new System.Windows.Forms.Panel();
        	this.btn_back = new System.Windows.Forms.Button();
        	this.pnl_content.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// txt_username
        	// 
        	this.txt_username.Location = new System.Drawing.Point(31, 27);
        	this.txt_username.Name = "txt_username";
        	this.txt_username.Size = new System.Drawing.Size(100, 20);
        	this.txt_username.TabIndex = 0;
        	// 
        	// txt_password
        	// 
        	this.txt_password.Location = new System.Drawing.Point(31, 87);
        	this.txt_password.Name = "txt_password";
        	this.txt_password.PasswordChar = '*';
        	this.txt_password.Size = new System.Drawing.Size(100, 20);
        	this.txt_password.TabIndex = 1;
        	// 
        	// txt_password2
        	// 
        	this.txt_password2.Location = new System.Drawing.Point(31, 130);
        	this.txt_password2.Name = "txt_password2";
        	this.txt_password2.PasswordChar = '*';
        	this.txt_password2.Size = new System.Drawing.Size(100, 20);
        	this.txt_password2.TabIndex = 2;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(31, 11);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(75, 13);
        	this.label1.TabIndex = 3;
        	this.label1.Text = "Benutzername";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(31, 71);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(50, 13);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "Passwort";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(31, 114);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(110, 13);
        	this.label3.TabIndex = 5;
        	this.label3.Text = "Passwort wiederholen";
        	// 
        	// btn_registrieren
        	// 
        	this.btn_registrieren.Location = new System.Drawing.Point(6, 161);
        	this.btn_registrieren.Name = "btn_registrieren";
        	this.btn_registrieren.Size = new System.Drawing.Size(75, 23);
        	this.btn_registrieren.TabIndex = 3;
        	this.btn_registrieren.Text = "Registrieren";
        	this.btn_registrieren.UseVisualStyleBackColor = true;
        	this.btn_registrieren.Click += new System.EventHandler(this.btn_registrieren_Click);
        	// 
        	// btn_abbrechen
        	// 
        	this.btn_abbrechen.Location = new System.Drawing.Point(3, 232);
        	this.btn_abbrechen.Name = "btn_abbrechen";
        	this.btn_abbrechen.Size = new System.Drawing.Size(75, 23);
        	this.btn_abbrechen.TabIndex = 4;
        	this.btn_abbrechen.Text = "Abbrechen";
        	this.btn_abbrechen.UseVisualStyleBackColor = true;
        	this.btn_abbrechen.Click += new System.EventHandler(this.btn_abbrechen_Click);
        	// 
        	// pnl_content
        	// 
        	this.pnl_content.Controls.Add(this.btn_back);
        	this.pnl_content.Controls.Add(this.label1);
        	this.pnl_content.Controls.Add(this.btn_abbrechen);
        	this.pnl_content.Controls.Add(this.txt_username);
        	this.pnl_content.Controls.Add(this.btn_registrieren);
        	this.pnl_content.Controls.Add(this.txt_password);
        	this.pnl_content.Controls.Add(this.label3);
        	this.pnl_content.Controls.Add(this.txt_password2);
        	this.pnl_content.Controls.Add(this.label2);
        	this.pnl_content.Location = new System.Drawing.Point(363, 127);
        	this.pnl_content.Name = "pnl_content";
        	this.pnl_content.Size = new System.Drawing.Size(167, 193);
        	this.pnl_content.TabIndex = 6;
        	// 
        	// btn_back
        	// 
        	this.btn_back.Location = new System.Drawing.Point(87, 161);
        	this.btn_back.Name = "btn_back";
        	this.btn_back.Size = new System.Drawing.Size(75, 23);
        	this.btn_back.TabIndex = 6;
        	this.btn_back.Text = "Zurück";
        	this.btn_back.UseVisualStyleBackColor = true;
        	this.btn_back.Click += new System.EventHandler(this.Btn_backClick);
        	// 
        	// UcRegister
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.Controls.Add(this.pnl_content);
        	this.Name = "UcRegister";
        	this.pnl_content.ResumeLayout(false);
        	this.pnl_content.PerformLayout();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_registrieren;
        private System.Windows.Forms.Button btn_abbrechen;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Button btn_back;
    }
}
