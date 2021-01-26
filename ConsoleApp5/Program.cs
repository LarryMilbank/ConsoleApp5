using System;

namespace Hokemon_U
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Hokeworld!");

            Hokemon hokeObject01 = new Hokemon(); // INSTANTIATE hokeObject from HOKEMON class

            //Console.Writeline("Hokemon name is: {0}", hokeobject.Name);

            hokeObject01.get_details();
            hokeObject01.about();

            Hokemon hoke02 = new Hokemon(); 

            hokeObject01.get_details();
        }   
    }
}




        