using Hexa.NET.GLFW;

GLFW.Init();

GLFW.WindowHint(GLFW.GLFW_FOCUSED, 1);    // Make window focused on start
GLFW.WindowHint(GLFW.GLFW_RESIZABLE, 1);  // Make window resizable

GLFWwindowPtr window = GLFW.CreateWindow(800, 600, "GLFW Example", null, null);
if (window.IsNull)
{
    Console.WriteLine("Failed to create GLFW window.");
    GLFW.Terminate();
    return;
}

GLFW.MakeContextCurrent(window);

// Main loop
while (GLFW.WindowShouldClose(window) == 0)
{
    // Poll for and process events
    GLFW.PollEvents();

    if (GLFW.GetKey(window, (int)GlfwKey.Escape) == GLFW.GLFW_PRESS)
    {
        GLFW.SetWindowShouldClose(window, 1); // Request to close the window
    }

    // Swap front and back buffers (double buffering)
    GLFW.SwapBuffers(window);
}

// Clean up and terminate GLFW
GLFW.DestroyWindow(window);
GLFW.Terminate();