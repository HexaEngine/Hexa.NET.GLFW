using Hexa.NET.GLFW;

unsafe
{
    GLFW.Init();

    GLFW.WindowHint(GLFW.GLFW_FOCUSED, 1);    // Make window focused on start
    GLFW.WindowHint(GLFW.GLFW_RESIZABLE, 1);  // Make window resizable

    GLFWwindow* window = GLFW.CreateWindow(800, 600, "GLFW Example", null, null);
    if (window == null)
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

        // Swap front and back buffers (double buffering)
        GLFW.SwapBuffers(window);
    }

    // Clean up and terminate GLFW
    GLFW.DestroyWindow(window);
    GLFW.Terminate();
}