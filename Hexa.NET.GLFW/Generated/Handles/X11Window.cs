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
	/// X11 window type<br/>
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct X11Window : IEquatable<X11Window>
	{
		public X11Window(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static X11Window Null => new X11Window(0);
		public static implicit operator X11Window(nint handle) => new X11Window(handle);
		public static bool operator ==(X11Window left, X11Window right) => left.Handle == right.Handle;
		public static bool operator !=(X11Window left, X11Window right) => left.Handle != right.Handle;
		public static bool operator ==(X11Window left, nint right) => left.Handle == right;
		public static bool operator !=(X11Window left, nint right) => left.Handle != right;
		public bool Equals(X11Window other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is X11Window handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("X11Window [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
