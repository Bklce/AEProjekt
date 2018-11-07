namespace Seriendatenbank
{
    partial class MainWindow
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
            this.pnl_root = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_root
            // 
            this.pnl_root.Location = new System.Drawing.Point(0, 0);
            this.pnl_root.Name = "pnl_root";
            this.pnl_root.Size = new System.Drawing.Size(951, 515);
            this.pnl_root.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 513);
            this.Controls.Add(this.pnl_root);
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.Text = "Seriendatenbank";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindowKeyDown);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnl_root;
    }
}