using EvaluationSampleCode;
namespace SampleCode.UnitTest
{
    [TestClass]
    public class HtmlFormatHelperTest
    {
        private HtmlFormatHelper _helper;

        [TestInitialize]
        public void Init()
        {
            _helper = new HtmlFormatHelper();
        }


        [TestMethod]
        public void GetBoldFormat_ValueIsBold_ResulatBold()
        {
            string text = $"TextEnGras";
            Assert.AreEqual(_helper.GetStrongFormat(text), $"<strong>{text}</strong>");
        }

        [TestMethod]
        public void GetItalicFormat_ValueIsItalic_ResulatItalic()
        {
            string text = $"TextEnItalic";
            Assert.AreEqual(_helper.GetItalicFormat(text), $"<i>{text}</i>");
        }

        [TestMethod]
        public void GetFormatedListElements_ListIsFormated_ReturnFormatedList()
        {
            List<string> list = new List<string>();
            list.Add("TextListe");
            Assert.AreEqual(_helper.GetFormattedListElements(list), $"<ul><li>TextListe</li></ul>");
        }
    }
}
