using System;

namespace TemplateDesignPattern
{
    class UniversityACourseRegistrationHelper : CourseRegistrationHelper
    {
        protected override void VerifyPrerequisites()
        {
            Console.WriteLine("Validate transcript");
        }

        protected void ProcessPayment()
        {
            Console.WriteLine("Process Cash Payment...");
        }

        protected override void SendNotification()
        {
            Console.WriteLine("Send a letter");
        }
    }
}