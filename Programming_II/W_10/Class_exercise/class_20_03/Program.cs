using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_20_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs fromt the user NOT EXPECTED that would crash the program
            //Expection Class / Object with attributes: (Message/Data/HelpLink/HResult/InnerException)
            /*
            Ignore - Let it go / program will crash
            Catch
            Catch and then re-throw
            Throw
            */
            int a, b = 1, c = 0;

            try
            {
                a = b / c;
                Console.WriteLine(a);
                if (c == 0)
                {
                    throw new Exception("C cannot be cero");
                }
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //full syntax
            try
            {
                //statement that can result in a exception
            }
            catch (FileNotFoundException e)
            {
                //this block only catch FileNotFoundException
            }
            catch (UnauthorizedAccessException e)
            {
                //this block only catch any Exception not caught in previous catch blocks
            }
            catch (Exception e)
            {
                //this block only catch any Exception not caught in the two previous catch blocks
                //this is the last catch block
            }
            finally
            {
                //this code will always be processed
                //clean up code here 
            }
        }
    }
}
