using Newtonsoft.Json;
using System.Xml;


namespace ClassLibrary1
{
    public class XmlToJsonConverter : IXmlToJsonConverter
    {
        public string ConvertXmlToJson(string xmlInput)
        {
            string jsonText;
            XmlDocument doc = new XmlDocument();

           try
           {
                doc.LoadXml(xmlInput);
           }catch(XmlException xmlException)
           {
                jsonText = "Bad Xml format";
                return jsonText;
           }
           
            jsonText = JsonConvert.SerializeXmlNode(doc);
            
            return jsonText;
        }
    }
}
