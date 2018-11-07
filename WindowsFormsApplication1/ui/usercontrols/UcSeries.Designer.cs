namespace WindowsFormsApplication1.ui.usercontrols
{
    partial class UcSeries
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
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_seen = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_marked = new System.Windows.Forms.Button();
            this.btn_favorites = new System.Windows.Forms.Button();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.btn_filter = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_filter = new System.Windows.Forms.Panel();
            this.rb_favorite = new System.Windows.Forms.RadioButton();
            this.rb_vermerkt = new System.Windows.Forms.RadioButton();
            this.rb_gesehen = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_content.SuspendLayout();
            this.pnl_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPanel
            // 
            this.tlPanel.AutoScroll = true;
            this.tlPanel.AutoSize = true;
            this.tlPanel.ColumnCount = 3;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanel.Location = new System.Drawing.Point(6, 6);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 1;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPanel.Size = new System.Drawing.Size(749, 235);
            this.tlPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tlPanel);
            this.panel1.Location = new System.Drawing.Point(39, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 435);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_filter);
            this.panel2.Controls.Add(this.btn_filter);
            this.panel2.Controls.Add(this.btn_seen);
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.btn_marked);
            this.panel2.Controls.Add(this.btn_favorites);
            this.panel2.Location = new System.Drawing.Point(39, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 40);
            this.panel2.TabIndex = 3;
            // 
            // btn_seen
            // 
            this.btn_seen.Location = new System.Drawing.Point(324, 11);
            this.btn_seen.Name = "btn_seen";
            this.btn_seen.Size = new System.Drawing.Size(75, 23);
            this.btn_seen.TabIndex = 3;
            this.btn_seen.Text = "Gesehen";
            this.btn_seen.UseVisualStyleBackColor = true;
            this.btn_seen.Click += new System.EventHandler(this.Btn_seenClick);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(8, 11);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.Btn_homeClick);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(671, 11);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Ausloggen";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logoutClick);
            // 
            // btn_marked
            // 
            this.btn_marked.Location = new System.Drawing.Point(232, 11);
            this.btn_marked.Name = "btn_marked";
            this.btn_marked.Size = new System.Drawing.Size(75, 23);
            this.btn_marked.TabIndex = 2;
            this.btn_marked.Text = "Vermerkt";
            this.btn_marked.UseVisualStyleBackColor = true;
            this.btn_marked.Click += new System.EventHandler(this.Btn_markedClick);
            // 
            // btn_favorites
            // 
            this.btn_favorites.Location = new System.Drawing.Point(141, 11);
            this.btn_favorites.Name = "btn_favorites";
            this.btn_favorites.Size = new System.Drawing.Size(75, 23);
            this.btn_favorites.TabIndex = 1;
            this.btn_favorites.Text = "Favoriten";
            this.btn_favorites.UseVisualStyleBackColor = true;
            this.btn_favorites.Click += new System.EventHandler(this.Btn_favoritesClick);
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.panel2);
            this.pnl_content.Controls.Add(this.panel1);
            this.pnl_content.Location = new System.Drawing.Point(51, 3);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(842, 512);
            this.pnl_content.TabIndex = 4;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(511, 11);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 5;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 90);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pnl_filter
            // 
            this.pnl_filter.Controls.Add(this.rb_favorite);
            this.pnl_filter.Controls.Add(this.flowLayoutPanel1);
            this.pnl_filter.Controls.Add(this.rb_vermerkt);
            this.pnl_filter.Controls.Add(this.rb_gesehen);
            this.pnl_filter.Location = new System.Drawing.Point(495, 11);
            this.pnl_filter.Name = "pnl_filter";
            this.pnl_filter.Size = new System.Drawing.Size(10, 13);
            this.pnl_filter.TabIndex = 0;
            this.pnl_filter.Visible = false;
            // 
            // rb_favorite
            // 
            this.rb_favorite.AutoSize = true;
            this.rb_favorite.Location = new System.Drawing.Point(3, 3);
            this.rb_favorite.Name = "rb_favorite";
            this.rb_favorite.Size = new System.Drawing.Size(69, 17);
            this.rb_favorite.TabIndex = 3;
            this.rb_favorite.TabStop = true;
            this.rb_favorite.Text = "Favoriten";
            this.rb_favorite.UseVisualStyleBackColor = true;
            // 
            // rb_vermerkt
            // 
            this.rb_vermerkt.AutoSize = true;
            this.rb_vermerkt.Location = new System.Drawing.Point(78, 3);
            this.rb_vermerkt.Name = "rb_vermerkt";
            this.rb_vermerkt.Size = new System.Drawing.Size(67, 17);
            this.rb_vermerkt.TabIndex = 4;
            this.rb_vermerkt.TabStop = true;
            this.rb_vermerkt.Text = "Vermerkt";
            this.rb_vermerkt.UseVisualStyleBackColor = true;
            // 
            // rb_gesehen
            // 
            this.rb_gesehen.AutoSize = true;
            this.rb_gesehen.Location = new System.Drawing.Point(153, 3);
            this.rb_gesehen.Name = "rb_gesehen";
            this.rb_gesehen.Size = new System.Drawing.Size(68, 17);
            this.rb_gesehen.TabIndex = 5;
            this.rb_gesehen.TabStop = true;
            this.rb_gesehen.Text = "Gesehen";
            this.rb_gesehen.UseVisualStyleBackColor = true;
            // 
            // UcSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_content);
            this.Name = "UcSeries";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnl_content.ResumeLayout(false);
            this.pnl_filter.ResumeLayout(false);
            this.pnl_filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_marked;
        private System.Windows.Forms.Button btn_favorites;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_seen;
        private System.Windows.Forms.Panel pnl_filter;
        private System.Windows.Forms.RadioButton rb_favorite;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rb_vermerkt;
        private System.Windows.Forms.RadioButton rb_gesehen;
        private System.Windows.Forms.Button btn_filter;
    }
}
