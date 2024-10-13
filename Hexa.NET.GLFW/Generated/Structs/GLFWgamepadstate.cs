// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.GLFW
{
	/// <summary>
	/// <br/>
	/// This describes the input state of a gamepad.<br/>
	/// <br/>
	/// <br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "GLFWgamepadstate")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct GLFWgamepadstate
	{
		/// <summary>
		/// The states of each [gamepad button](<br/>
		/// `GLFW_PRESS`<br/>
		/// or `GLFW_RELEASE`.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "buttons")]
		[NativeName(NativeNameType.Type, "unsigned char[15]")]
		public byte Buttons_0;
		public byte Buttons_1;
		public byte Buttons_2;
		public byte Buttons_3;
		public byte Buttons_4;
		public byte Buttons_5;
		public byte Buttons_6;
		public byte Buttons_7;
		public byte Buttons_8;
		public byte Buttons_9;
		public byte Buttons_10;
		public byte Buttons_11;
		public byte Buttons_12;
		public byte Buttons_13;
		public byte Buttons_14;

		/// <summary>
		/// The states of each [gamepad axis](<br/>
		/// in the range -1.0<br/>
		/// to 1.0 inclusive.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "axes")]
		[NativeName(NativeNameType.Type, "float[6]")]
		public float Axes_0;
		public float Axes_1;
		public float Axes_2;
		public float Axes_3;
		public float Axes_4;
		public float Axes_5;


		public unsafe GLFWgamepadstate(byte* buttons = default, float* axes = default)
		{
			if (buttons != default(byte*))
			{
				Buttons_0 = buttons[0];
				Buttons_1 = buttons[1];
				Buttons_2 = buttons[2];
				Buttons_3 = buttons[3];
				Buttons_4 = buttons[4];
				Buttons_5 = buttons[5];
				Buttons_6 = buttons[6];
				Buttons_7 = buttons[7];
				Buttons_8 = buttons[8];
				Buttons_9 = buttons[9];
				Buttons_10 = buttons[10];
				Buttons_11 = buttons[11];
				Buttons_12 = buttons[12];
				Buttons_13 = buttons[13];
				Buttons_14 = buttons[14];
			}
			if (axes != default(float*))
			{
				Axes_0 = axes[0];
				Axes_1 = axes[1];
				Axes_2 = axes[2];
				Axes_3 = axes[3];
				Axes_4 = axes[4];
				Axes_5 = axes[5];
			}
		}

		public unsafe GLFWgamepadstate(Span<byte> buttons = default, Span<float> axes = default)
		{
			if (buttons != default(Span<byte>))
			{
				Buttons_0 = buttons[0];
				Buttons_1 = buttons[1];
				Buttons_2 = buttons[2];
				Buttons_3 = buttons[3];
				Buttons_4 = buttons[4];
				Buttons_5 = buttons[5];
				Buttons_6 = buttons[6];
				Buttons_7 = buttons[7];
				Buttons_8 = buttons[8];
				Buttons_9 = buttons[9];
				Buttons_10 = buttons[10];
				Buttons_11 = buttons[11];
				Buttons_12 = buttons[12];
				Buttons_13 = buttons[13];
				Buttons_14 = buttons[14];
			}
			if (axes != default(Span<float>))
			{
				Axes_0 = axes[0];
				Axes_1 = axes[1];
				Axes_2 = axes[2];
				Axes_3 = axes[3];
				Axes_4 = axes[4];
				Axes_5 = axes[5];
			}
		}


	}

}