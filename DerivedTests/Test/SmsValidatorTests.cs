using DerivedTests.Validator;
using NUnit.Framework;

namespace DerivedTests.Test
{
    [TestFixture]
    public class SmsValidatorTests : MessageValidatorTests
    {
        [SetUp]
        protected void SetUp()
        {
            Sut = new SmsMessageValidator();
        }

        [Test]
        public void ShouldThrowExceptionForMessagesLongerThan160Characters()
        {
            const string messageWithMoreThan160Characters = "Yes. The maximum length of text message that you can send is 918 characters. However, if you send more than 160 characters then your message will be broken down.";

            Assert.Throws<InvalidMessageException>(() => Sut.Validate(messageWithMoreThan160Characters));
        }
    }
}
