using DerivedTests.Validator;
using NUnit.Framework;

namespace DerivedTests.Test
{
    public abstract class MessageValidatorTests
    {
        protected MessageValidator Sut;

        [Test]
        public void ShouldNotValidateNullMessage()
        {
            Assert.Throws<InvalidMessageException>(() => Sut.Validate(null));
        }

        [Test]
        public void ShouldNotValidateEmptyMessage()
        {
            Assert.Throws<InvalidMessageException>(() => Sut.Validate(string.Empty));
        }

        [Test]
        public void ShouldValidateNonEmptyMessage()
        {
            Assert.DoesNotThrow(() => Sut.Validate("sample message"));
        }
    }
}
