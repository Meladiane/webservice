using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void Trivial_Test()
        {

            int expected = 5;
            Assert.AreEqual(expected, 2+3);
        }

        [TestMethod]
        public void When_Format_Is_Valid_Must_Return_JSON_Format()
        {

            string expected = "{\"foo\":\"bar\"}";
            string xmlInput = "<foo>bar</foo>";
            string actual = new XmlToJsonConverter().ConvertXmlToJson(xmlInput);


           Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void When_Format_Is_Not_Valid_Must_Return_Bad_Xml_format()
        {

            string expected = "Bad Xml format";
            string xmlInput = "<foo>hello</bar>";
            string actual = new XmlToJsonConverter().ConvertXmlToJson(xmlInput);


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_Format_Is_Valid_Must_Return_JSON_format()
        {

            string expected = "{\"TRANS\":{\"HPAY\":{\"ID\":\"103\",\"STATUS\":\"3\",\"EXTRA\":{\"IS3DS\":\"0\",\"AUTH\":\"031183\"},\"INT_MSG\":null,\"MLABEL\":\"501767XXXXXX6700\",\"MTOKEN\":\"project01\"}}}";
            string xmlInput = "<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>";
            string actual = new XmlToJsonConverter().ConvertXmlToJson(xmlInput);


            Assert.AreEqual(expected, actual);

        }
    }
}