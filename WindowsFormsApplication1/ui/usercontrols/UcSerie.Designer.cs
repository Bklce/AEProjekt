namespace WindowsFormsApplication1.ui.usercontrols
{
    partial class UcSerie
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
            this.lbl_points_from = new System.Windows.Forms.Label();
            this.lbl_points = new System.Windows.Forms.Label();
            this.lbl_series_name = new System.Windows.Forms.Label();
            this.pb_series_picture = new System.Windows.Forms.PictureBox();
            this.lbl_descrription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user_rating = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_series_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_points_from
            // 
            this.lbl_points_from.AutoSize = true;
            this.lbl_points_from.Location = new System.Drawing.Point(116, 353);
            this.lbl_points_from.Name = "lbl_points_from";
            this.lbl_points_from.Size = new System.Drawing.Size(33, 13);
            this.lbl_points_from.TabIndex = 8;
            this.lbl_points_from.Text = "/ 100";
            // 
            // lbl_points
            // 
            this.lbl_points.AutoSize = true;
            this.lbl_points.Location = new System.Drawing.Point(75, 353);
            this.lbl_points.Name = "lbl_points";
            this.lbl_points.Size = new System.Drawing.Size(35, 13);
            this.lbl_points.TabIndex = 7;
            this.lbl_points.Text = "points";
            this.lbl_points.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_series_name
            // 
            this.lbl_series_name.Location = new System.Drawing.Point(75, 45);
            this.lbl_series_name.Name = "lbl_series_name";
            this.lbl_series_name.Size = new System.Drawing.Size(171, 31);
            this.lbl_series_name.TabIndex = 6;
            this.lbl_series_name.Text = "name";
            // 
            // pb_series_picture
            // 
            this.pb_series_picture.Location = new System.Drawing.Point(78, 79);
            this.pb_series_picture.Name = "pb_series_picture";
            this.pb_series_picture.Size = new System.Drawing.Size(263, 271);
            this.pb_series_picture.TabIndex = 5;
            this.pb_series_picture.TabStop = false;
            // 
            // lbl_descrription
            // 
            this.lbl_descrription.Location = new System.Drawing.Point(347, 79);
            this.lbl_descrription.Name = "lbl_descrription";
            this.lbl_descrription.Size = new System.Drawing.Size(339, 156);
            this.lbl_descrription.TabIndex = 9;
            this.lbl_descrription.Text = "description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(347, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bewerten";
            // 
            // txt_user_rating
            // 
            this.txt_user_rating.Location = new System.Drawing.Point(405, 238);
            this.txt_user_rating.Name = "txt_user_rating";
            this.txt_user_rating.Size = new System.Drawing.Size(47, 20);
            this.txt_user_rating.TabIndex = 11;
            this.txt_user_rating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "/ 100";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(673, 423);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Zurück";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // UcSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_user_rating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_descrription);
            this.Controls.Add(this.lbl_points_from);
            this.Controls.Add(this.lbl_points);
            this.Controls.Add(this.lbl_series_name);
            this.Controls.Add(this.pb_series_picture);
            this.Name = "UcSerie";
            this.Size = new System.Drawing.Size(771, 462);
            ((System.ComponentModel.ISupportInitialize)(this.pb_series_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_points_from;
        private System.Windows.Forms.Label lbl_points;
        private System.Windows.Forms.Label lbl_series_name;
        private System.Windows.Forms.PictureBox pb_series_picture;
        private System.Windows.Forms.Label lbl_descrription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_user_rating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel;
    }
}
