using System;
using OpenTK;
using Microsoft.Xna.Framework;

namespace Microsoft.Xna.Framework
{
	/* Support class for handle OpenTk windows */
	class GameWindowOpenTkHandler : OpenTK.GameWindow
	{
		public GameWindowOpenTkHandler() :
			base(800, 600, OpenTK.Graphics.GraphicsMode.Default, "")
		{
			
		}
	}
	
	
	/* GameWindow implementation for OpenTk */
	public class GameWindowOpenTk : GameWindow
	{
		private OpenTK.GameWindow m_Window;
	
		
		public override string Title
		{
        	get
        	{
        	    return m_Window.Title;
        	}
        	set
        	{
        	    m_Window.Title = value;
	    	}
    	}	
		
		public override bool AllowUserResizing { get; set; }
		
		public override string ScreenDeviceName 
							{ get { return ScreenDeviceName; } }
		public override IntPtr Handle 
							{ get { return Handle; } }
		public override DisplayOrientation CurrentOrientation 
							{ get { return CurrentOrientation; } }
		public override Rectangle ClientBounds 
							{ get{ return ClientBounds; } }
		
		public GameWindowOpenTk ()
		{
			m_Window = new GameWindowOpenTkHandler();
			
			Title = "Untitled";
		}
		
		public override void EndScreenDeviceChange ( string screenDeviceName,
         											 int clientWidth,
											         int clientHeight)
		{
		}
		

		
		public override void BeginScreenDeviceChange ( bool willBeFullScreen )
		{
		}
	}
}

