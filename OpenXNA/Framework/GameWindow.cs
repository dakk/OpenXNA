using System;

namespace Microsoft.Xna.Framework
{
	public abstract class GameWindow
	{
		public abstract bool AllowUserResizing { get; set; }
		
		public abstract string Title { get; set; }
		public abstract string ScreenDeviceName { get; }
		public abstract IntPtr Handle { get; }

		public abstract DisplayOrientation CurrentOrientation { get; }
		public abstract Rectangle ClientBounds { get; }
		
		public GameWindow ()
		{
		}
		
		public abstract void EndScreenDeviceChange ( string screenDeviceName,
         											 int clientWidth,
											         int clientHeight);
		
		public void EndScreenDeviceChange ( string screenDeviceName )
		{
		}
		
		public abstract void BeginScreenDeviceChange ( bool willBeFullScreen );
	}

}


