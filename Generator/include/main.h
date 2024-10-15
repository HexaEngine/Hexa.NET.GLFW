#include "glfw3.h"

// Windows-specific types

// Handle to a window
typedef void* HWND;
// Handle to an OpenGL rendering context
typedef void* HGLRC;

// macOS specific types

// Display ID in CoreGraphics
typedef unsigned long CGDirectDisplayID;
// Objective-C object type (generic pointer)
typedef void* id;

// X11 types

// X11 display connection
typedef void* Display;
// X11 crtc (cathode ray tube) resource
typedef void* RRCrtc;
// X11 output resource
typedef void* RROutput;
// X11 window type
typedef void* Window;

// GLX types

// GLX rendering context
typedef void* GLXContext;
// GLX window type
typedef void* GLXWindow;

// EGL types

 // EGL display connection
typedef void* EGLDisplay;
// EGL rendering context
typedef void* EGLContext;
// EGL surface type
typedef void* EGLSurface;

// OSMesa types

// OSMesa rendering context
typedef void* OSMesaContext;

#define GLFW_EXPOSE_NATIVE_WIN32
#define GLFW_EXPOSE_NATIVE_COCOA
#define GLFW_EXPOSE_NATIVE_X11
#define GLFW_EXPOSE_NATIVE_WAYLAND

#define GLFW_EXPOSE_NATIVE_WGL
#define GLFW_EXPOSE_NATIVE_NSGL
#define GLFW_EXPOSE_NATIVE_GLX
#define GLFW_EXPOSE_NATIVE_EGL
#define GLFW_EXPOSE_NATIVE_OSMESA
#define GLFW_NATIVE_INCLUDE_NONE
#include "glfw3native.h"