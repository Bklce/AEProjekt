﻿namespace Seriendatenbank.ui.userControls
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password_current = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_abbrechen
            // 
            this.btn_abbrechen.Location = new System.Drawing.Point(235, 255);
            this.btn_abbrechen.Name = "btn_abbrechen";
            this.btn_abbrechen.Size = new System.Drawing.Size(75, 23);
            this.btn_abbrechen.TabIndex = 15;
            this.btn_abbrechen.Text = "Abbrechen";
            this.btn_abbrechen.UseVisualStyleBackColor = true;
            this.btn_abbrechen.Click += new System.EventHandler(this.btn_abbrechen_Click);
            // 
            // btn_registrieren
            // 
            this.btn_registrieren.Location = new System.Drawing.Point(235, 197);
            this.btn_registrieren.Name = "btn_registrieren";
            this.btn_registrieren.Size = new System.Drawing.Size(75, 23);
            this.btn_registrieren.TabIndex = 14;
            this.btn_registrieren.Text = "Ändern";
            this.btn_registrieren.UseVisualStyleBackColor = true;
            this.btn_registrieren.Click += new System.EventHandler(this.btn_registrieren_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Passwort neu wiederholen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Passwort neu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Benutzername";
            // 
            // txt_password_new2
            // 
            this.txt_password_new2.Location = new System.Drawing.Point(235, 171);
            this.txt_password_new2.Name = "txt_password_new2";
            this.txt_password_new2.PasswordChar = '*';
            this.txt_password_new2.Size = new System.Drawing.Size(100, 20);
            this.txt_password_new2.TabIndex = 10;
            // 
            // txt_password_new
            // 
            this.txt_password_new.Location = new System.Drawing.Point(235, 132);
            this.txt_password_new.Name = "txt_password_new";
            this.txt_password_new.PasswordChar = '*';
            this.txt_password_new.Size = new System.Drawing.Size(100, 20);
            this.txt_password_new.TabIndex = 9;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(128, 65);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Passwort aktuell";
            // 
            // txt_password_current
            // 
            this.txt_password_current.Location = new System.Drawing.Point(235, 65);
            this.txt_password_current.Name = "txt_password_current";
            this.txt_password_current.PasswordChar = '*';
            this.txt_password_current.Size = new System.Drawing.Size(100, 20);
            this.txt_password_current.TabIndex = 16;
            // 
            // UcForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_password_current);
            this.Controls.Add(this.btn_abbrechen);
            this.Controls.Add(this.btn_registrieren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password_new2);
            this.Controls.Add(this.txt_password_new);
            this.Controls.Add(this.txt_username);
            this.Name = "UcForgotPassword";
            this.Size = new System.Drawing.Size(600, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password_current;
    }
}