using System;
using System.Drawing;

namespace WindowsFormsApplication1.ui.buttons
{
	public class FavoriteToggleButton : ToggleButton
	{
		public FavoriteToggleButton(){
			up = new Bitmap(WindowsFormsApplication1.Properties.Resources.star_empty);
			down = new Bitmap(WindowsFormsApplication1.Properties.Resources.star_full);
		}
	}
}
