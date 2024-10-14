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
	/// <summary>
	/// <br/>
	/// Opaque monitor object.<br/>
	/// <br/>
	/// <br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "GLFWmonitor")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct GLFWmonitor
	{


	}

	/// <summary>
	/// <br/>
	/// Opaque monitor object.<br/>
	/// <br/>
	/// <br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "GLFWmonitor")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct GLFWmonitorPtrPtr : IEquatable<GLFWmonitorPtrPtr>
	{
		public GLFWmonitorPtrPtr(GLFWmonitor** handle) { Handle = handle; }

		public GLFWmonitor** Handle;

		public bool IsNull => Handle == null;

		public static GLFWmonitorPtrPtr Null => new GLFWmonitorPtrPtr(null);

		public GLFWmonitor* this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator GLFWmonitorPtrPtr(GLFWmonitor** handle) => new GLFWmonitorPtrPtr(handle);

		public static implicit operator GLFWmonitor**(GLFWmonitorPtrPtr handle) => handle.Handle;

		public static bool operator ==(GLFWmonitorPtrPtr left, GLFWmonitorPtrPtr right) => left.Handle == right.Handle;

		public static bool operator !=(GLFWmonitorPtrPtr left, GLFWmonitorPtrPtr right) => left.Handle != right.Handle;

		public static bool operator ==(GLFWmonitorPtrPtr left, GLFWmonitor** right) => left.Handle == right;

		public static bool operator !=(GLFWmonitorPtrPtr left, GLFWmonitor** right) => left.Handle != right;

		public bool Equals(GLFWmonitorPtrPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is GLFWmonitorPtrPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("GLFWmonitorPtrPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
	}

	/// <summary>
	/// <br/>
	/// Opaque monitor object.<br/>
	/// <br/>
	/// <br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "GLFWmonitor")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct GLFWmonitorPtr : IEquatable<GLFWmonitorPtr>
	{
		public GLFWmonitorPtr(GLFWmonitor* handle) { Handle = handle; }

		public GLFWmonitor* Handle;

		public bool IsNull => Handle == null;

		public static GLFWmonitorPtr Null => new GLFWmonitorPtr(null);

		public GLFWmonitor this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator GLFWmonitorPtr(GLFWmonitor* handle) => new GLFWmonitorPtr(handle);

		public static implicit operator GLFWmonitor*(GLFWmonitorPtr handle) => handle.Handle;

		public static bool operator ==(GLFWmonitorPtr left, GLFWmonitorPtr right) => left.Handle == right.Handle;

		public static bool operator !=(GLFWmonitorPtr left, GLFWmonitorPtr right) => left.Handle != right.Handle;

		public static bool operator ==(GLFWmonitorPtr left, GLFWmonitor* right) => left.Handle == right;

		public static bool operator !=(GLFWmonitorPtr left, GLFWmonitor* right) => left.Handle != right;

		public bool Equals(GLFWmonitorPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is GLFWmonitorPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("GLFWmonitorPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
	}

}
