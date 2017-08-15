namespace DerivedTests.Validator
{
    public class SmsMessageValidator : MessageValidator
    {
        protected override void ValidateMessageLength(string message)
        {
            if (message.Length > 160)
            {
                throw new InvalidMessageException("Message is too long for a SMS");
            }
        }
    }
}
