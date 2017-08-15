using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DerivedTests.Validator;
using NUnit.Framework;

namespace DerivedTests.Test
{
    [TestFixture]
    public class TweetValidatorTests : MessageValidatorTests
    {
        [SetUp]
        protected void SetUp()
        {
            Sut = new TwitterMessageValidator();
        }

        [Test]
        public void ShouldThrowExceptionForMessagesLongerThan140Characters()
        {
            const string messageWithMoreThan160Characters = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum";

            Assert.Throws<InvalidMessageException>(() => Sut.Validate(messageWithMoreThan160Characters));
        }
    }
}
