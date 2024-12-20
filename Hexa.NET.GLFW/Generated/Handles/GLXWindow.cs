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
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.GLFW
{
	/// <summary>
	/// GLX window type<br/>
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct GLXWindow : IEquatable<GLXWindow>
	{
		public GLXWindow(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static GLXWindow Null => new GLXWindow(0);
		public static implicit operator GLXWindow(nint handle) => new GLXWindow(handle);
		public static bool operator ==(GLXWindow left, GLXWindow right) => left.Handle == right.Handle;
		public static bool operator !=(GLXWindow left, GLXWindow right) => left.Handle != right.Handle;
		public static bool operator ==(GLXWindow left, nint right) => left.Handle == right;
		public static bool operator !=(GLXWindow left, nint right) => left.Handle != right;
		public bool Equals(GLXWindow other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is GLXWindow handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("GLXWindow [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
