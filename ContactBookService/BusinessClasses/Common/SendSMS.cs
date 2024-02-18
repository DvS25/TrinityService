using ContactBookService.CommonComponents;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Xml;

namespace ContactBookService.BusinessClasses.Common
{
    public class SendSMS
    {

        public static string StartProcess(string inputxml)
        {
            string Language = string.Empty, SmsBody = string.Empty, response = string.Empty, XMLValue = string.Empty
                , EmailUserType, UserGroups = string.Empty, MobileNoList = string.Empty;
            int totSMS = 0, NewsLetterSMSId = 0, City = 0, State = 0, Country = 0;
            bool IsComplete = false;

            try
            {
                EmailUserType = Convert.ToString(ExtractXml.getNodeValues(inputxml, "EMAILUSERTYPE"));
                if (ExtractXml.getNodeValues(inputxml, "USERGROUPS") != "")
                {
                    UserGroups = Convert.ToString(ExtractXml.getNodeValues(inputxml, "USERGROUPS"));
                }
                if (ExtractXml.getNodeValues(inputxml, "CITY") != "")
                {
                    City = Convert.ToInt32(ExtractXml.getNodeValues(inputxml, "CITY"));
                }

                if (ExtractXml.getNodeValues(inputxml, "STATE") != "")
                {
                    State = Convert.ToInt32(ExtractXml.getNodeValues(inputxml, "STATE"));
                }

                if (ExtractXml.getNodeValues(inputxml, "COUNTRY") != "")
                {
                    Country = Convert.ToInt32(ExtractXml.getNodeValues(inputxml, "COUNTRY"));
                }

                response = PerformSpecifiedAction.InvokeMethods("SMSDEMO_PUBLISH", inputxml);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(response);

                if (doc.SelectSingleNode("SERVICERESPONSE//RESPONSECODE").InnerText == "0") // USER AUTHENTICATION OK
                {
                    NewsLetterSMSId = Convert.ToInt32(doc.SelectSingleNode("SERVICERESPONSE//NEWSLETTERSMSID").InnerText);
                    Language = Convert.ToString(doc.SelectSingleNode("SERVICERESPONSE//LANGUAGE").InnerText);
                    SmsBody = Convert.ToString(doc.SelectSingleNode("SERVICERESPONSE//SMSBODY").InnerText);

                    if (doc.GetElementsByTagName("NOLIST").Count > 0)
                    {
                        int i = 0;
                        if (doc.GetElementsByTagName("NOLIST")[0].ChildNodes.Count > 0)
                        {
                            int empChunkCount = 10;
                            int counter = 0, threadno = 0;
                            DataSet ds = new DataSet();
                            ds.ReadXml(new XmlTextReader(new StringReader(response)));

                            if (ds.Tables.Count > 1 && ds.Tables["NO"] != null)
                            {
                                totSMS = ds.Tables["NO"].Rows.Count;
                                if (ds.Tables["NO"].Rows.Count > 0)
                                {
                                    int RecTypeIndex = ds.Tables["NO"].Columns["MOBILENO"].Ordinal;

                                    for (i = 0; i < totSMS; i++)
                                    {
                                        if (counter <= empChunkCount)
                                        {
                                            if (Convert.ToString(ds.Tables["NO"].Rows[i].ItemArray[RecTypeIndex]) != "")
                                            {
                                                MobileNoList += ds.Tables["NO"].Rows[i].ItemArray[RecTypeIndex] + ",";
                                            }
                                            counter++;
                                        }                                        

                                        if (counter == empChunkCount || i == (totSMS - 1))
                                        {
                                            threadno++;

                                            MobileNoList = MobileNoList.Substring(0, MobileNoList.Length - 1);
                                            CommonSMSSend obj = new CommonSMSSend();
                                            obj.prop_smstemplateid = NewsLetterSMSId;
                                            obj.prop_lang = Language;
                                            obj.prop_mobilenolist = MobileNoList;
                                            obj.prop_smsbody = SmsBody;
                                            obj.prop_iscomplete = IsComplete;
                                            ThreadPool.QueueUserWorkItem(ProcessEnd, obj); // call thread
                                            counter = 0;
                                            MobileNoList = "";
                                        }

                                        if (i == (totSMS - 1))
                                        {
                                            try
                                            {
                                                string XMLValue1 = string.Empty;
                                                XMLValue1 = "<SERVICEREQUEST><SERVICENAME>SMSDEMO_PUBLISH</SERVICENAME>";
                                                XMLValue1 += "<oper>edit</oper><ISCOMPLETE>1</ISCOMPLETE>";
                                                XMLValue1 += "<NEWSLETTERSMSID>" + NewsLetterSMSId + "</NEWSLETTERSMSID>";                                                
                                                XMLValue1 += "<SMSKEY>SMSKEY-49239338-C97D-44B8-807E-5C055AA21AEE</SMSKEY>";
                                                XMLValue1 += "</SERVICEREQUEST>";
                                                XMLValue1 = PerformSpecifiedAction.InvokeMethods("SMSDEMO_PUBLISH", XMLValue1);
                                            }
                                            catch (Exception ex)
                                            {
                                                ex.ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    XMLValue = "<SERVICERESPONSE><RESPONSECODE>0</RESPONSECODE><RESPONSEMESSAGE>" + doc.SelectSingleNode("SERVICERESPONSE//RESPONSEMESSAGE").InnerText.ToString() + "</RESPONSEMESSAGE><NEWSLETTERSMSID>" + doc.SelectSingleNode("SERVICERESPONSE//NEWSLETTERSMSID").InnerText.ToString() + "</NEWSLETTERSMSID></SERVICERESPONSE>";
                }
                else
                {
                    SMSPublishError(NewsLetterSMSId, doc.SelectSingleNode("SERVICERESPONSE//RESPONSEMESSAGE").InnerText.ToString());
                    XMLValue = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + doc.SelectSingleNode("SERVICERESPONSE//RESPONSEMESSAGE").InnerText.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
                }
            }
            catch (Exception ex)
            {
                SMSPublishError(NewsLetterSMSId, ex.StackTrace.ToString());
                XMLValue = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + ex.StackTrace.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
            }
            return XMLValue;
        }
        public static void SMSPublishError(int NewsLetterSMSId,string ErrorMeassge)
        {
            try
            {
                string XMLValue = string.Empty;
                XMLValue = "<SERVICEREQUEST><SERVICENAME>SMSDEMO_PUBLISH</SERVICENAME>";
                XMLValue += "<oper>edit</oper>";
                XMLValue += "<NEWSLETTERSMSID>" + NewsLetterSMSId + "</NEWSLETTERSMSID>";
                XMLValue += "<ERRORMEASSGE>" + ErrorMeassge + "</ERRORMEASSGE>";
                XMLValue += "<SMSKEY>SMSKEY-49239338-C97D-44B8-807E-5C055AA21AEE</SMSKEY>";
                XMLValue += "</SERVICEREQUEST>";
                XMLValue = PerformSpecifiedAction.InvokeMethods("SMSDEMO_PUBLISH", XMLValue);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public static void ProcessEnd(object Obj)
        {
            CommonSMSSend threadobj = (CommonSMSSend)Obj;
            try
            {
                SendSMSMethod(threadobj.prop_smstemplateid,threadobj.prop_mobilenolist, threadobj.prop_lang, threadobj.prop_smsbody, threadobj.prop_iscomplete);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public static void SendSMSMethod(int NewsLetterSMSId, string mobileNos, string lang, string body,bool IsComplete)
        {            
            string url = "";
            string FromMobileNo = System.Configuration.ConfigurationManager.AppSettings["FromMobileNo"];
            string Pass = System.Configuration.ConfigurationManager.AppSettings["Password"];
            string SenderId = System.Configuration.ConfigurationManager.AppSettings["SenderId"];           

            if (mobileNos != "" && mobileNos != null)
            {
                if (lang == "EN")
                {
                    url = "http://www.smsidea.co.in/SmsStatuswithId.aspx?restype=xml/json&mobile="+ FromMobileNo + "&pass="+ Pass + "&senderid="+ SenderId + "&to=" + mobileNos + "&msg=" + body;
                }
                else
                {
                    url = "http://www.smsidea.co.in/SmsStatuswithId.aspx?restype=xml/json&mobile=" + FromMobileNo + "&pass=" + Pass + "&senderid=" + SenderId + "&to=" + mobileNos + "&msg=" + body + "&msgtype=uc";
                }

                try
                {
                    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    Stream stream = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream);
                    string json = sr.ReadToEnd();
                    sr.Close();

                    if (json.Contains("error") == true)
                    {
                        SMSSendCrud(NewsLetterSMSId, mobileNos, body, null, json, IsComplete);
                    }
                    else
                    {
                        SMSSendCrud(NewsLetterSMSId, mobileNos, body, json, null, IsComplete);
                    } 
                }
                catch (Exception e)
                {                   
                    SMSSendCrud(NewsLetterSMSId, mobileNos, body, null, e.Message.ToString(), IsComplete);
                }
            }
            else
            {
                SMSSendCrud(NewsLetterSMSId, mobileNos, body, null, "No Mobile No.", IsComplete);
            }           
        }

        public static void SMSSendCrud(int NewsLetterSMSId, string mobileNos, string body, string responsemsg, string errormsg,bool IsComplete)
        {
            try
            {
                string XMLValue = string.Empty;
                XMLValue = "<SERVICEREQUEST><SERVICENAME>SMSSENT_RESPONSE_CRUD</SERVICENAME>";
                XMLValue += "<oper>add</oper>";
                XMLValue += "<NEWSLETTERSMSID>" + NewsLetterSMSId + "</NEWSLETTERSMSID>";
                XMLValue += "<SMSTO>" + mobileNos + "</SMSTO>";
                XMLValue += "<SMSBODY>" + body + "</SMSBODY>";
                XMLValue += "<SMSKEY>SMSKEY-49239338-C97D-44B8-807E-5C055AA21AEE</SMSKEY>";
             
                if (responsemsg != null)
                {
                    XMLValue += "<RESPONSEMESSAGE>" + responsemsg + "</RESPONSEMESSAGE>";
                }
                if (errormsg != null)
                {
                    XMLValue += "<ERRORMESAAGE>" + errormsg + "</ERRORMESAAGE>";
                }
                XMLValue += "</SERVICEREQUEST>";
                XMLValue = PerformSpecifiedAction.InvokeMethods("SMSSENT_RESPONSE_CRUD", XMLValue);              
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public class CommonSMSSend
        {
            //------------------- Local variable declaration use for method which goes in threading 
            private int SMSTemplateId;
            private string MobileNoList;
            private string SMSBody;
            private string Lang;
            private bool IsComplete;

            //------------------- All property of local varible ----------------------------------         

            public int prop_smstemplateid
            {
                get { return SMSTemplateId; }
                set { SMSTemplateId = value; }
            }
            public string prop_mobilenolist
            {
                get { return MobileNoList; }
                set { MobileNoList = value; }
            }
            public string prop_smsbody
            {
                get { return SMSBody; }
                set { SMSBody = value; }
            }
            public string prop_lang
            {
                get { return Lang; }
                set { Lang = value; }
            }
            public bool prop_iscomplete
            {
                get { return IsComplete; }
                set { IsComplete = value; }
            }
        }
    }
}