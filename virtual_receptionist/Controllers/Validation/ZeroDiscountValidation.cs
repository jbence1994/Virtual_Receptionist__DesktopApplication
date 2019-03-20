using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist.Controllers.Validation
{
    public class ZeroDiscountValidation
    {
        private double discountRate;

        public ZeroDiscountValidation(double discountRate)
        {
            this.discountRate = discountRate;
        }
    }
}
