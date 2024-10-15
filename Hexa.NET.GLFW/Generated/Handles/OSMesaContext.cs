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
	/// OSMesa rendering context<br/>
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct OSMesaContext : IEquatable<OSMesaContext>
	{
		public OSMesaContext(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static OSMesaContext Null => new OSMesaContext(0);
		public static implicit operator OSMesaContext(nint handle) => new OSMesaContext(handle);
		public static bool operator ==(OSMesaContext left, OSMesaContext right) => left.Handle == right.Handle;
		public static bool operator !=(OSMesaContext left, OSMesaContext right) => left.Handle != right.Handle;
		public static bool operator ==(OSMesaContext left, nint right) => left.Handle == right;
		public static bool operator !=(OSMesaContext left, nint right) => left.Handle != right;
		public bool Equals(OSMesaContext other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is OSMesaContext handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("OSMesaContext [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
