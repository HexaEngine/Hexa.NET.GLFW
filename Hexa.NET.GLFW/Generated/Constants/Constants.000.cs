// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;

namespace Hexa.NET.GLFW
{
	public unsafe partial class GLFW
	{
		public const int GLFW_VERSION_MAJOR = 3;

		public const int GLFW_VERSION_MINOR = 5;

		public const int GLFW_VERSION_REVISION = 0;

		public const int GLFW_TRUE = 1;

		public const int GLFW_FALSE = 0;

		public const int GLFW_RELEASE = 0;

		public const int GLFW_PRESS = 1;

		public const int GLFW_REPEAT = 2;

		public const int GLFW_NO_ERROR = 0;

		public const int GLFW_NOT_INITIALIZED = 0x00010001;

		public const int GLFW_NO_CURRENT_CONTEXT = 0x00010002;

		public const int GLFW_INVALID_ENUM = 0x00010003;

		public const int GLFW_INVALID_VALUE = 0x00010004;

		public const int GLFW_OUT_OF_MEMORY = 0x00010005;

		public const int GLFW_API_UNAVAILABLE = 0x00010006;

		public const int GLFW_VERSION_UNAVAILABLE = 0x00010007;

		public const int GLFW_PLATFORM_ERROR = 0x00010008;

		public const int GLFW_FORMAT_UNAVAILABLE = 0x00010009;

		public const int GLFW_NO_WINDOW_CONTEXT = 0x0001000A;

		public const int GLFW_CURSOR_UNAVAILABLE = 0x0001000B;

		public const int GLFW_FEATURE_UNAVAILABLE = 0x0001000C;

		public const int GLFW_FEATURE_UNIMPLEMENTED = 0x0001000D;

		public const int GLFW_PLATFORM_UNAVAILABLE = 0x0001000E;

		public const int GLFW_FOCUSED = 0x00020001;

		public const int GLFW_ICONIFIED = 0x00020002;

		public const int GLFW_RESIZABLE = 0x00020003;

		public const int GLFW_VISIBLE = 0x00020004;

		public const int GLFW_DECORATED = 0x00020005;

		public const int GLFW_AUTO_ICONIFY = 0x00020006;

		public const int GLFW_FLOATING = 0x00020007;

		public const int GLFW_MAXIMIZED = 0x00020008;

		public const int GLFW_CENTER_CURSOR = 0x00020009;

		public const int GLFW_TRANSPARENT_FRAMEBUFFER = 0x0002000A;

		public const int GLFW_HOVERED = 0x0002000B;

		public const int GLFW_FOCUS_ON_SHOW = 0x0002000C;

		public const int GLFW_POSITION_X = 0x0002000E;

		public const int GLFW_POSITION_Y = 0x0002000F;

		public const int GLFW_RED_BITS = 0x00021001;

		public const int GLFW_GREEN_BITS = 0x00021002;

		public const int GLFW_BLUE_BITS = 0x00021003;

		public const int GLFW_ALPHA_BITS = 0x00021004;

		public const int GLFW_DEPTH_BITS = 0x00021005;

		public const int GLFW_STENCIL_BITS = 0x00021006;

		public const int GLFW_ACCUM_RED_BITS = 0x00021007;

		public const int GLFW_ACCUM_GREEN_BITS = 0x00021008;

		public const int GLFW_ACCUM_BLUE_BITS = 0x00021009;

		public const int GLFW_ACCUM_ALPHA_BITS = 0x0002100A;

		public const int GLFW_AUX_BUFFERS = 0x0002100B;

		public const int GLFW_STEREO = 0x0002100C;

		public const int GLFW_SAMPLES = 0x0002100D;

		public const int GLFW_SRGB_CAPABLE = 0x0002100E;

		public const int GLFW_REFRESH_RATE = 0x0002100F;

		public const int GLFW_DOUBLEBUFFER = 0x00021010;

		public const int GLFW_CLIENT_API = 0x00022001;

		public const int GLFW_CONTEXT_VERSION_MAJOR = 0x00022002;

		public const int GLFW_CONTEXT_VERSION_MINOR = 0x00022003;

		public const int GLFW_CONTEXT_REVISION = 0x00022004;

		public const int GLFW_CONTEXT_ROBUSTNESS = 0x00022005;

		public const int GLFW_OPENGL_FORWARD_COMPAT = 0x00022006;

		public const int GLFW_CONTEXT_DEBUG = 0x00022007;

		public const int GLFW_OPENGL_PROFILE = 0x00022008;

		public const int GLFW_CONTEXT_RELEASE_BEHAVIOR = 0x00022009;

		public const int GLFW_CONTEXT_NO_ERROR = 0x0002200A;

		public const int GLFW_CONTEXT_CREATION_API = 0x0002200B;

		public const int GLFW_SCALE_TO_MONITOR = 0x0002200C;

		public const int GLFW_SCALE_FRAMEBUFFER = 0x0002200D;

		public const int GLFW_COCOA_RETINA_FRAMEBUFFER = 0x00023001;

		public const int GLFW_COCOA_FRAME_NAME = 0x00023002;

