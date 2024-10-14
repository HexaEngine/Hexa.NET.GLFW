using HexaGen;
using HexaGen.Patching;

CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load("generator.json");
CsCodeGenerator generator = new(config);
generator.PatchEngine.RegisterPrePatch(new NamingPatch(["Glfw"], NamingPatchOptions.None));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_KEY_", "GlfwKey", "int"));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_MOD_", "GlfwMod", "int"));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_MOUSE_", "GlfwMouse", "int"));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_HAT_", "GlfwHat", "int"));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_JOYSTICK_", "GlfwJoystick", "int"));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_GAMEPAD_", "GlfwGamepad", "int"));

generator.Generate([.. Directory.GetFiles("include")], "../../../../Hexa.NET.GLFW/Generated");