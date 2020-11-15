using System;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
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