		public const int GLFW_COCOA_GRAPHICS_SWITCHING = 0x00023003;

		public const int GLFW_X11_CLASS_NAME = 0x00024001;

		public const int GLFW_X11_INSTANCE_NAME = 0x00024002;

		public const int GLFW_WIN32_KEYBOARD_MENU = 0x00025001;

		public const int GLFW_WIN32_SHOWDEFAULT = 0x00025002;

		public const int GLFW_WAYLAND_APP_ID = 0x00026001;

		public const int GLFW_NO_API = 0;

		public const int GLFW_OPENGL_API = 0x00030001;

		public const int GLFW_OPENGL_ES_API = 0x00030002;

		public const int GLFW_NO_ROBUSTNESS = 0;

		public const int GLFW_NO_RESET_NOTIFICATION = 0x00031001;

		public const int GLFW_LOSE_CONTEXT_ON_RESET = 0x00031002;

		public const int GLFW_OPENGL_ANY_PROFILE = 0;

		public const int GLFW_OPENGL_CORE_PROFILE = 0x00032001;

		public const int GLFW_OPENGL_COMPAT_PROFILE = 0x00032002;

		public const int GLFW_CURSOR = 0x00033001;

		public const int GLFW_STICKY_KEYS = 0x00033002;

		public const int GLFW_STICKY_MOUSE_BUTTONS = 0x00033003;

		public const int GLFW_LOCK_KEY_MODS = 0x00033004;

		public const int GLFW_RAW_MOUSE_MOTION = 0x00033005;

		public const int GLFW_UNLIMITED_MOUSE_BUTTONS = 0x00033006;

		public const int GLFW_CURSOR_NORMAL = 0x00034001;

		public const int GLFW_CURSOR_HIDDEN = 0x00034002;

		public const int GLFW_CURSOR_DISABLED = 0x00034003;

		public const int GLFW_CURSOR_CAPTURED = 0x00034004;

		public const int GLFW_ANY_RELEASE_BEHAVIOR = 0;

		public const int GLFW_RELEASE_BEHAVIOR_FLUSH = 0x00035001;

		public const int GLFW_RELEASE_BEHAVIOR_NONE = 0x00035002;

		public const int GLFW_NATIVE_CONTEXT_API = 0x00036001;

		public const int GLFW_EGL_CONTEXT_API = 0x00036002;

		public const int GLFW_OSMESA_CONTEXT_API = 0x00036003;

		public const int GLFW_ANGLE_PLATFORM_TYPE_NONE = 0x00037001;

		public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGL = 0x00037002;

		public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGLES = 0x00037003;

		public const int GLFW_ANGLE_PLATFORM_TYPE_D3D9 = 0x00037004;

		public const int GLFW_ANGLE_PLATFORM_TYPE_D3D11 = 0x00037005;

		public const int GLFW_ANGLE_PLATFORM_TYPE_VULKAN = 0x00037007;

		public const int GLFW_ANGLE_PLATFORM_TYPE_METAL = 0x00037008;

		public const int GLFW_WAYLAND_PREFER_LIBDECOR = 0x00038001;

		public const int GLFW_WAYLAND_DISABLE_LIBDECOR = 0x00038002;

		public const uint GLFW_ANY_POSITION = 0x80000000;

		public const int GLFW_ARROW_CURSOR = 0x00036001;

		public const int GLFW_IBEAM_CURSOR = 0x00036002;

		public const int GLFW_CROSSHAIR_CURSOR = 0x00036003;

		public const int GLFW_POINTING_HAND_CURSOR = 0x00036004;

		public const int GLFW_RESIZE_EW_CURSOR = 0x00036005;

		public const int GLFW_RESIZE_NS_CURSOR = 0x00036006;

		public const int GLFW_RESIZE_NWSE_CURSOR = 0x00036007;

		public const int GLFW_RESIZE_NESW_CURSOR = 0x00036008;

		public const int GLFW_RESIZE_ALL_CURSOR = 0x00036009;

		public const int GLFW_NOT_ALLOWED_CURSOR = 0x0003600A;

		public const int GLFW_CONNECTED = 0x00040001;

		public const int GLFW_DISCONNECTED = 0x00040002;

		public const int GLFW_ANGLE_PLATFORM_TYPE = 0x00050002;

		public const int GLFW_PLATFORM = 0x00050003;

		public const int GLFW_COCOA_CHDIR_RESOURCES = 0x00051001;

		public const int GLFW_COCOA_MENUBAR = 0x00051002;

		public const int GLFW_X11_XCB_VULKAN_SURFACE = 0x00052001;

		public const int GLFW_WAYLAND_LIBDECOR = 0x00053001;

		public const int GLFW_ANY_PLATFORM = 0x00060000;

		public const int GLFW_PLATFORM_WIN32 = 0x00060001;

		public const int GLFW_PLATFORM_COCOA = 0x00060002;

		public const int GLFW_PLATFORM_WAYLAND = 0x00060003;

		public const int GLFW_PLATFORM_X11 = 0x00060004;

		public const int GLFW_PLATFORM_NULL = 0x00060005;

		public const int GLFW_DONT_CARE = -1;

	}
}
