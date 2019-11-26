using System.Web.Services;
using ClassLibrary1;

namespace WebApplication
{
    /// <summary>
    /// Summary description for ComputationWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ComputationWebService : System.Web.Services.WebService
    {


        [WebMethod]
        public int Fibonacci(int n)
        {
            if (n == 1 || n ==2) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            string result = null;
            XmlToJsonConverter xmlToJsonConverter = new XmlToJsonConverter();
            result = xmlToJsonConverter.ConvertXmlToJson(xml);
            return result;
        }


    }
}
