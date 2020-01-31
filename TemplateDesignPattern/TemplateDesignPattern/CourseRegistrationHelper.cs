using System;

namespace TemplateDesignPattern
{
    public abstract class CourseRegistrationHelper
    {
        public void RegisterStudent()
        {
            VerifyPrerequisites();
            ProcessPayment();
            SendNotification();
        }

        protected abstract void VerifyPrerequisites();

        protected void ProcessPayment()
        {
            Console.WriteLine("Processing Payment the generic way");
        }
        protected abstract void SendNotification();
    }
    
}