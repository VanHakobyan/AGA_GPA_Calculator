using System;
using System.Threading;
using System.Diagnostics;
namespace AGA___MOG___Calculator



{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(45, 30);

            int n = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Prepared by` ");
            #region MY NAME SLEEP
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(200);
            Console.Write("V");
            Thread.Sleep(200);
            Console.Write("A");
            Thread.Sleep(200);
            Console.Write("N");
            Thread.Sleep(200);
            Console.Write("  H");
            Thread.Sleep(200);
            Console.Write("A");
            Thread.Sleep(200);
            Console.Write("K");
            Thread.Sleep(200);
            Console.Write("O");
            Thread.Sleep(200);
            Console.Write("B");
            Thread.Sleep(200);
            Console.Write("Y");
            Thread.Sleep(200);
            Console.Write("A");
            Thread.Sleep(200);
            Console.Write("N");
            Thread.Sleep(250);
            Console.WriteLine();
            #endregion
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Thread.Sleep(300);
            DateTime thisData = DateTime.Now;
            Console.WriteLine(thisData.ToString());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

        k: Console.Write("Insert your number of Lessons - ");

            n = Convert.ToInt16(Console.ReadLine());


            if (n <= 0 || n >= 10)
            {
                Console.WriteLine("ERROR");
                goto k;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            float SumPoint = 0;
            float SumCredit = 0;
            float LikPoint = 0;
            float AGA = 0;
            float[] ArrayPoint = new float[n];
            float[] ArrayCredit = new float[n];
            #region point and credit insert
            for (int i = 0; i < ArrayPoint.Length; i++)
            {
            N: Console.Write("Please Upload Points N{0} - ", i + 1);
                ArrayPoint[i] = Convert.ToSingle(Console.ReadLine());
                if (ArrayPoint[i] < 0 && ArrayPoint[i] > 100)
                {
                    Console.WriteLine("Error: it is not Calc...");
                    goto N;
                }

                // Console.WriteLine();
                Console.Write("");
                Console.Write("        Please Upload Credit N{0} - ", i + 1);
                ArrayCredit[i] = Convert.ToSingle(Console.ReadLine());
            M: if (ArrayCredit[i] <= 0 && ArrayCredit[i] > 15)
                {
                    Console.WriteLine("Error: it is not Calc...");
                    goto M;
                }
                Console.WriteLine();
            }

            #endregion
            #region Algoritm AGA
            for (int i = 0; i < ArrayPoint.Length; i++)
            {
                SumPoint += ArrayPoint[i] * ArrayCredit[i];
                LikPoint += ArrayPoint[i];
            }
            for (int i = 0; i < ArrayCredit.Length; i++)
            {
                SumCredit += ArrayCredit[i];
            }
            AGA = SumPoint / SumCredit;
            #endregion
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your Average Qualitative Appraisal is: {0}", AGA);
            #region Likvid
            if (LikPoint / ArrayPoint.Length < 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("But you fail the exam !!!");

            }
            Console.WriteLine();
            #endregion
            #region WEB ang FB.COM
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("For more Enter - Y or y");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("For my website Enter - V or v");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("For counting again Enter - n or N");

            char m = Convert.ToChar(Console.ReadLine());
            if (m == 'y' || m == 'Y')
            {
                try
                {
                    var p = new ProcessStartInfo("chrome.exe");

                    p.Arguments = "https://web.facebook.com/VANHAKOBYAN";
                    Process.Start(p);

                }
                catch (Exception)
                {
                    var p = new ProcessStartInfo("Firefox.exe");
                    p.Arguments = "https://web.facebook.com/VANHAKOBYAN";
                    Process.Start(p);

                };


            }



            if (m == 'v' || m == 'V')
            {
                try
                {
                    var p = new ProcessStartInfo("chrome.exe");
                    p.Arguments = "http://www.aparanblog.do.am";
                    Process.Start(p);
                }
                catch
                {
                    var p = new ProcessStartInfo("chrome.exe");
                    p.Arguments = "http://www.aparanblog.do.am";
                    Process.Start(p);

                };
            }
            if (m == 'n' || m == 'N')
                goto k;
            #endregion
            Console.ReadKey();
        }
    }
}
