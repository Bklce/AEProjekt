/*
 * Created by SharpDevelop.
 * User: boekelmann
 * Date: 17.10.2018
 * Time: 13:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WindowsFormsApplication1.ui.usercontrols
{
	partial class UcAdmin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnl_content;
		private System.Windows.Forms.Button btn_add_series;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnl_content = new System.Windows.Forms.Panel();
			this.btn_add_series = new System.Windows.Forms.Button();
			this.pnl_content.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_content
			// 
			this.pnl_content.Controls.Add(this.btn_add_series);
			this.pnl_content.Location = new System.Drawing.Point(3, 3);
			this.pnl_content.Name = "pnl_content";
			this.pnl_content.Size = new System.Drawing.Size(945, 509);
			this.pnl_content.TabIndex = 0;
			// 
			// btn_add_series
			// 
			this.btn_add_series.Location = new System.Drawing.Point(33, 27);
			this.btn_add_series.Name = "btn_add_series";
			this.btn_add_series.Size = new System.Drawing.Size(96, 23);
			this.btn_add_series.TabIndex = 0;
			this.btn_add_series.Text = "Serie hinzufügen";
			this.btn_add_series.UseVisualStyleBackColor = true;
			this.btn_add_series.Click += new System.EventHandler(this.Btn_add_seriesClick);
			// 
			// UcAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnl_content);
			this.Name = "UcAdmin";
			this.pnl_content.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
