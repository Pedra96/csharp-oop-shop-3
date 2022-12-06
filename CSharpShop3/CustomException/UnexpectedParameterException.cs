using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3.CustomException {
    internal class UnexpectedParameterException : Exception{
        public UnexpectedParameterException(string message) : base(message) { }
    }
}
