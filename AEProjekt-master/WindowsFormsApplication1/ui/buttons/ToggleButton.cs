using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1.ui.buttons
{

	public class ToggleButton : PictureBox
	{
		protected Bitmap down;
		protected Bitmap up;
		
		public ToggleButton(){
			this.Width = 50;
			this.Height = 50;
			this.Cursor = System.Windows.Forms.Cursors.Hand;
		}
		
		public void SetState(bool state){
			if(state)
				this.Image = down;
			else
				this.Image = up;
				
			IsDown = state;
		}
		
		public bool IsDown
		{get; private set;}
	}
}
