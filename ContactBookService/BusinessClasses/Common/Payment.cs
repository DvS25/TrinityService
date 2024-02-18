using System;
using ContactBookService.CommonComponents;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Net;
using Razorpay.Api;

namespace ContactBookService.BusinessClasses.Common
{
    public class Payment
    {
        public static string TranscationId;
        public static int LoginId = 0;
        public static string Key = System.Configuration.ConfigurationManager.AppSettings["RazorpayKey"];
        public static string Secret = System.Configuration.ConfigurationManager.AppSettings["RazorpaySecretKey"];
        public static string InvoiceNo;
        public static string PaymentData = "";

        public static string DoPayment(string InputXml)
        {
            string Responsedata = "";
            try
            {
                InputXml = PerformSpecifiedAction.InvokeMethods("B2C_CART_GET", InputXml);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(InputXml);

                if (doc.SelectSingleNode("SERVICERESPONSE//RESPONSECODE").InnerText == "0")
                {
                    try
                    {
                        InvoiceNo = doc.SelectSingleNode("SERVICERESPONSE//CUSTOMERDETAIL//INVOICENO").InnerText;
                        string FullName = doc.SelectSingleNode("SERVICERESPONSE//CUSTOMERDETAIL//CONTACTPERSONNAME").InnerText;
                        string Phone = doc.SelectSingleNode("SERVICERESPONSE//CUSTOMERDETAIL//MOBILENO").InnerText;
                        string Email = doc.SelectSingleNode("SERVICERESPONSE//CUSTOMERDETAIL//EMAILID").InnerText;
                        string Address = doc.SelectSingleNode("SERVICERESPONSE//CUSTOMERDETAIL//FULLADDRESS").InnerText;
                        string CurrencyCode = "INR";
                        if (doc.SelectSingleNode("SERVICERESPONSE//TOTALPRICELIST//CURRENCYCODE") != null)
                        {
                            CurrencyCode = doc.SelectSingleNode("SERVICERESPONSE//TOTALPRICELIST//CURRENCYCODE").InnerText;
                        }

                        decimal TotalAmount = Convert.ToInt32(Convert.ToDecimal(doc.SelectSingleNode("SERVICERESPONSE//TOTALPRICELIST//FINALAMOUNT").InnerText) * 100);
                        string Image = "/Content/BlackBackground.png";
                        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        Dictionary<string, object> input = new Dictionary<string, object>();
                        input.Add("amount", TotalAmount); // this amount should be same as transaction amount
                        input.Add("currency", CurrencyCode);
                        input.Add("receipt", InvoiceNo);
                        input.Add("payment_capture", 1);

                        RazorpayClient client = new RazorpayClient(Key, Secret);
                        Razorpay.Api.Order order = client.Order.Create(input);
                        string TranscationId = order["id"].ToString();

                        var paymentdetail = "<key>" + Key + "</key>" +
                                                "<order_id>" + TranscationId + "</order_id>" +
                                                "<amount>" + TotalAmount + "</amount>" + /* // 2000 paise = INR 20*/
                                                "<currency>INR</currency>" +
                                                "<name>Trinity</name>" +
                                                "<captured>true</captured>" +
                                                "<description>Payment Description</description>" +
                                                "<image>" + Image + "</image>" +
                                                "<contact>" + Phone + "</contact>" +
                                                "<prefill>" + "<name>" + FullName + "</name>" +
                                                           "<email>" + Email + "</email>" +
                                                           "<contact>" + Phone + "</contact></prefill>" +
                                                "<notes><address>" + Address + "</address>" +
                                                         "</notes>";

                        Responsedata = "<SERVICERESPONSE><RESPONSECODE>0</RESPONSECODE><RESPONSEMESSAGE>Success</RESPONSEMESSAGE><PAYMENTDETAIL>" + paymentdetail + "</PAYMENTDETAIL></SERVICERESPONSE>";
                    }
                    catch (Exception ex)
                    {
                        Responsedata = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + ex.Message.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
                    }

                }
                else
                {
                    Responsedata = doc.OuterXml;
                }

            }
            catch (Exception ex)
            {
                Responsedata = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + ex.Message.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
            }
            return Responsedata;
        }
        public static string GetAndSavePaymentDetail(string InputXml)
        {
            int TranscationAmount = 0;
            string Responsedata = "";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(InputXml);

            string PaymentId = doc.SelectSingleNode("SERVICEREQUEST//PAYMENTID").InnerText;
            string CustomerId = doc.SelectSingleNode("SERVICEREQUEST//CUSTOMERID").InnerText;
            string Securekey = doc.SelectSingleNode("SERVICEREQUEST//SECUREKEY").InnerText;
            string ActivityId = doc.SelectSingleNode("SERVICEREQUEST//ACTIVITYID").InnerText;
            string Remark = doc.SelectSingleNode("SERVICEREQUEST//REMARK").InnerText;
            string CurrencyType = doc.SelectSingleNode("SERVICEREQUEST//CURRENCYCODE").InnerText;

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                RazorpayClient client = new RazorpayClient(Key, Secret);
                Razorpay.Api.Payment payment = client.Payment.Fetch(PaymentId);

                Razorpay.Api.Order order = client.Order.Fetch(payment["order_id"].ToString());
                InvoiceNo = order["receipt"].ToString();
                TranscationAmount = Convert.ToInt32(payment["amount"]);

                if (payment["status"].ToString() == "captured" && payment["error_code"].ToString() == "")
                {
                    Responsedata = InsertPaymentDetails(CustomerId, Securekey, InvoiceNo, TranscationAmount, PaymentId, payment["order_id"].ToString(), payment["status"].ToString(),
                     Convert.ToBoolean(payment["captured"]), payment["method"].ToString(), payment["card_id"].ToString(), payment["bank"].ToString(), payment["wallet"].ToString(), payment["vpa"].ToString(),
                     payment["email"].ToString(), payment["contact"].ToString(), Convert.ToInt32(payment["fee"]), Convert.ToInt32(payment["tax"]), payment["error_code"].ToString()
                     , payment["error_description"].ToString(), "success", ActivityId, Remark, CurrencyType);
                }
                else
                {
                    Responsedata = InsertPaymentDetails(CustomerId, Securekey, InvoiceNo, TranscationAmount, PaymentId, payment["order_id"].ToString(), payment["status"].ToString(),
                     Convert.ToBoolean(payment["captured"]), payment["method"].ToString(), payment["card_id"].ToString(), payment["bank"].ToString(), payment["wallet"].ToString(), payment["vpa"].ToString(),
                     payment["email"].ToString(), payment["contact"].ToString(), Convert.ToInt32(payment["fee"]), Convert.ToInt32(payment["tax"]), payment["error_code"].ToString()
                     , payment["error_description"].ToString(), "Cancel", ActivityId, Remark, CurrencyType);
                }


            }
            catch (Exception ex)
            {
                Responsedata = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + ex.Message.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
            }
            return Responsedata;
        }

