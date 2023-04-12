using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeCalculateur
{
    internal class CalculateurException : Exception
    {
        public CalculateurException(string message) : base(message)
        {
            
        }
    }
}
