using System;
using ContactBookService.CommonComponents;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactBookService.BusinessClasses.Common
{
    public class RADHIKA_CUSTOMER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "RADHIKA_CUSTOMER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("RADHIKA_CUSTOMER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class RADHIKA_CUSTOMER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "RADHIKA_CUSTOMER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("RADHIKA_CUSTOMER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
}