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
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pnl_filter = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cb_favorit = new System.Windows.Forms.CheckBox();
            this.cb_gesehen = new System.Windows.Forms.CheckBox();
            this.cb_vermerkt = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fp_genreList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_filter.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl_content.SuspendLayout();
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
            this.panel2.Controls.Add(this.btn_filter);
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Location = new System.Drawing.Point(39, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 40);
            this.panel2.TabIndex = 3;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(127, 11);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 5;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
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
            // pnl_filter
            // 
            this.pnl_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_filter.Controls.Add(this.flowLayoutPanel1);
            this.pnl_filter.Controls.Add(this.button1);
            this.pnl_filter.Controls.Add(this.fp_genreList);
            this.pnl_filter.Location = new System.Drawing.Point(12, 83);
            this.pnl_filter.Name = "pnl_filter";
            this.pnl_filter.Size = new System.Drawing.Size(375, 194);
            this.pnl_filter.TabIndex = 0;
            this.pnl_filter.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cb_favorit);
            this.flowLayoutPanel1.Controls.Add(this.cb_gesehen);
            this.flowLayoutPanel1.Controls.Add(this.cb_vermerkt);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 39);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // cb_favorit
            // 
            this.cb_favorit.AutoSize = true;
            this.cb_favorit.Location = new System.Drawing.Point(3, 3);
            this.cb_favorit.Name = "cb_favorit";
            this.cb_favorit.Size = new System.Drawing.Size(58, 17);
            this.cb_favorit.TabIndex = 2;
            this.cb_favorit.Text = "Favorit";
            this.cb_favorit.UseVisualStyleBackColor = true;
            // 
            // cb_gesehen
            // 
            this.cb_gesehen.AutoSize = true;
            this.cb_gesehen.Location = new System.Drawing.Point(67, 3);
            this.cb_gesehen.Name = "cb_gesehen";
            this.cb_gesehen.Size = new System.Drawing.Size(69, 17);
            this.cb_gesehen.TabIndex = 3;
            this.cb_gesehen.Text = "Gesehen";
            this.cb_gesehen.UseVisualStyleBackColor = true;
            // 
            // cb_vermerkt
            // 
            this.cb_vermerkt.AutoSize = true;
            this.cb_vermerkt.Location = new System.Drawing.Point(142, 3);
            this.cb_vermerkt.Name = "cb_vermerkt";
            this.cb_vermerkt.Size = new System.Drawing.Size(68, 17);
            this.cb_vermerkt.TabIndex = 4;
            this.cb_vermerkt.Text = "Vermerkt";
            this.cb_vermerkt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Filtern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fp_genreList
            // 
            this.fp_genreList.Location = new System.Drawing.Point(3, 48);
            this.fp_genreList.Name = "fp_genreList";
            this.fp_genreList.Size = new System.Drawing.Size(358, 90);
            this.fp_genreList.TabIndex = 1;
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.pnl_filter);
            this.pnl_content.Controls.Add(this.panel2);
            this.pnl_content.Controls.Add(this.panel1);
            this.pnl_content.Location = new System.Drawing.Point(51, 3);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(842, 512);
            this.pnl_content.TabIndex = 4;
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
            this.pnl_filter.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnl_content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel pnl_filter;
        private System.Windows.Forms.FlowLayoutPanel fp_genreList;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.CheckBox cb_vermerkt;
        private System.Windows.Forms.CheckBox cb_gesehen;
        private System.Windows.Forms.CheckBox cb_favorit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
