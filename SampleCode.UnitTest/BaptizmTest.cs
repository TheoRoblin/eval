using EvaluationSampleCode;

namespace SampleCode.UnitTest
{
    [TestClass]
    public class BaptizmTest
    {
        private Baptizm _baptizm;

        [TestMethod]
        public void CanBeBaptizedBy_ClergyMemberIsPriest_ReturnTrue()
        {
            ClergyMember clergyMember = new ClergyMember();
            clergyMember.IsPriest = true;
            _baptizm = new Baptizm(clergyMember);
            Assert.AreEqual(true, _baptizm.CanBeBaptizedBy(clergyMember));
        }

        [TestMethod]
        public void CanBeBaptizedBy_ClergyMemberIsNotPriest_ReturnFalse()
        {
            ClergyMember clergyMember = new ClergyMember();
            clergyMember.IsPriest = false;
            _baptizm = new Baptizm(clergyMember);
            Assert.AreEqual(false, _baptizm.CanBeBaptizedBy(clergyMember));
        }

        [TestMethod]
        public void CanBeBaptizedBy_ClergyMemberIsPope_ReturnTrue()
        {
            ClergyMember clergyMember = new ClergyMember();
            clergyMember.IsPope = true;
            _baptizm = new Baptizm(clergyMember);
            Assert.AreEqual(true, _baptizm.CanBeBaptizedBy(_baptizm.ClergyMember));
        }

        [TestMethod]
        public void CanBeBaptizedBy_ClergyMemberIsNotPope_ReturnFalse()
        {
            ClergyMember clergyMember = new ClergyMember();
            clergyMember.IsPope = false;
            _baptizm = new Baptizm(clergyMember);
            Assert.AreEqual(false, _baptizm.CanBeBaptizedBy(_baptizm.ClergyMember));
        }

        [TestMethod]
        public void CanBeBaptizedBy_clergyMemberIsNeither_ReturnsFalse()
        {
            Baptizm baptizm = new Baptizm(new ClergyMember());
            Assert.IsFalse(baptizm.CanBeBaptizedBy(baptizm.ClergyMember));
        }

        [TestMethod]
        public void CanByTeachBy_ClergyMemberIsCreate_ReturnTrue()
        {
            Baptizm baptizm = new Baptizm(new ClergyMember());
            Assert.IsTrue(baptizm.CanBeTeachedBy(baptizm.ClergyMember));
        }

        [TestMethod]
        public void CanByTeachBy_ClergyMemberIsNotCreate_ReturnFalse()
        {
            Baptizm baptizm = new Baptizm(null);
            Assert.IsFalse(baptizm.CanBeTeachedBy(new ClergyMember()));
        }
    }
}