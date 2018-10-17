using System;
using System.Drawing;

namespace WindowsFormsApplication1.ui.buttons
{
	public class SeenToggleButton: ToggleButton
	{
		public SeenToggleButton(){
			up = new Bitmap(WindowsFormsApplication1.Properties.Resources.seen_empty);
			down = new Bitmap(WindowsFormsApplication1.Properties.Resources.seen_full);
		}
	}
}
