namespace Hexa.NET.GLFW
{
    public partial class GLFW
    {
        static GLFW()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "glfw";
        }
    }
}