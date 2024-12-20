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
	/// Handle to an OpenGL rendering context<br/>
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct Hglrc : IEquatable<Hglrc>
	{
		public Hglrc(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static Hglrc Null => new Hglrc(0);
		public static implicit operator Hglrc(nint handle) => new Hglrc(handle);
		public static bool operator ==(Hglrc left, Hglrc right) => left.Handle == right.Handle;
		public static bool operator !=(Hglrc left, Hglrc right) => left.Handle != right.Handle;
		public static bool operator ==(Hglrc left, nint right) => left.Handle == right;
		public static bool operator !=(Hglrc left, nint right) => left.Handle != right;
		public bool Equals(Hglrc other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is Hglrc handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("Hglrc [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
