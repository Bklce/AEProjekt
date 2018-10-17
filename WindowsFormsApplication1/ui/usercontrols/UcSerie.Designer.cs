namespace WindowsFormsApplication1.ui.usercontrols
{
    partial class UcSerie
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Button btn_change_rating;
        private System.Windows.Forms.TextBox txt_rating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.PictureBox pb_series_picture;
        private System.Windows.Forms.Label lbl_series_name;
        private System.Windows.Forms.Button btn_back;
        private WindowsFormsApplication1.ui.buttons.SeenToggleButton tb_seen;
        private WindowsFormsApplication1.ui.buttons.MarkedToggleButton tb_marked;
        private WindowsFormsApplication1.ui.buttons.FavoriteToggleButton tb_favorite;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code
        private void InitializeComponent()
        {
        	this.pnl_content = new System.Windows.Forms.Panel();
        	this.tb_seen = new WindowsFormsApplication1.ui.buttons.SeenToggleButton();
        	this.tb_marked = new WindowsFormsApplication1.ui.buttons.MarkedToggleButton();
        	this.tb_favorite = new WindowsFormsApplication1.ui.buttons.FavoriteToggleButton();
        	this.btn_back = new System.Windows.Forms.Button();
        	this.btn_change_rating = new System.Windows.Forms.Button();
        	this.txt_rating = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.lbl_description = new System.Windows.Forms.Label();
        	this.pb_series_picture = new System.Windows.Forms.PictureBox();
        	this.lbl_series_name = new System.Windows.Forms.Label();
        	this.pnl_content.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tb_seen)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.tb_marked)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.tb_favorite)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pb_series_picture)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// pnl_content
        	// 
        	this.pnl_content.Controls.Add(this.tb_seen);
        	this.pnl_content.Controls.Add(this.tb_marked);
        	this.pnl_content.Controls.Add(this.tb_favorite);
        	this.pnl_content.Controls.Add(this.btn_back);
        	this.pnl_content.Controls.Add(this.btn_change_rating);
        	this.pnl_content.Controls.Add(this.txt_rating);
        	this.pnl_content.Controls.Add(this.label1);
        	this.pnl_content.Controls.Add(this.lbl_description);
        	this.pnl_content.Controls.Add(this.pb_series_picture);
        	this.pnl_content.Controls.Add(this.lbl_series_name);
        	this.pnl_content.Location = new System.Drawing.Point(247, 58);
        	this.pnl_content.Name = "pnl_content";
        	this.pnl_content.Size = new System.Drawing.Size(467, 378);
        	this.pnl_content.TabIndex = 0;
        	// 
        	// tb_seen
        	// 
        	this.tb_seen.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.tb_seen.Location = new System.Drawing.Point(402, 281);
        	this.tb_seen.Name = "tb_seen";
        	this.tb_seen.Size = new System.Drawing.Size(50, 50);
        	this.tb_seen.TabIndex = 9;
        	this.tb_seen.TabStop = false;
        	this.tb_seen.Click += new System.EventHandler(this.Tb_seenClick);
        	// 
        	// tb_marked
        	// 
        	this.tb_marked.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.tb_marked.Location = new System.Drawing.Point(336, 281);
        	this.tb_marked.Name = "tb_marked";
        	this.tb_marked.Size = new System.Drawing.Size(50, 50);
        	this.tb_marked.TabIndex = 8;
        	this.tb_marked.TabStop = false;
        	this.tb_marked.Click += new System.EventHandler(this.Tb_markedClick);
        	// 
        	// tb_favorite
        	// 
        	this.tb_favorite.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.tb_favorite.Location = new System.Drawing.Point(272, 281);
        	this.tb_favorite.Name = "tb_favorite";
        	this.tb_favorite.Size = new System.Drawing.Size(50, 50);
        	this.tb_favorite.TabIndex = 7;
        	this.tb_favorite.TabStop = false;
        	this.tb_favorite.Click += new System.EventHandler(this.Tb_favoriteClick);
        	// 
        	// btn_back
        	// 
        	this.btn_back.Location = new System.Drawing.Point(3, 342);
        	this.btn_back.Name = "btn_back";
        	this.btn_back.Size = new System.Drawing.Size(75, 23);
        	this.btn_back.TabIndex = 0;
        	this.btn_back.Text = "Zurück";
        	this.btn_back.UseVisualStyleBackColor = true;
        	this.btn_back.Click += new System.EventHandler(this.Btn_backClick);
        	// 
        	// btn_change_rating
        	// 
        	this.btn_change_rating.Location = new System.Drawing.Point(175, 339);
        	this.btn_change_rating.Name = "btn_change_rating";
        	this.btn_change_rating.Size = new System.Drawing.Size(75, 23);
        	this.btn_change_rating.TabIndex = 1;
        	this.btn_change_rating.Text = "Ändern";
        	this.btn_change_rating.UseVisualStyleBackColor = true;
        	this.btn_change_rating.Click += new System.EventHandler(this.Btn_change_ratingClick);
        	// 
        	// txt_rating
        	// 
        	this.txt_rating.Location = new System.Drawing.Point(175, 281);
        	this.txt_rating.Name = "txt_rating";
        	this.txt_rating.Size = new System.Drawing.Size(44, 20);
        	this.txt_rating.TabIndex = 2;
        	this.txt_rating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(225, 284);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(58, 19);
        	this.label1.TabIndex = 3;
        	this.label1.Text = " /100";
        	// 
        	// lbl_description
        	// 
        	this.lbl_description.Location = new System.Drawing.Point(177, 35);
        	this.lbl_description.Name = "lbl_description";
        	this.lbl_description.Size = new System.Drawing.Size(275, 243);
        	this.lbl_description.TabIndex = 2;
        	this.lbl_description.Text = "description";
        	// 
        	// pb_series_picture
        	// 
        	this.pb_series_picture.Location = new System.Drawing.Point(0, 35);
        	this.pb_series_picture.Name = "pb_series_picture";
        	this.pb_series_picture.Size = new System.Drawing.Size(171, 174);
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
        	// UcSerie
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.Controls.Add(this.pnl_content);
        	this.Name = "UcSerie";
        	this.pnl_content.ResumeLayout(false);
        	this.pnl_content.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tb_seen)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.tb_marked)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.tb_favorite)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pb_series_picture)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion
    }
}
