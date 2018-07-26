using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = @"C:\Users\asus\Desktop\Programming\CSharp\learncs\HandlingExceptions\Example.txt";
            try
            {
                
                var content = File.ReadAllText(url);
                Console.WriteLine(content);
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was an issue!");
                Console.WriteLine("Make sure the file is named correctly: Example.txt.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("There was an issue!");
                Console.WriteLine("The directory you are looking for does not exist.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an issue!");
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                //code to finalize, setting objects to null, closing DB connections.
                Console.WriteLine("The application is terminating.");
            }
            Console.ReadLine();
        }
    }
}
