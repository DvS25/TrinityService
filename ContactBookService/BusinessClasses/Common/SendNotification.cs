using System;
using ContactBookService.CommonComponents;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Net;
using System.Web.Script.Serialization;
using System.Text;
using System.IO;



namespace ContactBookService.BusinessClasses.Common
{
    public class SendNotification
    {
        public static string Notification(string InputXml)
        {
            string app_id = "";
            string Heading = "";
            string Content = "";
            string image = "";
            string Loginid = "";
            string Securekey = "";
            string Signalnotificationid = "";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(InputXml);

            Heading = doc.SelectSingleNode("SERVICEREQUEST//HEADER").InnerText;
            Content = doc.SelectSingleNode("SERVICEREQUEST//CONTENT").InnerText;
            Loginid = doc.SelectSingleNode("SERVICEREQUEST//LOGINID").InnerText;
            Securekey = doc.SelectSingleNode("SERVICEREQUEST//SECUREKEY").InnerText;
            Signalnotificationid = doc.SelectSingleNode("SERVICEREQUEST//SIGNALNOTIFICATIONID").InnerText;

            if (doc.SelectSingleNode("SERVICEREQUEST//IMAGE").InnerText != null && doc.SelectSingleNode("SERVICEREQUEST//IMAGE").InnerText != "")
            {
                image = doc.SelectSingleNode("SERVICEREQUEST//IMAGE").InnerText;
            }


            string SERVER_API_KEY = "";
            //string app_id = "";
            //string NotificationId = notificationid;
            //string Heading = heading;
            //string Content = content;
            //string Type = type;

            SERVER_API_KEY = System.Configuration.ConfigurationManager.AppSettings["SERVER_API_KEY"];
            app_id = System.Configuration.ConfigurationManager.AppSettings["app_id"];

            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            var serializer = new JavaScriptSerializer();

            request.Headers.Add("authorization", "Basic " + SERVER_API_KEY);

            var obj = new
            {
                app_id = app_id,
                headings = new { en = Heading },
                contents = new { en = Content },
                big_picture = image,
                small_icon = "onlylogo_black",
                included_segments = new string[] { "All" }
                //include_player_ids = new string[] { "b03b4b0e-7dc6-481f-9c74-fcc0422b5200" }
            };
            var param = serializer.Serialize(obj);

            byte[] byteArray = Encoding.UTF8.GetBytes(param);
            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
            }
            string Result = "";
            try
            {
                string FinalXml = string.Empty,
                       xmlnodes = string.Empty,
                       XMLValue = string.Empty;

                xmlnodes += "<LOGINID>" + Loginid + "</LOGINID>";
                xmlnodes += "<USERTYPE>SalesExecutive</USERTYPE>";
                xmlnodes += "<SECUREKEY>" + Securekey + "</SECUREKEY>";
                xmlnodes += "<SIGNALNOTIFICATIONID>" + Signalnotificationid + "</SIGNALNOTIFICATIONID>";
                xmlnodes += "<oper>add</oper>";


                FinalXml = "<SERVICEREQUEST>" + xmlnodes + "<SERVICENAME>B2C_SIGNALNOTIFICATION_HISTORY_CRUD</SERVICENAME></SERVICEREQUEST>";
                XMLValue = PerformSpecifiedAction.InvokeMethods("B2C_SIGNALNOTIFICATION_HISTORY_CRUD", FinalXml);

                XmlDocument doc1 = new XmlDocument();
                doc1.LoadXml(XMLValue);

                Result = XMLValue;
            }
            catch (Exception ex)
            {
                Result = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + ex.Message.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
            }
            return Result;
        }
    }
}