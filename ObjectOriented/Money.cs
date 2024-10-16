using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class Money
    {
        private readonly decimal _value;
        public Money(decimal value) 
        {
            _value = value;
        }
        public decimal Value {
            get
            {
                return _value;
            }
        } 
        public decimal TaxValue
        {
            get
            {
                return _value * 1.10m;
            }
        }
    }
}
