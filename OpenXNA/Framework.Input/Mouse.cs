using System;
using OpenTK.Input;

namespace Microsoft.Xna.Framework.Input
{
	public static class Mouse
	{
		public static IntPtr WindowHandle { get; set; }
		
		public static void SetPosition ( int x, int y)
		{
		}
		
		public static MouseState GetState ()
		{
			var mouse = OpenTK.Input.Mouse.GetState(0);
			
			return new MouseState(0, 0, 0, ButtonState.Released, ButtonState.Released, ButtonState.Released, ButtonState.Released, ButtonState.Released);
			/*return new MouseState(mouse.X, mouse.Y, 0, (ButtonState) (mouse.LeftButton), 
			                      (ButtonState) (mouse.MiddleButton),
			                      (ButtonState) (mouse.RightButton),
			                      (ButtonState) (ButtonState.Released),
			                      (ButtonState) (ButtonState.Released));
			*/
		}
	}
}

