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

namespace Hexa.NET.GLFW
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct WlDisplay
	{


	}

	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct WlDisplayPtr : IEquatable<WlDisplayPtr>
	{
		public WlDisplayPtr(WlDisplay* handle) { Handle = handle; }

		public WlDisplay* Handle;

		public bool IsNull => Handle == null;

		public static WlDisplayPtr Null => new WlDisplayPtr(null);

		public WlDisplay this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator WlDisplayPtr(WlDisplay* handle) => new WlDisplayPtr(handle);

		public static implicit operator WlDisplay*(WlDisplayPtr handle) => handle.Handle;

		public static bool operator ==(WlDisplayPtr left, WlDisplayPtr right) => left.Handle == right.Handle;

		public static bool operator !=(WlDisplayPtr left, WlDisplayPtr right) => left.Handle != right.Handle;

		public static bool operator ==(WlDisplayPtr left, WlDisplay* right) => left.Handle == right;

		public static bool operator !=(WlDisplayPtr left, WlDisplay* right) => left.Handle != right;

		public bool Equals(WlDisplayPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is WlDisplayPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("WlDisplayPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
	}

}