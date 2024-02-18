using System;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;


namespace ContactBookService.CommonComponents
{
    public class SendSms
    {
        public static string SendSMS(string mobileNos, string body)
        {
            string status = "";
            string url = "";
            if (mobileNos != "" && mobileNos != null)
            {

                url = "http://www.smsidea.co.in/SmsStatuswithId.aspx?mobile=9879147206&pass=9879147206&senderid=TRINIT&to=" + mobileNos + "&msg=" + body;

                try
                {
                    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    Stream stream = response.GetResponseStream();
                    // status = stream.ToString();
                    status = response.StatusCode.ToString();
                }
                catch (Exception e) 
                {
                    status = e.Message.ToString();
                }
                return status;
            }
            return status;

        }
    }
}