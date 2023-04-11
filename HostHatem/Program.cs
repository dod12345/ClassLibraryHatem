using System;
using System.ServiceModel;

namespace HostHatem
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(ClassLibraryHatem.WCFHatem))) 
            {
                host.Open(); Console.WriteLine("Host started @"+ DateTime.Now.ToString());  
                Console.ReadLine();

            }
        }
    }
}
