namespace WindowsFormsApplication1.ui
{
    partial class SeriesElement
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
            this.pb_series_picture = new System.Windows.Forms.PictureBox();
            this.lbl_series_name = new System.Windows.Forms.Label();
            this.lbl_points = new System.Windows.Forms.Label();
            this.lbl_points_from = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_series_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_series_picture
            // 
            this.pb_series_picture.Location = new System.Drawing.Point(38, 0);
            this.pb_series_picture.Name = "pb_series_picture";
            this.pb_series_picture.Size = new System.Drawing.Size(171, 176);
            this.pb_series_picture.TabIndex = 1;
            this.pb_series_picture.TabStop = false;
            // 
            // lbl_series_name
            // 
            this.lbl_series_name.Location = new System.Drawing.Point(38, 179);
            this.lbl_series_name.Name = "lbl_series_name";
            this.lbl_series_name.Size = new System.Drawing.Size(171, 40);
            this.lbl_series_name.TabIndex = 2;
            this.lbl_series_name.Text = "a";
            // 
            // lbl_points
            // 
            this.lbl_points.AutoSize = true;
            this.lbl_points.Location = new System.Drawing.Point(79, 219);
            this.lbl_points.Name = "lbl_points";
            this.lbl_points.Size = new System.Drawing.Size(35, 13);
            this.lbl_points.TabIndex = 3;
            this.lbl_points.Text = "points";
            this.lbl_points.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_points_from
            // 
            this.lbl_points_from.AutoSize = true;
            this.lbl_points_from.Location = new System.Drawing.Point(120, 219);
            this.lbl_points_from.Name = "lbl_points_from";
            this.lbl_points_from.Size = new System.Drawing.Size(33, 13);
            this.lbl_points_from.TabIndex = 4;
            this.lbl_points_from.Text = "/ 100";
            // 
            // SeriesElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_points_from);
            this.Controls.Add(this.lbl_points);
            this.Controls.Add(this.lbl_series_name);
            this.Controls.Add(this.pb_series_picture);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "SeriesElement";
            this.Size = new System.Drawing.Size(240, 243);
            ((System.ComponentModel.ISupportInitialize)(this.pb_series_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_series_picture;
        private System.Windows.Forms.Label lbl_series_name;
        private System.Windows.Forms.Label lbl_points;
        private System.Windows.Forms.Label lbl_points_from;
    }
}
