using NUnit.Framework;
using UserRegistrationRegex;

namespace UnitTestUserRegistration
{
    public class Tests
    {
        ValidationRegex regexval;
        [SetUp]
        public void Setup()
        {
            regexval = new ValidationRegex();
        }

        [Test]
        [TestCase("Sagar")]


        public void TestName(string inputOne)
        {

            bool outputOne = regexval.ValidateFirstName(inputOne);
            Assert.IsTrue(outputOne);

        }

        [Test]
        [TestCase("7506074980")]

        public void TestNumbner(string inputTwo)
        {

            bool outputTwo = regexval.ValidateMobileNumber(inputTwo);
            Assert.IsFalse(outputTwo);
        }

        [Test]
        [TestCase("sagar123@gmail.com")]
        public void TestEmail(string inputThree)
        {
            bool outputThree = regexval.validateEmail(inputThree);
            Assert.IsTrue(outputThree);
        }

        [Test]
        [TestCase("Morningstar123#")]
        public void TestPassword(string inputFour)
        {
            bool outputFour = regexval.ValidatePassword(inputFour);
            Assert.IsFalse(outputFour);
        }

    }
}