using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    //Sealed restricts the inheritance
    public sealed class Singleton
    {
        private static int counter = 0;
        
        /*
         * Private constructor ensures that object is not
         * instantiated other than with in the class itself
         */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static Singleton instance = null;
        /*
         * Public property is used to return only one instance of the class
         * leveraging on the private property (ব্যক্তিগত সম্পত্তির সুবিধা)
         */
        public static Singleton GetInstance //It's a property
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
