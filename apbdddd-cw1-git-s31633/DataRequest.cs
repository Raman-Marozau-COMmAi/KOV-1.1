using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace apbdddd_cw1_git_s31633
{
    internal class DataRequest
    {

        String data;

        public DataRequest() {

            Console.WriteLine("Enter your data:");
            data = Console.ReadLine();
            

        }

        public void PrintData() {


            Console.WriteLine("Your data is: " + data);
        
        
        }

    }
}
