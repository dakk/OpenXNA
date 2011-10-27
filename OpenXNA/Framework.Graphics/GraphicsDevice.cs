using Microsoft.Xna.Framework.Graphics;
using System;

namespace Microsoft.Xna.Framework
{
	/* Performs primitive-based rendering, creates resources, handles system-level 
	 * variables, adjusts gamma ramp levels, and creates shaders */
	public class GraphicsDevice : IDisposable
	{
		public IntPtr Screen { get; set; }
		
		public GraphicsDevice (	GraphicsAdapter adapter,
         						GraphicsProfile graphicsProfile,
         						PresentationParameters presentationParameters)
		{
			
			Resize(800, 600);
		}
		
		
		public void Resize ( int x, int y )
		{		
		    
		}
		
		public void Dispose ()
		{
			
		}
		
		public void Clear(Color c)
		{
		}
	}
}

