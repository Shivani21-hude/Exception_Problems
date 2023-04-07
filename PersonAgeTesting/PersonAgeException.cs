using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAgeTesting
{
    internal class PersonAgeException : Exception
    {
        public enum ExceptionTypes
        {
            FORMAT_ERROR,
            NULL_MESSAGE,
            EMPTY_MESSAGE

        }
        public ExceptionTypes types;
        public PersonAgeException(string message) : base(message)
        {

        }
        public PersonAgeException(ExceptionTypes types, string message) : base(message)
        {
            this.types = types;
        }
    }
}
