using System;
using Tao;
using OpenTK.Input;

namespace Microsoft.Xna.Framework.Input
{
	public struct KeyboardState
	{
		private OpenTK.Input.KeyboardState m_Keyboard;
		public KeyState[] KeyList;		
		public KeyState this [Keys key] { get{ return KeyList[(int) key]; } }
		
	
		public KeyboardState (params Keys[] keys)
		{
			m_Keyboard = OpenTK.Input.Keyboard.GetState();
			KeyList = new KeyState[500];
		}

		
		public bool IsKeyUp (Keys key)
		{
			return m_Keyboard.IsKeyUp((OpenTK.Input.Key) key);
			
			/*
			if(KeyList[(int) key] == KeyState.Up)
				return true;
			return false;
			*/
		}
		
		public bool IsKeyDown (Keys key)
		{
			return m_Keyboard.IsKeyDown((OpenTK.Input.Key) key);
			/*
			if(KeyList[(int) key] == KeyState.Down)
				return true;
			return false;	
			*/	
		}
		
		public Keys[] GetPressedKeys()
		{
			return new Keys[1];
			//for(KeyState k = KeyList[0]; k < KeyList.GetValue(KeyList.GetLength); k++);
			//return KeyList;
		}
		
	}
}

