namespace WindowsFormsApplication1.ui.usercontrols
{
    partial class UcAddSeries
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
        	this.opd_file_picker = new System.Windows.Forms.OpenFileDialog();
        	this.button1 = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.lbl_description = new System.Windows.Forms.Label();
        	this.cmb_genre = new System.Windows.Forms.ComboBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.txt_description = new System.Windows.Forms.RichTextBox();
        	this.txt_series_name = new System.Windows.Forms.TextBox();
        	this.txt_count_seasons = new System.Windows.Forms.TextBox();
        	this.btn_accept = new System.Windows.Forms.Button();
        	this.txt_filename = new System.Windows.Forms.TextBox();
        	this.btn_cancel = new System.Windows.Forms.Button();
        	this.pnl_content = new System.Windows.Forms.Panel();
        	this.pnl_content.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// opd_file_picker
        	// 
        	this.opd_file_picker.FileName = "openFileDialog1";
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(4, 242);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(91, 21);
        	this.button1.TabIndex = 0;
        	this.button1.Text = "Bild auswählen ...";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(23, 9);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(63, 13);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Serienname";
        	// 
        	// lbl_description
        	// 
        	this.lbl_description.AutoSize = true;
        	this.lbl_description.Location = new System.Drawing.Point(23, 32);
        	this.lbl_description.Name = "lbl_description";
        	this.lbl_description.Size = new System.Drawing.Size(72, 13);
        	this.lbl_description.TabIndex = 2;
        	this.lbl_description.Text = "Beschreibung";
        	// 
        	// cmb_genre
        	// 
        	this.cmb_genre.FormattingEnabled = true;
        	this.cmb_genre.Location = new System.Drawing.Point(101, 185);
        	this.cmb_genre.Name = "cmb_genre";
        	this.cmb_genre.Size = new System.Drawing.Size(121, 21);
        	this.cmb_genre.TabIndex = 3;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(14, 188);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(36, 13);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "Genre";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(14, 215);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(68, 13);
        	this.label3.TabIndex = 5;
        	this.label3.Text = "Staffelanzahl";
        	// 
        	// txt_description
        	// 
        	this.txt_description.Location = new System.Drawing.Point(101, 32);
        	this.txt_description.Name = "txt_description";
        	this.txt_description.Size = new System.Drawing.Size(231, 147);
        	this.txt_description.TabIndex = 6;
        	this.txt_description.Text = "";
        	// 
        	// txt_series_name
        	// 
        	this.txt_series_name.Location = new System.Drawing.Point(101, 9);
        	this.txt_series_name.Name = "txt_series_name";
        	this.txt_series_name.Size = new System.Drawing.Size(231, 20);
        	this.txt_series_name.TabIndex = 7;
        	// 
        	// txt_count_seasons
        	// 
        	this.txt_count_seasons.Location = new System.Drawing.Point(101, 215);
        	this.txt_count_seasons.Name = "txt_count_seasons";
        	this.txt_count_seasons.Size = new System.Drawing.Size(121, 20);
        	this.txt_count_seasons.TabIndex = 8;
        	// 
        	// btn_accept
        	// 
        	this.btn_accept.Location = new System.Drawing.Point(214, 269);
        	this.btn_accept.Name = "btn_accept";
        	this.btn_accept.Size = new System.Drawing.Size(118, 23);
        	this.btn_accept.TabIndex = 10;
        	this.btn_accept.Text = "Hinzufügen";
        	this.btn_accept.UseVisualStyleBackColor = true;
        	this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
        	// 
        	// txt_filename
        	// 
        	this.txt_filename.Location = new System.Drawing.Point(101, 243);
        	this.txt_filename.Name = "txt_filename";
        	this.txt_filename.ReadOnly = true;
        	this.txt_filename.Size = new System.Drawing.Size(231, 20);
        	this.txt_filename.TabIndex = 11;
        	// 
        	// btn_cancel
        	// 
        	this.btn_cancel.Location = new System.Drawing.Point(4, 269);
        	this.btn_cancel.Name = "btn_cancel";
        	this.btn_cancel.Size = new System.Drawing.Size(118, 23);
        	this.btn_cancel.TabIndex = 12;
        	this.btn_cancel.Text = "Abbrechen";
        	this.btn_cancel.UseVisualStyleBackColor = true;
        	this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
        	// 
        	// pnl_content
        	// 
        	this.pnl_content.Controls.Add(this.txt_description);
        	this.pnl_content.Controls.Add(this.btn_cancel);
        	this.pnl_content.Controls.Add(this.button1);
        	this.pnl_content.Controls.Add(this.txt_filename);
        	this.pnl_content.Controls.Add(this.label1);
        	this.pnl_content.Controls.Add(this.btn_accept);
        	this.pnl_content.Controls.Add(this.lbl_description);
        	this.pnl_content.Controls.Add(this.txt_count_seasons);
        	this.pnl_content.Controls.Add(this.cmb_genre);
        	this.pnl_content.Controls.Add(this.txt_series_name);
        	this.pnl_content.Controls.Add(this.label2);
        	this.pnl_content.Controls.Add(this.label3);
        	this.pnl_content.Location = new System.Drawing.Point(306, 96);
        	this.pnl_content.Name = "pnl_content";
        	this.pnl_content.Size = new System.Drawing.Size(339, 297);
        	this.pnl_content.TabIndex = 13;
        	// 
        	// UcAddSeries
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.Controls.Add(this.pnl_content);
        	this.Name = "UcAddSeries";
        	this.pnl_content.ResumeLayout(false);
        	this.pnl_content.PerformLayout();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opd_file_picker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.ComboBox cmb_genre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.TextBox txt_series_name;
        private System.Windows.Forms.TextBox txt_count_seasons;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel pnl_content;
    }
}
