using System;

namespace Microsoft.Xna.Framework.Graphics
{
	public class SpriteBatch : GraphicsResource
	{
	
		public SpriteBatch ()
		{
		}

		public SpriteBatch (GraphicsDevice graphicsDevice)
		{
			GraphicsDevice = graphicsDevice;
		}
		
		/* Flushes the sprite batch and restores the device state to how it 
		 * was before Begin was called */
		public void End ()
		{

		}
		
		
		public void Draw ( Texture2D texture, 
		                   Rectangle destinationRectangle,
		                   Color color )
		{
			Rectangle d = destinationRectangle;
			
		}
		
		
		public void Draw ( Texture2D texture, 
		                   Vector2 position,
		                   Color color )
		{
			Draw(texture, 
			     new Rectangle( (int) position.X, (int) position.Y, 
			                    texture.Width, texture.Height),
			     color);
		}
		
		
		public void Begin ()
		{
		}
		
	}
}

