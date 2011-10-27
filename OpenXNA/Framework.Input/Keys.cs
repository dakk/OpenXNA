using System;
using OpenTK.Input;

namespace Microsoft.Xna.Framework.Input
{
	public enum Keys
	{
		A = OpenTK.Input.Key.A,							//	A key
		Add = OpenTK.Input.Key.KeypadAdd,							//	Add key
		Apps, 											//	Applications key
		Attn, 											//	Attn key
		B = OpenTK.Input.Key.B, 						//	B key
		Back = OpenTK.Input.Key.BackSpace, 				//	BACKSPACE key
		BrowserBack, 									//	Windows 2000/XP: Browser Back key
		BrowserFavorites, 								//	Windows 2000/XP: Browser Favorites key
		BrowserForward,									//	Windows 2000/XP: Browser Forward key
		BrowserHome,									//	Windows 2000/XP: Browser Start and Home key
		BrowserRefresh,									//	Windows 2000/XP: Browser Refresh key
		BrowserSearch,									//	Windows 2000/XP: Browser Search key
		BrowserStop,									//	Windows 2000/XP: Browser Stop key
		C = OpenTK.Input.Key.C,							//	C key
		CapsLock = OpenTK.Input.Key.CapsLock,			//	CAPS LOCK key
		ChatPadGreen,									//	Green ChatPad key
		ChatPadOrange,									//	Orange ChatPad key
		Crsel,											//	CrSel key
		D = OpenTK.Input.Key.D,							//	D key
		D0,												//	Used for miscellaneous characters; it can vary by keyboard.
		D1,												//	Used for miscellaneous characters; it can vary by keyboard.
		D2,												//	Used for miscellaneous characters; it can vary by keyboard.
		D3,												//	Used for miscellaneous characters; it can vary by keyboard.
		D4,												//	Used for miscellaneous characters; it can vary by keyboard.
		D5,												//	Used for miscellaneous characters; it can vary by keyboard.
		D6,												//	Used for miscellaneous characters; it can vary by keyboard.
		D7,												//	Used for miscellaneous characters; it can vary by keyboard.
		D8,												//	Used for miscellaneous characters; it can vary by keyboard.
		D9,												//	Used for miscellaneous characters; it can vary by keyboard.
		Decimal,										//	Decimal key
		Delete = OpenTK.Input.Key.Delete,				//	DEL key
		Divide = OpenTK.Input.Key.KeypadDivide,			//	Divide key
		Down = OpenTK.Input.Key.Down,					//	DOWN ARROW key
		E = OpenTK.Input.Key.E,							//	E key
		End = OpenTK.Input.Key.End,						//	END key
		Enter = OpenTK.Input.Key.Enter,					//	ENTER key
		EraseEof,										//	Erase EOF key
		Escape = OpenTK.Input.Key.Escape,				//	ESC key
		Execute,										//	EXECUTE key
		Exsel,											//	ExSel key
		F = OpenTK.Input.Key.F,							//	F key
		F1 = OpenTK.Input.Key.F1,						//	F1 key
		F10 = OpenTK.Input.Key.F10,						//	F10 key
		F11 = OpenTK.Input.Key.F11,						//	F11 key
		F12 = OpenTK.Input.Key.F12,						//	F12 key
		F13 = OpenTK.Input.Key.F13,						//	F13 key
		F14 = OpenTK.Input.Key.F14,						//	F14 key
		F15 = OpenTK.Input.Key.F15,						//	F15 key
		F16,											//	F16 key
		F17,											//	F17 key
		F18,											//	F18 key
		F19,											//	F19 key
		F2 = OpenTK.Input.Key.F2,						//	F2 key
		F20,											//	F20 key
		F21,											//	F21 key
		F22,											//	F22 key
		F23,											//	F23 key
		F24,											//	F24 key
		F3 = OpenTK.Input.Key.F3,						//	F3 key
		F4 = OpenTK.Input.Key.F4,						//	F4 key
		F5 = OpenTK.Input.Key.F5,						//	F5 key
		F6 = OpenTK.Input.Key.F6,						//	F6 key
		F7 = OpenTK.Input.Key.F7,						//	F7 key
		F8 = OpenTK.Input.Key.F8,						//	F8 key
		F9 = OpenTK.Input.Key.F9,						//F9 key
		G = OpenTK.Input.Key.G,							//G key
		H = OpenTK.Input.Key.H,							//H key
		Help,											//	HELP key
		Home = OpenTK.Input.Key.Home,					//	HOME key
		I = OpenTK.Input.Key.I,							//	I key
		ImeConvert,										//	IME Convert key
		ImeNoConvert,									//	IME NoConvert key
		Insert = OpenTK.Input.Key.Insert,				//	INS key
		J = OpenTK.Input.Key.J,							//	J key
		K = OpenTK.Input.Key.K,							//	K key
		Kana,											//	Kana key on Japanese keyboards
		Kanji,											//	Kanji key on Japanese keyboards
		L = OpenTK.Input.Key.L,							//	L key
		LaunchApplication1,								//	Windows 2000/XP: Start Application 1 key
		LaunchApplication2,								//	Windows 2000/XP: Start Application 2 key
		LaunchMail,										//	Windows 2000/XP: Start Mail key
		Left = OpenTK.Input.Key.Left,					//	LEFT ARROW key
		LeftAlt = OpenTK.Input.Key.AltLeft,				//	Left ALT key
		LeftControl = OpenTK.Input.Key.ControlLeft,		//	Left CONTROL key
		LeftShift = OpenTK.Input.Key.ShiftLeft,			//	Left SHIFT key
		LeftWindows,									//	Left Windows key
		M = OpenTK.Input.Key.M,							//	M key
		MediaNextTrack,									//	Windows 2000/XP: Next Track key
		MediaPlayPause,									//	Windows 2000/XP: Play/Pause Media key
		MediaPreviousTrack,								//	Windows 2000/XP: Previous Track key
		MediaStop,										//	Windows 2000/XP: Stop Media key
		Multiply,										//	Multiply key
		N = OpenTK.Input.Key.N,							//	N key
		None,											//	Reserved
		NumLock = OpenTK.Input.Key.NumLock,							//	NUM LOCK key
		NumPad0 = OpenTK.Input.Key.Keypad0,							//	Numeric keypad 0 key
		NumPad1 = OpenTK.Input.Key.Keypad1,							//	Numeric keypad 1 key
		NumPad2 = OpenTK.Input.Key.Keypad2,							//	Numeric keypad 2 key
		NumPad3 = OpenTK.Input.Key.Keypad3,							//	Numeric keypad 3 key
		NumPad4 = OpenTK.Input.Key.Keypad4,							//	Numeric keypad 4 key
		NumPad5 = OpenTK.Input.Key.Keypad5,							//	Numeric keypad 5 key
		NumPad6 = OpenTK.Input.Key.Keypad6,							//  Numeric keypad 6 key
		NumPad7 = OpenTK.Input.Key.Keypad7,							//	Numeric keypad 7 key
		NumPad8 = OpenTK.Input.Key.Keypad8,							//	Numeric keypad 8 key
		NumPad9 = OpenTK.Input.Key.Keypad9,							//	Numeric keypad 9 key
		O = OpenTK.Input.Key.O,							//	O key
		Oem8,											//	Used for miscellaneous characters; it can vary by keyboard.
		OemAuto,										//	OEM Auto key
		OemBackslash,									//	Windows 2000/XP: The OEM angle bracket or backslash key on the RT 102 key keyboard
		OemClear,										//	CLEAR key
		OemCloseBrackets,								//	Windows 2000/XP: The OEM close bracket key on a US standard keyboard
		OemComma,									//	Windows 2000/XP: For any country/region, the ',' key
		OemCopy,									//	OEM Copy key
		OemEnlW,									//	OEM Enlarge Window key
		OemMinus,									//	Windows 2000/XP: For any country/region, the '-' key
		OemOpenBrackets,							//	Windows 2000/XP: The OEM open bracket key on a US standard keyboard
		OemPeriod,									//	Windows 2000/XP: For any country/region, the '.' key
		OemPipe,									//	Windows 2000/XP: The OEM pipe key on a US standard keyboard
		OemPlus,									//	Windows 2000/XP: For any country/region, the '+' key
		OemQuestion,								//	Windows 2000/XP: The OEM question mark key on a US standard keyboard
		OemQuotes,									//	Windows 2000/XP: The OEM singled/double quote key on a US standard keyboard
		OemSemicolon,								//	Windows 2000/XP: The OEM Semicolon key on a US standard keyboard
		OemTilde,									//	Windows 2000/XP: The OEM tilde key on a US standard keyboard
		P = OpenTK.Input.Key.P,						//	P key
		Pa1,										//	PA1 key
		PageDown = OpenTK.Input.Key.PageDown,						//	PAGE DOWN key
		PageUp = OpenTK.Input.Key.PageUp,							//	PAGE UP key
		Pause = OpenTK.Input.Key.Pause,								//	PAUSE key
		Play,							//	Play key
		Print,							//	PRINT key
		PrintScreen = OpenTK.Input.Key.PrintScreen,							//	PRINT SCREEN key
		ProcessKey,							//	Windows 95/98/Me, Windows NT 4.0, Windows 2000/XP: IME PROCESS key
		Q = OpenTK.Input.Key.Q,							//	Q key
		R = OpenTK.Input.Key.R,							//	R key
		Right = OpenTK.Input.Key.Right,							//	RIGHT ARROW key
		RightAlt = OpenTK.Input.Key.AltRight,							//	Right ALT key
		RightControl = OpenTK.Input.Key.ControlRight,							//	Right CONTROL key
		RightShift = OpenTK.Input.Key.ShiftRight,							//	Right SHIFT key
		RightWindows,							//	Right Windows key
		S = OpenTK.Input.Key.S,							//	S key
		Scroll = OpenTK.Input.Key.ScrollLock,							//	SCROLL LOCK key
		Select,							//	SELECT key
		SelectMedia,							//	Windows 2000/XP: Select Media key
		Separator,							//	Separator key
		Sleep,							//	Computer Sleep key
		Space = OpenTK.Input.Key.Space,							//	SPACEBAR
		Subtract,							//	Subtract key
		T = OpenTK.Input.Key.T,							//	T key
		Tab = OpenTK.Input.Key.Tab,							//	TAB key
		U = OpenTK.Input.Key.U,							//	U key
		Up = OpenTK.Input.Key.Up,							//	UP ARROW key
		V = OpenTK.Input.Key.V,							//	V key
		VolumeDown,							//	Windows 2000/XP: Volume Down key
		VolumeMute,							//	Windows 2000/XP: Volume Mute key
		VolumeUp,							//	Windows 2000/XP: Volume Up key
		W = OpenTK.Input.Key.W,							//	W key
		X = OpenTK.Input.Key.X,							//	X key
		Y = OpenTK.Input.Key.Y,							//	Y key
		Z = OpenTK.Input.Key.Z, 				//	Z key
		Zoom,
		_End
	}
}

