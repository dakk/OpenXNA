using System;

using Microsoft.Xna.Framework;

namespace Microsoft.Xna.Framework.Input
{
	public static class Keyboard
	{	
		public static KeyboardState GetState ( PlayerIndex playerIndex )
		{
			return new KeyboardState(new Keys());
		}
		
		public static KeyboardState GetState ()
		{
			KeyboardState state = new KeyboardState(new Keys()); 
			
			return state;
		}
	}
}

