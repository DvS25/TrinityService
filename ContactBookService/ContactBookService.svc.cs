using ContactBookService.CommonComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace ContactBookService
{

    public class ContactBookServices : IContactBook_Interface
    {

        public string PERFORM_ACTIONS(string ACTION_REQUEST)
        {
            string response = string.Empty;
            try
            {
                string MethodDetails = ExtractXml.getNodeValues(ACTION_REQUEST, "SERVICENAME");
                response = PerformSpecifiedAction.InvokeMethods(Convert.ToString(MethodDetails), ACTION_REQUEST);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(response);
                if (doc.SelectSingleNode("SERVICERESPONSE//RESPONSECODE").InnerText == "0")
                {
                    if (doc.SelectSingleNode("SERVICERESPONSE//SMSSENTLIST") != null)
                    {
                        XmlNodeList nodes;
                        nodes = doc.SelectNodes("SERVICERESPONSE//SMSSENTLIST//SMSLIST//SMS");
                        foreach (XmlNode node in nodes)
                        {
                           
                                if (node["SMSTO"].InnerText != null && node["BODY"].InnerText != null)
                                {
                                   SendSms.SendSMS(node["SMSTO"].InnerText, node["BODY"].InnerText);
                                }
                        }
                    }
                    if (doc.SelectSingleNode("SERVICERESPONSE//RESPONSEMOBILE") != null && doc.SelectSingleNode("SERVICERESPONSE//RESPONSESMSBODY") != null)
                    {
                        if (doc.SelectSingleNode("SERVICERESPONSE//RESPONSEMOBILE").InnerText != null && doc.SelectSingleNode("SERVICERESPONSE//RESPONSESMSBODY").InnerText != null)
                        {
                            SendSms.SendSMS(doc.SelectSingleNode("SERVICERESPONSE//RESPONSEMOBILE").InnerText, doc.SelectSingleNode("SERVICERESPONSE//RESPONSESMSBODY").InnerText);
                        }
                    }
                    if (doc.SelectSingleNode("SERVICERESPONSE//RESPONSEMOBILEB2C") != null && doc.SelectSingleNode("SERVICERESPONSE//RESPONSESMSBODYB2C") != null)
                    {
                        if (doc.SelectSingleNode("SERVICERESPONSE//RESPONSEMOBILEB2C").InnerText != null && doc.SelectSingleNode("SERVICERESPONSE//RESPONSESMSBODYB2C").InnerText != null)
                        {
                            SendSms.SendSMS(doc.SelectSingleNode("SERVICERESPONSE//RESPONSEMOBILEB2C").InnerText, doc.SelectSingleNode("SERVICERESPONSE//RESPONSESMSBODYB2C").InnerText);
                        }
                        XmlNode node1 = doc.SelectSingleNode("SERVICERESPONSE//RESPONSESMSBODYB2C");
                        // if found....
                        if (node1 != null)
                        {
                            // get its parent node
                            XmlNode parent = node1.ParentNode;
                            // remove the child node
                            parent.RemoveChild(node1);
                            response = doc.OuterXml;
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                response = ExceptionLogger.GetExceptionsDetails("PERFORM_ACTIONS: ", ex);
            }
            return response;
        }
    }
}   
