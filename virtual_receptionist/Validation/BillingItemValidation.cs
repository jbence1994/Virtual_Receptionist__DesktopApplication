using System;
using static virtual_receptionist.Validation.InputValidation;

namespace virtual_receptionist.Validation
{
    public static class BillingItemValidation
    {
        public static void ValidateBillingItem(string billingItem)
        {
            if (IsEmpty(billingItem))
                throw new Exception("Nincs kijelölt tétel!");
        }
    }
}
