using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SingletonPatternDesign
{
    public class ScrabbleTest
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
            
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            Console.ReadLine();
        }
    }
}