namespace Hexa.NET.GLFW
{
    using System.Runtime.InteropServices;

    public partial class GLFW
    {
        static GLFW()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "glfw3";
            }

            return "libglfw";
        }
    }
}