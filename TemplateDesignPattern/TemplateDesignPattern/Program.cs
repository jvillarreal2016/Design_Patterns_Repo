using System;

namespace TemplateDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var HelperA = new UniversityACourseRegistrationHelper();
            HelperA.RegisterStudent();
            
            var HelperB = new UniversityBCourseRegistrationHelper();
            HelperB.RegisterStudent();

            Console.ReadKey();



        }
    }
}