        public static string CancelOrderDetails(string InputXml)
        {
            string Responsedata = "", OrderId = "", CustomerId = "", Securekey = "", CurrencyType="INR"; //Remark = ""
            int TranscationAmount = 0;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(InputXml);
            OrderId = doc.SelectSingleNode("SERVICEREQUEST//ORDERID").InnerText;
            CustomerId = doc.SelectSingleNode("SERVICEREQUEST//CUSTOMERID").InnerText;
            Securekey = doc.SelectSingleNode("SERVICEREQUEST//SECUREKEY").InnerText;
            string ActivityId = doc.SelectSingleNode("SERVICEREQUEST//ACTIVITYID").InnerText;
            CurrencyType = doc.SelectSingleNode("SERVICEREQUEST//CURRENCYCODE").InnerText;
            RazorpayClient client = new RazorpayClient(Key, Secret);
            Razorpay.Api.Order order = client.Order.Fetch(OrderId);
            TranscationAmount = Convert.ToInt32(order["amount"]);

            Responsedata = InsertPaymentDetails(CustomerId, Securekey, InvoiceNo, TranscationAmount, "", OrderId, "",
                    false, "", "", "", "", "", "", "", 0, 0, "", "", "Cancel", ActivityId, "", CurrencyType);
            return Responsedata;
        }
        public static string InsertPaymentDetails(string CustomerId, string Securekey, string InvoiceNo, int TranscationAmount, string PaymentId, string order_id, string PaymentStatus,
                     Boolean captured, string method, string card_id, string bank, string wallet, string vpa,
                     string email, string contact, int fee, int tax, string error_code, string error_descriptionstring, string Status, string ActivityId, string Remark, string CurrencyType)
        {
            string Result = "";
            try
            {
                string FinalXml = string.Empty, xmlnodes = string.Empty, XMLValue = string.Empty;

                xmlnodes += "<CUSTOMERID>" + CustomerId + "</CUSTOMERID>";
                xmlnodes += "<SECUREKEY>" + Securekey + "</SECUREKEY>";
                xmlnodes += "<INVOICENO>" + InvoiceNo + "</INVOICENO>";
                xmlnodes += "<TRANSCATIONAMOUNT>" + TranscationAmount + "</TRANSCATIONAMOUNT>";
                xmlnodes += "<RAZORPAYMENTID>" + PaymentId + "</RAZORPAYMENTID>";
                xmlnodes += "<RAZORORDERID>" + order_id + "</RAZORORDERID>";
                xmlnodes += "<PAYMENTSTATUS>" + PaymentStatus + "</PAYMENTSTATUS>";
                xmlnodes += "<CAPTURED>" + captured + "</CAPTURED>";
                xmlnodes += "<PAYMENTMETHOD>" + method + "</PAYMENTMETHOD>";
                xmlnodes += "<CARDID>" + card_id + "</CARDID>";
                xmlnodes += "<BANK>" + bank + "</BANK>";
                xmlnodes += "<WALLET>" + wallet + "</WALLET>";
                xmlnodes += "<VPA>" + vpa + "</VPA>";
                xmlnodes += "<EMAIL>" + email + "</EMAIL>";
                xmlnodes += "<CONTACT>" + contact + "</CONTACT>";
                xmlnodes += "<FEE>" + fee + "</FEE>";
                xmlnodes += "<TAX>" + tax + "</TAX>";
                xmlnodes += "<RAZORERRORCODE>" + error_code + "</RAZORERRORCODE>";
                xmlnodes += "<RAZORERRORDESCRIPTION>" + error_descriptionstring + "</RAZORERRORDESCRIPTION>";
                xmlnodes += "<STATUS>" + Status + "</STATUS>";
                xmlnodes += "<ACTIVITYID>" + ActivityId + "</ACTIVITYID>";
                xmlnodes += "<REMARK>" + Remark + "</REMARK>";
                xmlnodes += "<CURRENCYTYPE>" + CurrencyType + "</CURRENCYTYPE>";


                if (Status == "Cancel")
                {
                    FinalXml = "<SERVICEREQUEST>" + xmlnodes + "<SERVICENAME>B2C_ORDER_PAYMENT_DETAIL_CRUD</SERVICENAME></SERVICEREQUEST>";
                    XMLValue = PerformSpecifiedAction.InvokeMethods("B2C_ORDER_PAYMENT_DETAIL_CRUD", FinalXml);
                }
                else
                {
                    FinalXml = "<SERVICEREQUEST>" + xmlnodes + "<SERVICENAME>B2C_ORDER_CRUD</SERVICENAME></SERVICEREQUEST>";
                    XMLValue = PerformSpecifiedAction.InvokeMethods("B2C_ORDER_CRUD", FinalXml);
                }

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(XMLValue);

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

                    Result = XMLValue;
                }
                else
                {
                    Result = XMLValue;
                }
            }
            catch (Exception ex)
            {
                Result = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + ex.Message.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
            }
            return Result;
        }

    }
}