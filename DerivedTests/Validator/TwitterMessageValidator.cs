using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedTests.Validator
{
    public class TwitterMessageValidator : MessageValidator
    {
        protected override void ValidateMessageLength(string message)
        {
            if (message.Length > 140)
            {
                throw new InvalidMessageException("Message is too long for a tweet");
            }
        }
    }
}
