namespace Seriendatenbank.ui.userControls
{
    partial class UcLogin
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.txt_password = new System.Windows.Forms.TextBox();
        	this.txt_username = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.btn_login = new System.Windows.Forms.Button();
        	this.btn_forgot_password = new System.Windows.Forms.Button();
        	this.btn_register = new System.Windows.Forms.Button();
        	this.pnl_content = new System.Windows.Forms.Panel();
        	this.pnl_content.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(98, 10);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(75, 13);
        	this.label1.TabIndex = 7;
        	this.label1.Text = "Benutzername";
        	// 
        	// txt_password
        	// 
        	this.txt_password.Location = new System.Drawing.Point(98, 69);
        	this.txt_password.Name = "txt_password";
        	this.txt_password.PasswordChar = '*';
        	this.txt_password.Size = new System.Drawing.Size(100, 20);
        	this.txt_password.TabIndex = 1;
        	// 
        	// txt_username
        	// 
        	this.txt_username.Location = new System.Drawing.Point(98, 26);
        	this.txt_username.Name = "txt_username";
        	this.txt_username.Size = new System.Drawing.Size(100, 20);
        	this.txt_username.TabIndex = 0;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(98, 53);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(50, 13);
        	this.label2.TabIndex = 8;
        	this.label2.Text = "Passwort";
        	// 
        	// btn_login
        	// 
        	this.btn_login.Location = new System.Drawing.Point(98, 95);
        	this.btn_login.Name = "btn_login";
        	this.btn_login.Size = new System.Drawing.Size(75, 23);
        	this.btn_login.TabIndex = 2;
        	this.btn_login.Text = "Anmelden";
        	this.btn_login.UseVisualStyleBackColor = true;
        	this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
        	// 
        	// btn_forgot_password
        	// 
        	this.btn_forgot_password.Location = new System.Drawing.Point(5, 145);
        	this.btn_forgot_password.Name = "btn_forgot_password";
        	this.btn_forgot_password.Size = new System.Drawing.Size(143, 23);
        	this.btn_forgot_password.TabIndex = 3;
        	this.btn_forgot_password.Text = "Passwort vergessen ,,,";
        	this.btn_forgot_password.UseVisualStyleBackColor = true;
        	this.btn_forgot_password.Click += new System.EventHandler(this.btn_forgot_password_Click);
        	// 
        	// btn_register
        	// 
        	this.btn_register.Location = new System.Drawing.Point(154, 145);
        	this.btn_register.Name = "btn_register";
        	this.btn_register.Size = new System.Drawing.Size(143, 23);
        	this.btn_register.TabIndex = 4;
        	this.btn_register.Text = "Registrieren";
        	this.btn_register.UseVisualStyleBackColor = true;
        	this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
        	// 
        	// pnl_content
        	// 
        	this.pnl_content.Controls.Add(this.label1);
        	this.pnl_content.Controls.Add(this.btn_register);
        	this.pnl_content.Controls.Add(this.btn_login);
        	this.pnl_content.Controls.Add(this.btn_forgot_password);
        	this.pnl_content.Controls.Add(this.label2);
        	this.pnl_content.Controls.Add(this.txt_username);
        	this.pnl_content.Controls.Add(this.txt_password);
        	this.pnl_content.Location = new System.Drawing.Point(317, 124);
        	this.pnl_content.Name = "pnl_content";
        	this.pnl_content.Size = new System.Drawing.Size(301, 176);
        	this.pnl_content.TabIndex = 9;
        	// 
        	// UcLogin
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.Controls.Add(this.pnl_content);
        	this.Name = "UcLogin";
        	this.pnl_content.ResumeLayout(false);
        	this.pnl_content.PerformLayout();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_forgot_password;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Panel pnl_content;
    }
}
