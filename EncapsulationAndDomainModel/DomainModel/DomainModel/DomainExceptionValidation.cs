using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    // Está herdando Exception do próprio C#

    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string error) : base(error)
        {
        }

        public static void When(bool hasError, string error)
        {
            if (hasError)
                throw new DomainExceptionValidation(error);
        }
    }
}
