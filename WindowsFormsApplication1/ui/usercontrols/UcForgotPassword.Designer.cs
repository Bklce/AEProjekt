namespace Seriendatenbank.ui.userControls
{
    partial class UcForgotPassword
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
            this.btn_abbrechen = new System.Windows.Forms.Button();
            this.btn_registrieren = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password_new2 = new System.Windows.Forms.TextBox();
            this.txt_password_new = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.pnl_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_abbrechen
            // 
            this.btn_abbrechen.Location = new System.Drawing.Point(6, 166);
            this.btn_abbrechen.Name = "btn_abbrechen";
            this.btn_abbrechen.Size = new System.Drawing.Size(75, 23);
            this.btn_abbrechen.TabIndex = 5;
            this.btn_abbrechen.Text = "Abbrechen";
            this.btn_abbrechen.UseVisualStyleBackColor = true;
            this.btn_abbrechen.Click += new System.EventHandler(this.btn_abbrechen_Click);
            // 
            // btn_registrieren
            // 
            this.btn_registrieren.Location = new System.Drawing.Point(6, 137);
            this.btn_registrieren.Name = "btn_registrieren";
            this.btn_registrieren.Size = new System.Drawing.Size(75, 23);
            this.btn_registrieren.TabIndex = 4;
            this.btn_registrieren.Text = "Ändern";
            this.btn_registrieren.UseVisualStyleBackColor = true;
            this.btn_registrieren.Click += new System.EventHandler(this.btn_registrieren_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Passwort neu wiederholen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Passwort neu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Benutzername";
            // 
            // txt_password_new2
            // 
            this.txt_password_new2.Location = new System.Drawing.Point(6, 111);
            this.txt_password_new2.Name = "txt_password_new2";
            this.txt_password_new2.PasswordChar = '*';
            this.txt_password_new2.Size = new System.Drawing.Size(100, 20);
            this.txt_password_new2.TabIndex = 3;
            // 
            // txt_password_new
            // 
            this.txt_password_new.Location = new System.Drawing.Point(6, 72);
            this.txt_password_new.Name = "txt_password_new";
            this.txt_password_new.PasswordChar = '*';
            this.txt_password_new.Size = new System.Drawing.Size(100, 20);
            this.txt_password_new.TabIndex = 2;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(6, 26);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 0;
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.label1);
            this.pnl_content.Controls.Add(this.txt_username);
            this.pnl_content.Controls.Add(this.txt_password_new);
            this.pnl_content.Controls.Add(this.btn_abbrechen);
            this.pnl_content.Controls.Add(this.txt_password_new2);
            this.pnl_content.Controls.Add(this.btn_registrieren);
            this.pnl_content.Controls.Add(this.label2);
            this.pnl_content.Controls.Add(this.label3);
            this.pnl_content.Location = new System.Drawing.Point(410, 111);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(141, 193);
            this.pnl_content.TabIndex = 18;
            // 
            // UcForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_content);
            this.Name = "UcForgotPassword";
            this.pnl_content.ResumeLayout(false);
            this.pnl_content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_abbrechen;
        private System.Windows.Forms.Button btn_registrieren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password_new2;
        private System.Windows.Forms.TextBox txt_password_new;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Panel pnl_content;
    }
}
