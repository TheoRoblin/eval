using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.UnitTest
{
    [TestClass]
    public class PhoneNumberTest
    {
        private PhoneNumber _number;
        [TestInitialize]
        public void Init()
        {
            _number = PhoneNumber.Parse("0123456789");
        }

        [TestMethod]

        public void PhoneNumber_IsNullOrGetWhiteSpace_ThrowException()
        {
            string number = "     ";
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(number));
        }

        [TestMethod]
        public void PhoneNumber_LenghtIsInvalide_ThrowException()
        {
            string number = "132136";
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(number));
        }

        [TestMethod]
        public void Parse_ValidPhoneNumber_ReturnsPhoneNumberObject()
        {
            Assert.IsNotNull(_number);
            Assert.AreEqual("012", _number.Area);
            Assert.AreEqual("345", _number.Major);
            Assert.AreEqual("6789", _number.Minor);
        }

        [TestMethod]
        public void ToString_ValidFormatPhoneNumber_ReturnsFormattedPhoneNumberString()
        {
            string formattedNumber = _number.ToString();
            Assert.AreEqual("(012)345-6789", formattedNumber);
        }
    }
}
