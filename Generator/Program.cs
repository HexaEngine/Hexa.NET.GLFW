using CppAst;
using HexaGen;
using HexaGen.Core.CSharp;
using HexaGen.Metadata;
using HexaGen.Patching;
using System.Linq;
using System.Text;

CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load("generator.json");
CsCodeGenerator generator = new(config);
generator.FunctionGenerator.OverwriteStep<StringReturnGenStep>(new GlfwStringReturnGenStep());
generator.PatchEngine.RegisterPrePatch(new NamingPatch(["Glfw"], NamingPatchOptions.None));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_KEY_", "GlfwKey", "int"));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_MOD_", "GlfwMod", "int"));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_MOUSE_", "GlfwMouse", "int"));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_HAT_", "GlfwHat", "int"));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_JOYSTICK_", "GlfwJoystick", "int"));
generator.PatchEngine.RegisterPrePatch(new ConstantsToEnumPatch("GLFW_GAMEPAD_", "GlfwGamepad", "int"));

generator.Generate([.. Directory.GetFiles("include")], "../../../../Hexa.NET.GLFW/Generated");

public class GlfwStringReturnGenStep : StringReturnGenStep
{
    protected override bool AllowReturnType(CsFunctionOverload function, CsFunctionVariation variation, CsType returnType)
    {
        if (base.AllowReturnType(function, variation, returnType))
        {
            int p = 0;
            for (int i = 0; i < returnType.Name.Length; i++)
            {
                if (returnType.Name[i] == '*')
                {
                    p++;
                    if (p > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        return false;
    }
}