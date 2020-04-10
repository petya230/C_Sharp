using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FontText
{
    class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetCurrentConsoleFontEx(
    IntPtr consoleOutput,
    bool maximumWindow,
    ref CONSOLE_FONT_INFO_EX consoleCurrentFontEx);

        static void Main(string[] args)
        {

        }
    }
}
