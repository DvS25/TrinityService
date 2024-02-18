using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace ContactBookService.CommonComponents
{
    public class ExtractXml
    {
        public static string getNodeValues(string xmlString, string nodeName)
        {
            string NodeValue = string.Empty;
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(xmlString);
                XmlNodeList nodeList = xml.GetElementsByTagName(nodeName);
                if (nodeList != null)
                {
                    foreach (XmlNode node in nodeList)
                    {
                        NodeValue = node.InnerText;
                    }
                }
                else
                {
                    throw new ArgumentNullException("Specified node doesn't exists");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return NodeValue;
        }
    }
}