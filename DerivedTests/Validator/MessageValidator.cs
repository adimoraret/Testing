namespace DerivedTests.Validator
{
    public abstract class MessageValidator
    {
        protected abstract void ValidateMessageLength(string message);

        public void Validate(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new InvalidMessageException("Message is empty");
            }
            ValidateMessageLength(message);
        }
    }
}