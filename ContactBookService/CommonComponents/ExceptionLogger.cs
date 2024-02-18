using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactBookService.CommonComponents
{
    public class ExceptionLogger
    {
        public static void LogExceptions(string MethodName, Exception ex)
        {
            try
            {
                string InputXml;
                InputXml = "<SERVICERESPONSE><RESPONSECODE>-2</RESPONSECODE><RESPONSEMESSAGE>[METHOD] " + MethodName +
                           ", [MESSAGE]" + ex.Message +
                           ", [STACKTRACE] " + ex.StackTrace +
                           ", [INNEREXCEPTION] " + ex.InnerException + "</RESPONSEMESSAGE></SERVICERESPONSE>";

                GetXmlData xmlData = new GetXmlData();

                xmlData.GetResponseXml(InputXml, "ERROR_SERVICE_LOG");
            }
            catch { }
        }
        public static string GetExceptionsDetails(string Methodname, Exception ex)
        {
            try
            {
                string InputXml;
                InputXml = "<SERVICERESPONSE><RESPONSECODE>-2</RESPONSECODE><RESPONSEMESSAGE>[METHOD] " + Methodname +
                           ", [MESSAGE]" + ex.Message + 
                           ", [STACKTRACE] " + ex.StackTrace +
                           ", [INNEREXCEPTION] " + ex.InnerException + "</RESPONSEMESSAGE></SERVICERESPONSE>";

                return InputXml;
            }
            catch (Exception exce)
            {
                return "<SERVICERESPONSE><RESPONSECODE>-2</RESPONSECODE><RESPONSEMESSAGE>GetExceptionDetails error: " + exce.Message + "</RESPONSEMESSAGE>";
            }

        }
    }
}