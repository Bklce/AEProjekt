namespace WindowsFormsApplication1.ui.usercontrols
{
    partial class UcSerie
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Button btn_change_rating;
        private System.Windows.Forms.TextBox txt_rating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.PictureBox pb_series_picture;
        private System.Windows.Forms.Label lbl_series_name;
        private System.Windows.Forms.Button btn_back;

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
        	this.pnl_content = new System.Windows.Forms.Panel();
        	this.btn_change_rating = new System.Windows.Forms.Button();
        	this.txt_rating = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.lbl_description = new System.Windows.Forms.Label();
        	this.pb_series_picture = new System.Windows.Forms.PictureBox();
        	this.lbl_series_name = new System.Windows.Forms.Label();
        	this.btn_back = new System.Windows.Forms.Button();
        	this.pnl_content.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pb_series_picture)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// pnl_content
        	// 
        	this.pnl_content.Controls.Add(this.btn_back);
        	this.pnl_content.Controls.Add(this.btn_change_rating);
        	this.pnl_content.Controls.Add(this.txt_rating);
        	this.pnl_content.Controls.Add(this.label1);
        	this.pnl_content.Controls.Add(this.lbl_description);
        	this.pnl_content.Controls.Add(this.pb_series_picture);
        	this.pnl_content.Controls.Add(this.lbl_series_name);
        	this.pnl_content.Location = new System.Drawing.Point(121, 37);
        	this.pnl_content.Name = "pnl_content";
        	this.pnl_content.Size = new System.Drawing.Size(539, 378);
        	this.pnl_content.TabIndex = 0;
        	// 
        	// btn_change_rating
        	// 
        	this.btn_change_rating.Location = new System.Drawing.Point(154, 284);
        	this.btn_change_rating.Name = "btn_change_rating";
        	this.btn_change_rating.Size = new System.Drawing.Size(75, 23);
        	this.btn_change_rating.TabIndex = 5;
        	this.btn_change_rating.Text = "Ändern";
        	this.btn_change_rating.UseVisualStyleBackColor = true;
        	this.btn_change_rating.Click += new System.EventHandler(this.Btn_change_ratingClick);
        	// 
        	// txt_rating
        	// 
        	this.txt_rating.Location = new System.Drawing.Point(52, 287);
        	this.txt_rating.Name = "txt_rating";
        	this.txt_rating.Size = new System.Drawing.Size(44, 20);
        	this.txt_rating.TabIndex = 4;
        	this.txt_rating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(102, 290);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(58, 19);
        	this.label1.TabIndex = 3;
        	this.label1.Text = " /100";
        	// 
        	// lbl_description
        	// 
        	this.lbl_description.Location = new System.Drawing.Point(246, 35);
        	this.lbl_description.Name = "lbl_description";
        	this.lbl_description.Size = new System.Drawing.Size(209, 243);
        	this.lbl_description.TabIndex = 2;
        	this.lbl_description.Text = "description";
        	// 
        	// pb_series_picture
        	// 
        	this.pb_series_picture.Location = new System.Drawing.Point(0, 35);
        	this.pb_series_picture.Name = "pb_series_picture";
        	this.pb_series_picture.Size = new System.Drawing.Size(240, 243);
        	this.pb_series_picture.TabIndex = 1;
        	this.pb_series_picture.TabStop = false;
        	// 
        	// lbl_series_name
        	// 
        	this.lbl_series_name.Location = new System.Drawing.Point(3, 9);
        	this.lbl_series_name.Name = "lbl_series_name";
        	this.lbl_series_name.Size = new System.Drawing.Size(237, 23);
        	this.lbl_series_name.TabIndex = 0;
        	this.lbl_series_name.Text = "seriesname";
        	// 
        	// btn_back
        	// 
        	this.btn_back.Location = new System.Drawing.Point(3, 342);
        	this.btn_back.Name = "btn_back";
        	this.btn_back.Size = new System.Drawing.Size(75, 23);
        	this.btn_back.TabIndex = 6;
        	this.btn_back.Text = "Zurück";
        	this.btn_back.UseVisualStyleBackColor = true;
        	this.btn_back.Click += new System.EventHandler(this.Btn_backClick);
        	// 
        	// UcSerie
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.Controls.Add(this.pnl_content);
        	this.Name = "UcSerie";
        	this.pnl_content.ResumeLayout(false);
        	this.pnl_content.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pb_series_picture)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion
    }
}
