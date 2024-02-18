using ContactBookService.CommonComponents;
using CrystalDecisions.Shared;
using Newtonsoft.Json;
using Razorpay.Api;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using ZXing;
namespace ContactBookService.BusinessClasses.Common
{
    public class E_Invoice_Cancel
    {
        public string invoice_id;
        public string service_name;
        public string QRImg_name;


        //private string EINVOICE_URL = System.Configuration.ConfigurationManager.AppSettings["EINVOICE_URL"];
        //private string Authorization = System.Configuration.ConfigurationManager.AppSettings["Authorization"];
        //private string username = doc.SelectSingleNode("SERVICERESPONSE/USERNAME";
        //private string password = System.Configuration.ConfigurationManager.AppSettings["password"];
        //private string gstin = System.Configuration.ConfigurationManager.AppSettings["gstin"];

        public BothResponse GetResponseXml_EINVOICE(string ResponseXml)
        {

            XmlDocument docs = new XmlDocument();
            docs.LoadXml(ResponseXml);

            string username = "";
            string password = "";
            string gstin = "";
            string EINVOICE_URL = "";
            string Authorization = "";

            EINVOICE_URL = System.Configuration.ConfigurationManager.AppSettings["EINVOICE_CANCLE_URL"];
            username = docs.SelectSingleNode("SERVICERESPONSE/USERNAME").InnerText;
            password = docs.SelectSingleNode("SERVICERESPONSE/PASSWORD").InnerText;
            gstin = docs.SelectSingleNode("SERVICERESPONSE/FROMGSTIN").InnerText;
            Authorization = System.Configuration.ConfigurationManager.AppSettings["Authorization"];

            string Outputxml = "";
            string Finalresponse = "";
            BothResponse BothResponse = new BothResponse();
            try
            {
                string url = EINVOICE_URL;
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(ResponseXml);

                if (doc.SelectSingleNode("SERVICERESPONSE/INVOICEID") != null)
                {
                    invoice_id = doc.SelectSingleNode("SERVICERESPONSE/INVOICEID").InnerText;
                }

                if (doc.SelectSingleNode("SERVICERESPONSE/SERVICENAME") != null)
                {
                    service_name = doc.SelectSingleNode("SERVICERESPONSE/SERVICENAME").InnerText;
                }

                if (doc.SelectSingleNode("SERVICERESPONSE/INVOICEIMGNAME") != null)
                {
                    QRImg_name = doc.SelectSingleNode("SERVICERESPONSE/INVOICEIMGNAME").InnerText;
                }
                

                if (doc.SelectSingleNode("SERVICERESPONSE/RESPONSECODE") != null)
                {
                    if (doc.SelectSingleNode("SERVICERESPONSE/RESPONSECODE").InnerText != "0")
                    {
                        BothResponse.org_res = Finalresponse;
                        BothResponse.xml_res = doc.InnerXml;
                        return BothResponse;
                    }
                }

                string RequestId = "";
                if (doc.SelectSingleNode("SERVICERESPONSE/REQUESTID") != null)
                {
                    RequestId = doc.SelectSingleNode("SERVICERESPONSE/REQUESTID").InnerText;
                }
                StringBuilder CT_Request = new StringBuilder();

                XmlNodeList CT_Method;
                CT_Method = doc.SelectNodes("/SERVICERESPONSE/DETAILS");

                if (CT_Method != null)
                {
                    foreach (XmlNode node1 in CT_Method)
                    {
                        CT_Request.Append(node1.InnerXml);
                    }
                }

                XmlDocument CT_doc = new XmlDocument();
                XmlDocumentFragment CT_frag_Request = CT_doc.CreateDocumentFragment();
                CT_frag_Request.InnerXml = CT_Request.ToString();

                string jsoninput = "";
                jsoninput = JsonConvert.SerializeXmlNode(CT_frag_Request);
                //EInvoice_Node transactObject2 = JsonConvert.DeserializeObject<EInvoice_Node>(jsoninput);
                //var jsonString = JsonConvert.SerializeObject(transactObject2);

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                var client = new RestSharp.RestClient(url);
                client.Timeout = -1;

                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", Authorization);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("user_name", username);
                request.AddHeader("password", password);

                request.AddHeader("gstin", doc.SelectSingleNode("SERVICERESPONSE/FROMGSTIN").InnerText);
                //request.AddHeader("gstin", gstin);
                request.AddHeader("requestid", RequestId);
                request.AddParameter("application/json", jsoninput, RestSharp.ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);
                Finalresponse = response.Content;
                XmlDocument Err_doc = new XmlDocument();
                Err_doc.LoadXml("<SERVICERESPONSE></SERVICERESPONSE>");

                if (Finalresponse == "")
                {
                    XmlNode err_elem = Err_doc.CreateNode(XmlNodeType.Element, "RESPONSECODE", null);
                    err_elem.InnerText = "-1";
                    Err_doc.DocumentElement.AppendChild(err_elem);

                    err_elem = Err_doc.CreateNode(XmlNodeType.Element, "RESPONSEMESSAGE", null);
                    err_elem.InnerText = "No Response from ClearTax, Please try again later.";
                    Err_doc.DocumentElement.AppendChild(err_elem);

                    Outputxml = Err_doc.InnerXml;
                    BothResponse.org_res = Finalresponse;
                    BothResponse.xml_res = Outputxml;
                    return BothResponse;
                }

                XmlDocument xdoc = JsonConvert.DeserializeXmlNode("{\"SERVICERESPONSE\":" + Finalresponse + "}");

                if (xdoc.SelectSingleNode("SERVICERESPONSE//success") != null)
                {
                    XmlNode res_elem = Err_doc.CreateNode(XmlNodeType.Element, "RESPONSECODE", null);
                    if (xdoc.SelectSingleNode("SERVICERESPONSE//success").InnerText == "true")
                    {
                        res_elem.InnerText = "0";
                    }
                    else
                    {
                        res_elem.InnerText = "-1";
                    }
                    Err_doc.DocumentElement.AppendChild(res_elem);

                    res_elem = Err_doc.CreateNode(XmlNodeType.Element, "RESPONSEMESSAGE", null);
                    res_elem.InnerText = "success : " + xdoc.SelectSingleNode("SERVICERESPONSE//success").InnerText;
                    Err_doc.DocumentElement.AppendChild(res_elem);

                    if (xdoc.SelectSingleNode("SERVICERESPONSE//message") != null)
                    {
                        res_elem = Err_doc.CreateNode(XmlNodeType.Element, "MESSAGE", null);
                        res_elem.InnerText = xdoc.SelectSingleNode("SERVICERESPONSE//message").InnerText;
                        Err_doc.DocumentElement.AppendChild(res_elem);
                    }

                    if (xdoc.SelectSingleNode("SERVICERESPONSE//result//ewayBillNo") != null)
                    {
                        res_elem = Err_doc.CreateNode(XmlNodeType.Element, "EWAYBILLNO", null);
                        res_elem.InnerText = xdoc.SelectSingleNode("SERVICERESPONSE//result//ewayBillNo").InnerText;
                        Err_doc.DocumentElement.AppendChild(res_elem);
                    }
                    if (xdoc.SelectSingleNode("SERVICERESPONSE//result//ewayBillDate") != null)
                    {
                        res_elem = Err_doc.CreateNode(XmlNodeType.Element, "EWAYBILLDATE", null);
                        res_elem.InnerText = xdoc.SelectSingleNode("SERVICERESPONSE//result//ewayBillDate").InnerText;
                        Err_doc.DocumentElement.AppendChild(res_elem);
                    }
                    if (xdoc.SelectSingleNode("SERVICERESPONSE//result//validUpto") != null)
                    {
                        res_elem = Err_doc.CreateNode(XmlNodeType.Element, "VALIDUPTO", null);
                        res_elem.InnerText = xdoc.SelectSingleNode("SERVICERESPONSE//result//validUpto").InnerText;
                        Err_doc.DocumentElement.AppendChild(res_elem);
                    }
                    if (xdoc.SelectSingleNode("SERVICERESPONSE//result//alert") != null)
                    {
                        res_elem = Err_doc.CreateNode(XmlNodeType.Element, "ALERT", null);
                        res_elem.InnerText = xdoc.SelectSingleNode("SERVICERESPONSE//result//alert").InnerText;
                        Err_doc.DocumentElement.AppendChild(res_elem);
                    }

                    Outputxml = Err_doc.InnerXml;
                }
            }
            catch (Exception ex)
            {
                // Preparting Final result XML document and adding result xml in this document
                XmlDocument Err_doc = new XmlDocument();
                Err_doc.LoadXml("<SERVICERESPONSE></SERVICERESPONSE>");

                // Creating service responsecode and response message node to the document
                XmlNode err_elem = Err_doc.CreateNode(XmlNodeType.Element, "RESPONSECODE", null);
                err_elem.InnerText = "-1";
                Err_doc.DocumentElement.AppendChild(err_elem);

                err_elem = Err_doc.CreateNode(XmlNodeType.Element, "RESPONSEMESSAGE", null);
                err_elem.InnerXml = "<![CDATA[" + ex.Message + ex.StackTrace + "]]>";
                Err_doc.DocumentElement.AppendChild(err_elem);

                Outputxml = Err_doc.InnerXml;
                //return Err_doc.InnerXml;
            }

            XmlDocument node = JsonConvert.DeserializeXmlNode("{\"SERVICERESPONSE\":" + Finalresponse + "}");


            BothResponse.xml_res = "<SERVICERESPONSE><RESPONSECODE>0</RESPONSECODE>" + node.DocumentElement.InnerXml + "</SERVICERESPONSE>"; // Final Response in XML Formate

            //---------------- When Cancle Invoice Then E-Invoice Qr Image Delete ---------------------------------
            //string folderPath = System.Configuration.ConfigurationManager.AppSettings["QRCodeSave"]; 
            //string fileName = QRImg_name;
            //string imagePath = folderPath + fileName;
            //File.Delete(imagePath);
            //----------------/ When Cancle Invoice Then E-Invoice Qr Image Delete ---------------------------------


            string XMLValue;

            XMLValue = "<SERVICEREQUEST><SERVICENAME>" + service_name + "</SERVICENAME>" +
                       "<INVOICEID>" + invoice_id + "</INVOICEID>" +
                       "<CANCELDATE>" + node.SelectSingleNode("SERVICERESPONSE//result//CancelDate").InnerText + "</CANCELDATE>" +
                       "<CANCELIRN>" + node.SelectSingleNode("SERVICERESPONSE//result//Irn").InnerText + "</CANCELIRN>" +
                       "</SERVICEREQUEST>";

            string FinalXml;
            FinalXml = XMLValue;

            GetXmlData xmlData = new GetXmlData();
            FinalXml = xmlData.GetResponseXml(XMLValue, service_name);

            return BothResponse;
        }
    }
}