using HexaGen;
using HexaGen.Patching;

BatchGenerator batch = new();
batch.Start()
    .Setup<CsCodeGenerator>("generator.json")
    .AddPrePatch(new NamingPatch(["Glfw"], NamingPatchOptions.None))
    .AddPrePatch(new ConstantsToEnumPatch("GLFW_KEY_", "GlfwKey", "int"))
    .AddPrePatch(new ConstantsToEnumPatch("GLFW_MOD_", "GlfwMod", "int"))
    .AddPrePatch(new ConstantsToEnumPatch("GLFW_MOUSE_", "GlfwMouse", "int"))
    .AddPrePatch(new ConstantsToEnumPatch("GLFW_HAT_", "GlfwHat", "int"))
    .AddPrePatch(new ConstantsToEnumPatch("GLFW_JOYSTICK_", "GlfwJoystick", "int"))
    .AddPrePatch(new ConstantsToEnumPatch("GLFW_GAMEPAD_", "GlfwGamepad", "int"))
    .Generate("include/main.h", "../../../../Hexa.NET.GLFW/Generated", [.. Directory.GetFiles("include")])
    .Finish();