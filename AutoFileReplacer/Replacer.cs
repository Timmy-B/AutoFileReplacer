using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using Timer = System.Timers.Timer;

namespace AutoFileReplacer
{
    public partial class Replacer
    {

        static Timer replacerTimer = new Timer();
        static void ReplacerLoop()
        {
            var interval = Convert.ToDouble(ProcessOps.Interval());
            replacerTimer.Interval = TimeSpan.FromSeconds(interval).TotalMilliseconds;
            replacerTimer.AutoReset = true;
            replacerTimer.Elapsed += new System.Timers.ElapsedEventHandler(ReplacerMethod);
            replacerTimer.Start();


        }
        public static void Stop()
        {
            replacerTimer.Stop();
        }

        public static void Start()
        {
            ReplacerLoop();
        }

        private static void ReplacerMethod(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("---Starting Replacer---");
            var processes = ProcessOps.getProcesses();
            foreach (var process in processes)
            {
                var replaceThis = process.ReplaceThis;
                var replaceWith = process.ReplaceWith;
                Console.WriteLine("Running Replacement: " + process.Name.ToString());
                Console.WriteLine("1 Replace This: " + replaceThis);
                if (File.Exists(replaceThis))
                {
                    try
                    {
                        Console.WriteLine("2 Delete: " + replaceThis);
                        File.Delete(replaceThis);
                    }
                    catch (FileNotFoundException err)
                    {
                        Console.WriteLine(err.ToString());
                    }
                }
                if (replaceWith != null)
                {
                    if (File.Exists(replaceWith))
                    {
                        try
                        {
                            Console.WriteLine("3 Replace: " + replaceWith);
                            File.Copy(process.ReplaceWith, process.ReplaceThis);
                        }
                        catch (FileNotFoundException err)
                        {
                            Console.WriteLine(err.ToString());
                        }
                    }
                }

            }
            Console.WriteLine("---       Done      ---");
        }

    }
}
