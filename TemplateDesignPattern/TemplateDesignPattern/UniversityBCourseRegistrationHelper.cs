using System;

namespace TemplateDesignPattern
{
    public class UniversityBCourseRegistrationHelper : CourseRegistrationHelper
    {
        protected override void VerifyPrerequisites()
        {
            Console.WriteLine("Validate university records");
        }

        protected void ProcessPayment()
        {
            Console.WriteLine("Process Credit Card Payment...");
        }

        protected override void SendNotification()
        {
            Console.WriteLine("Send email");
        }
    }
}