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
