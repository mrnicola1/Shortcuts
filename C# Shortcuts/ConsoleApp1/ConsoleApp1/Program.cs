using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x; 
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine("1. Its Learning\t 11. Github"); //
                Console.WriteLine("2. VS Code");   //
                Console.WriteLine("3. Google");      //
                Console.WriteLine("4. Word");          //
                Console.WriteLine("5. Task Manager");   //
                Console.WriteLine("6. Control panel");   //
                Console.WriteLine("7. PowerShell");    //
                Console.WriteLine("8. Discord");
                Console.WriteLine("9. Folders");    //
                Console.WriteLine("10. LærePladsen.dk");   //
                Console.Write("--> ");
                


                _ = int.TryParse(Console.ReadLine(), out x);

                if (x < 0)
                {
                    Console.Clear();
                }


                if (x==1)
                {
                    System.Diagnostics.Process.Start("https://aarhustech.itslearning.com/main.aspx?TextURL=CourseCards");  
                }

                if (x == 2)
                {
                    Process.Start(@"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe");
                }

                if (x == 3)
                {
                    System.Diagnostics.Process.Start("http://google.com");
                }

                if (x == 4)
                {
                    Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE");
                }

                if (x == 5)
                {
                    Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\System Tools\Task Manager.lnk");
                }

                if (x == 6)
                {
                    Process.Start(@"C:\Users\nico6\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\System Tools\Control Panel.lnk");
                }

                if (x == 7)
                {
                    Process.Start(@"C:\Users\nico6\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Windows PowerShell\Windows PowerShell.lnk");
                }

                if (x == 8)
                {
                    Process.Start(@"C:\Users\nico6\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Discord Inc\Discord.lnk");
                }

                if (x == 9)
                {
                    Process.Start(@"C:\Users\nico6\OneDrive\Skrivebord");
                }

                if (x == 10)
                {
                    System.Diagnostics.Process.Start("https://www.laerepladsen.dk/");
                }

                if (x == 11)
                {
                    System.Diagnostics.Process.Start("https://github.com/");
                }
                Console.Clear();


            }
        }
    }
}
