using System;

namespace SingletonDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");


            /* 
             * ⚡ The 𝐬𝐰𝐢𝐭𝐜𝐡 𝐞𝐱𝐩𝐫𝐞𝐬𝐬𝐢𝐨𝐧 was introduced in C# 8.0 and it's a more compact and readable way of writing a switch statement.
             * 💥 Instead of using a 𝐛𝐫𝐞𝐚𝐤 for each case, the switch expression uses the => operator to immediately return a value when a case matches.
            int number = 3;
            string result = number switch
            {
                0 => "zero",
                1 => "one",
                2 => "two",
                3 => "three",
                _ => "Default Case"
            };
            Console.WriteLine(result);*/
        }
    }
}
