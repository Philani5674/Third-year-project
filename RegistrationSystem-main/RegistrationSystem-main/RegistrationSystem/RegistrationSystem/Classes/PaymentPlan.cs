namespace RegistrationSystem.Classes
{
    public class PaymentPlan
    {
        public int PaymentPlanID;
        public string PaymentPlanTitle;
        public string PaymentPlanLength;
        public string PaymentPlanDescription;

        // an empty payment plan constructor
        public PaymentPlan() { }

        // creates an instance of payment plan with params
        public PaymentPlan(int id, string title, string length, string description)
        {
            this.PaymentPlanID = id;
            this.PaymentPlanTitle = title;
            this.PaymentPlanLength = length;
            this.PaymentPlanDescription = description;
        }
    }
}
