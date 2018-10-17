using System;
using System.Drawing;

namespace WindowsFormsApplication1.ui.buttons
{
	public class MarkedToggleButton: ToggleButton
	{
		public MarkedToggleButton(){
			up = new Bitmap(WindowsFormsApplication1.Properties.Resources.marked_empty);
			down = new Bitmap(WindowsFormsApplication1.Properties.Resources.marked_full);
		}
	}
}
