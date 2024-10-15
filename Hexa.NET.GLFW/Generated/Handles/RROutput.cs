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
	/// X11 output resource<br/>
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct RROutput : IEquatable<RROutput>
	{
		public RROutput(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static RROutput Null => new RROutput(0);
		public static implicit operator RROutput(nint handle) => new RROutput(handle);
		public static bool operator ==(RROutput left, RROutput right) => left.Handle == right.Handle;
		public static bool operator !=(RROutput left, RROutput right) => left.Handle != right.Handle;
		public static bool operator ==(RROutput left, nint right) => left.Handle == right;
		public static bool operator !=(RROutput left, nint right) => left.Handle != right;
		public bool Equals(RROutput other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is RROutput handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("RROutput [0x{0}]", Handle.ToString("X"));
		#endif
	}
}