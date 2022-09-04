using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSystem.baseDataSetTableAdapters;
using RegistrationSystem.Classes;

namespace RegistrationSystem
{
    public class PaymentHandler
    {
        public object NewPayment(Payment payment)
        {
            var paymentAdapter = new PaymentTableAdapter();
            var pay = paymentAdapter.CreatePayment(
                PaymentDecription:payment.PaymentDescription,
                Amount:payment.Amount,
                PaymentDate:payment.PaymentDate, 
                RegistrationID:payment.RegistrationID);
            return pay;
        }
    }
}
