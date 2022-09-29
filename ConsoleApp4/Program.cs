using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;

namespace ConsoleApp4
{
    class Program
    {
     public    static void Main(string[] args)
        {
            Console.WriteLine("Pls enter a string which woul like to read from Python");
            var input = Console.ReadLine();
            var py = Python.CreateEngine();
           // py.CreateScriptSourceFromFile 
            
            try
            {
                //py.Execute("print(' from python: " + input + "')");
                py.ExecuteFile("C:\\Users\\swatimayee.pattnaik\\source\\repos\\PythonApplication1\\PythonApplication1\\PythonApplication1.py");
                // py.ExecuteFile("C:\\Users\\swatimayee.pattnaik\\source\\repos\\PythonApplication1\\PythonApplication1\\module1.py");
               
//var df = PandasNet.Pandas()


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            Console.WriteLine("Pls press enter to exit");
            Console.ReadLine();

        }
    }
}
