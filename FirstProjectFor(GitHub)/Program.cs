using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography;
namespace ConsoleApp12
{
    internal class Program
    {
        public static void downloadH()
        {
            Console.WriteLine("Downloading AutoHotkey...");

            string autohotkeyUrl = "https://www.autohotkey.com/download/";
            string downloadPath = "autohotkey_setup.exe"; // Change this path as needed

            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(autohotkeyUrl, downloadPath);
                    Console.WriteLine("AutoHotkey downloaded successfully. You can find the installer at: " + downloadPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error downloading AutoHotkey: " + ex.Message);
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void OpenAutoHotkeyDownloadPage()
        {
            string autohotkeyUrl = "https://www.autohotkey.com/download/ahk-v2.exe";

            try
            {
                Process.Start(autohotkeyUrl);
                Console.WriteLine("Opening AutoHotkey download page...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening AutoHotkey download page: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            
         string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
         string filePath = Path.Combine(desktopPath, "ScriptForService(1).ahk");

            Console.WriteLine("Auto HotKey is requaired... do u have download it ? (yes or no)");
            String s=Console.ReadLine();
            if (s=="no")
            {
                Console.WriteLine("Cool .. Downloading Auto HotKey");
                OpenAutoHotkeyDownloadPage();
            }
            

            Console.WriteLine("Hello.. please enter the number of the service :\n1-Macro for rapid Fire\n2-sweat hot switch\n0-for Exit");
            String num = "0";
            num = Console.ReadLine();
            while (num != "0")
            {
                if (num == "1")
                {
                    try {
                            Console.WriteLine("By default the button is v for the macro Shooting");
                            using (StreamWriter w = new StreamWriter(filePath, true))
                            {
                            w.WriteLine("v::\nClick 5;\nreturn ");

                            }
                    }
                    catch(Exception e) 
                    { Console.WriteLine(e.Message); }

                    
                    
                    

                }

                else if (num == "2")
                { Console.WriteLine("case 2"); }

                else
                    Console.WriteLine("Please Select a vaild Service");


                if (num == "1" || num == "2")
                    Console.WriteLine("Anything else?");

                num = "0";
                num = Console.ReadLine();
            }
            Console.WriteLine("thx for using our product");

            Console.ReadKey();
            

        }
    }
}
