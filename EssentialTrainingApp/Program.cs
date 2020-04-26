using System;
using System.Collections.Generic;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;// variable but hasn't been intialised to empty dtring

        static void Main(string[] args)
        {
            logger.Trace("The Program started.");
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazyMathProblem();
            ReadTextFile();
            Console.ReadLine();
        }

        private static void ReadTextFile() // catching exception code
        {
            try
            {
                using (var sr = new StreamReader(@"c:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Couldn't find directory");
                logger.Error("The directory was not found" + ex.Message);
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Couldn't find the file.");
                logger.Error(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("An unknown error occurred " + ex.Message);
            }
            finally
            {
                Console.WriteLine("The finally runs all the time."); // used to clean up exception
            }
        }
        private static int CrazyMathProblem()
        {
            var income = 1000;
            for(var i = 10; i > 0; i--)
            {
                income = income = (income / i);
            }
            return income;
        }
    }
}
