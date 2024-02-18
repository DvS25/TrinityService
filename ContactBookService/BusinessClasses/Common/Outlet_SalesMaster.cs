using ContactBookService.CommonComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactBookService.BusinessClasses.Common;

namespace ContactBookService.BusinessClasses.Common
{
    public class OUTLET_EMPLOYEE_DETAILS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_EMPLOYEE_DETAILS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_EMPLOYEE_DETAILS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_EMPLOYEE_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_EMPLOYEE_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_EMPLOYEE_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_MASTER_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_MASTER_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_MASTER_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_MASTER_DETAILS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_MASTER_DETAILS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_MASTER_DETAILS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_ACCOUNT_YEAR_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_ACCOUNT_YEAR_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_ACCOUNT_YEAR_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_ACCOUNT_YEAR_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_ACCOUNT_YEAR_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_ACCOUNT_YEAR_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_HEAD_DATA_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_HEAD_DATA_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_HEAD_DATA_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_HEAD_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_HEAD_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_HEAD_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SUPER_ADMIN_DETAILS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SUPER_ADMIN_DETAILS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SUPER_ADMIN_DETAILS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SUPER_ADMIN_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SUPER_ADMIN_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SUPER_ADMIN_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SECURITY_USERLOGIN_AUTHENTICATION : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SECURITY_USERLOGIN_AUTHENTICATION");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SECURITY_USERLOGIN_AUTHENTICATION", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SECURITY_USERACCESSGROUPS_CRUDOPERATIONS : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SECURITY_USERACCESSGROUPS_CRUDOPERATIONS");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SECURITY_USERACCESSGROUPS_CRUDOPERATIONS", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SECURITY_USERPERMISSION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SECURITY_USERPERMISSION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SECURITY_USERPERMISSION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SECURITY_USERACCESSGROUPS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SECURITY_USERACCESSGROUPS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SECURITY_USERACCESSGROUPS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SECURITY_USER_FORGOTPASSWORD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SECURITY_USER_FORGOTPASSWORD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SECURITY_USER_FORGOTPASSWORD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_EMP_ACCOUNTYEAR_MAPPING_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_EMP_ACCOUNTYEAR_MAPPING_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_EMP_ACCOUNTYEAR_MAPPING_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_OUTLET_GSTRATEMASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_OUTLET_GSTRATEMASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_OUTLET_GSTRATEMASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_OUTLET_GSTRATEMASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_OUTLET_GSTRATEMASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_OUTLET_GSTRATEMASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_PRICE_LIST_SETTINGS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PRICE_LIST_SETTINGS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PRICE_LIST_SETTINGS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_PRICE_LIST_SETTINGS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PRICE_LIST_SETTINGS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PRICE_LIST_SETTINGS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_LABOUR_CHARGE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_LABOUR_CHARGE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_LABOUR_CHARGE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_LABOUR_CHARGE_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_LABOUR_CHARGE_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_LABOUR_CHARGE_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_LABOUR_CHARGE_MASTERHIS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_LABOUR_CHARGE_MASTERHIS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_LABOUR_CHARGE_MASTERHIS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_DIAMOND_RATE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_DIAMOND_RATE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_DIAMOND_RATE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_DIAMOND_RATE_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_DIAMOND_RATE_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_DIAMOND_RATE_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SHAPE_SIZE_COLOR_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SHAPE_SIZE_COLOR_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SHAPE_SIZE_COLOR_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_ACCOUNT_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_ACCOUNT_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_ACCOUNT_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_ACCOUNT_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_ACCOUNT_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_ACCOUNT_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_ACCOUNT_MASTER_DOCUMENT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_ACCOUNT_MASTER_DOCUMENT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_ACCOUNT_MASTER_DOCUMENT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_PURCHASE_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASE_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASE_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_PURCHASE_MASTER_DETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASE_MASTER_DETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASE_MASTER_DETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_PURCHASE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_PRODUCT_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PRODUCT_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PRODUCT_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_DESIGNNO_COPYTODETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_DESIGNNO_COPYTODETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_DESIGNNO_COPYTODETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_PRODUCT_MASTER_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PRODUCT_MASTER_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PRODUCT_MASTER_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_CHARNI_MASTER_AUTOSUGGEST : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_CHARNI_MASTER_AUTOSUGGEST");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_CHARNI_MASTER_AUTOSUGGEST", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_PURCHASE_FINAL_SUBMIT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASE_FINAL_SUBMIT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASE_FINAL_SUBMIT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SALES_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SALES_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALESPRODUCT_MASTER_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESPRODUCT_MASTER_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESPRODUCT_MASTER_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALESPRODUCT_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESPRODUCT_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESPRODUCT_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_PURCHASE_PAYMENT_TERMS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASE_PAYMENT_TERMS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASE_PAYMENT_TERMS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_PURCHASE_PAYMENT_TERMS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASE_PAYMENT_TERMS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASE_PAYMENT_TERMS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_COPYDESIGNNO_TOSALESDETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_COPYDESIGNNO_TOSALESDETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_COPYDESIGNNO_TOSALESDETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_CATEGORY_SIZE_MASTER_AUTOSUGGEST : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_CATEGORY_SIZE_MASTER_AUTOSUGGEST");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_CATEGORY_SIZE_MASTER_AUTOSUGGEST", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SALES_PRODUCTMASTER_DETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_PRODUCTMASTER_DETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_PRODUCTMASTER_DETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SALES_FINAL_SUBMIT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_FINAL_SUBMIT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_FINAL_SUBMIT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SALESINVOICE_SUMMARY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESINVOICE_SUMMARY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESINVOICE_SUMMARY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    

    public class OUTLET_PENDING_RECEIVER_BILL_LIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PENDING_RECEIVER_BILL_LIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PENDING_RECEIVER_BILL_LIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_CASHBANKBOOK_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_CASHBANKBOOK_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_CASHBANKBOOK_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_CASHBANKBOOK_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_CASHBANKBOOK_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_CASHBANKBOOK_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_CASHBANKBOOK_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_CASHBANKBOOK_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_CASHBANKBOOK_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_GENERAL_PURCHASE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_GENERAL_PURCHASE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_GENERAL_PURCHASE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_GENERAL_PURCHASE_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_GENERAL_PURCHASE_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_GENERAL_PURCHASE_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_GENERAL_PURCHASE_MASTER_DETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_GENERAL_PURCHASE_MASTER_DETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_GENERAL_PURCHASE_MASTER_DETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_TEMP_TRANSFER_COPYTODETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_TEMP_TRANSFER_COPYTODETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_TEMP_TRANSFER_COPYTODETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCK_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCK_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCK_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_JOURNAL_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_JOURNAL_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_JOURNAL_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_JOURNAL_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_JOURNAL_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_JOURNAL_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCKINWARD_FINAL_SUBMIT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCKINWARD_FINAL_SUBMIT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCKINWARD_FINAL_SUBMIT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_OFFERS_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_OFFERS_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_OFFERS_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_OFFERS_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_OFFERS_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_OFFERS_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_OFFERDESIGNPRICE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_OFFERDESIGNPRICE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_OFFERDESIGNPRICE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }    

    public class OUTLET_SALESINVOICE_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESINVOICE_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESINVOICE_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SALESPAYMENT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESPAYMENT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESPAYMENT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SALESPAYMENT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESPAYMENT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESPAYMENT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_LEDGER_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_LEDGER_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_LEDGER_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_MATERIAL_PURCHASE_SALES_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_MATERIAL_PURCHASE_SALES_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_MATERIAL_PURCHASE_SALES_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_MATERIAL_PURCHASE_SALES_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_MATERIAL_PURCHASE_SALES_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_MATERIAL_PURCHASE_SALES_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_MATERIAL_PURCHASE_SALES_MASTER_DETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_MATERIAL_PURCHASE_SALES_MASTER_DETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_MATERIAL_PURCHASE_SALES_MASTER_DETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_ACCOUNT_BALANCEMAS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_ACCOUNT_BALANCEMAS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_ACCOUNT_BALANCEMAS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_ACCOUNT_BALANCEMAS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_ACCOUNT_BALANCEMAS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_ACCOUNT_BALANCEMAS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCK_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCK_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCK_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCKTALLYDETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCKTALLYDETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCKTALLYDETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCKTALLYDETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCKTALLYDETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCKTALLYDETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCKTALLYSUMMARY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCKTALLYSUMMARY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCKTALLYSUMMARY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_GST_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_GST_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_GST_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALES_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_PURCHASE_SALES_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASE_SALES_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASE_SALES_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_MATERIAL_STOCK_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_MATERIAL_STOCK_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_MATERIAL_STOCK_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_PROFIT_LOSS_ACCOUNT_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PROFIT_LOSS_ACCOUNT_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PROFIT_LOSS_ACCOUNT_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_BAGNO_SKUNO_AUTOSUGGEST : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_BAGNO_SKUNO_AUTOSUGGEST");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_BAGNO_SKUNO_AUTOSUGGEST", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCK_TRANSFER_BILLNO_AUTOSUGGEST : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCK_TRANSFER_BILLNO_AUTOSUGGEST");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCK_TRANSFER_BILLNO_AUTOSUGGEST", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SIZE_MASTER_AUTOSUGGEST : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SIZE_MASTER_AUTOSUGGEST");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SIZE_MASTER_AUTOSUGGEST", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_CASTOBANK_TRANSACTION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_CASTOBANK_TRANSACTION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_CASTOBANK_TRANSACTION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_CASTOBANK_TRANSACTION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_CASTOBANK_TRANSACTION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_CASTOBANK_TRANSACTION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALES_RETURN_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_RETURN_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_RETURN_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALES_RETURN_PRODUCT_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_RETURN_PRODUCT_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_RETURN_PRODUCT_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALES_RETURN_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_RETURN_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_RETURN_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALES_RETURN_FINAL_SUBMIT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_RETURN_FINAL_SUBMIT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_RETURN_FINAL_SUBMIT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SALES_RETURN_COPYTODETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_RETURN_COPYTODETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_RETURN_COPYTODETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_PURCHASERETURN_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASERETURN_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASERETURN_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_PURCHASERETURN_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASERETURN_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASERETURN_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_PURCHASERETURNPRODUCT_MASTER_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASERETURNPRODUCT_MASTER_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASERETURNPRODUCT_MASTER_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_PURCHASERETURNPRODUCT_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASERETURNPRODUCT_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASERETURNPRODUCT_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_COPYDESIGNNO_TOPURCHASERETURNDETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_COPYDESIGNNO_TOPURCHASERETURNDETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_COPYDESIGNNO_TOPURCHASERETURNDETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_PURCHASERETURN_FINAL_SUBMIT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASERETURN_FINAL_SUBMIT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASERETURN_FINAL_SUBMIT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SALESPURCHASE_ACCOUNT_AUTOSUGGEST : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESPURCHASE_ACCOUNT_AUTOSUGGEST");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESPURCHASE_ACCOUNT_AUTOSUGGEST", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_PURCHASERETURNPAYMENT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASERETURNPAYMENT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASERETURNPAYMENT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_PURCHASERETURNPAYMENT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASERETURNPAYMENT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASERETURNPAYMENT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_PURCHASERETURNINVOICE_SUMMARY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASERETURNINVOICE_SUMMARY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASERETURNINVOICE_SUMMARY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_PURCHASERETURNINVOICE_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_PURCHASERETURNINVOICE_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_PURCHASERETURNINVOICE_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SALES_RETURN_PRODUCT_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_RETURN_PRODUCT_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_RETURN_PRODUCT_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALES_RETURN_PAYMENT_TERMS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_RETURN_PAYMENT_TERMS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_RETURN_PAYMENT_TERMS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALES_RETURN_PAYMENT_TERMS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_RETURN_PAYMENT_TERMS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_RETURN_PAYMENT_TERMS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_INVOICESETTING_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_INVOICESETTING_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_INVOICESETTING_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_INVOICESETTING_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_INVOICESETTING_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_INVOICESETTING_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_DESIGNLIST_FROMBILLNO_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_DESIGNLIST_FROMBILLNO_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_DESIGNLIST_FROMBILLNO_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_STOCK_RETURN_COPYTODETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCK_RETURN_COPYTODETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCK_RETURN_COPYTODETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCKRETURN_FINAL_SUBMIT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCKRETURN_FINAL_SUBMIT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCKRETURN_FINAL_SUBMIT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCKRETURN_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCKRETURN_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCKRETURN_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCKRETURN_PRODUCT_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCKRETURN_PRODUCT_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCKRETURN_PRODUCT_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCKRETURN_PRODUCT_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCKRETURN_PRODUCT_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCKRETURN_PRODUCT_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_STOCK_RETURN_BAGNO_AUTOSUGGEST : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_STOCK_RETURN_BAGNO_AUTOSUGGEST");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_STOCK_RETURN_BAGNO_AUTOSUGGEST", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_YEARENDPROCESS : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage =  OuletYearEndProcess.YearEndStartProcess(InputXml);
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_YEARENDPROCESS", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_YEARENDPROCESS_ACCOUNTLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_YEARENDPROCESS_ACCOUNTLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_YEARENDPROCESS_ACCOUNTLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_YEAREND_ACCOUNTOPENING_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_YEAREND_ACCOUNTOPENING_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_YEAREND_ACCOUNTOPENING_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_YEARENDPROCESS_STOCKTRANSFER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_YEARENDPROCESS_STOCKTRANSFER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_YEARENDPROCESS_STOCKTRANSFER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_YEARENDPROCESS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_YEARENDPROCESS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_YEARENDPROCESS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_ACCOUNTYEAR_CLOSEPERIOD_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_ACCOUNTYEAR_CLOSEPERIOD_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_ACCOUNTYEAR_CLOSEPERIOD_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_ACCOUNTYEAR_CLOSEPERIOD_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_ACCOUNTYEAR_CLOSEPERIOD_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_ACCOUNTYEAR_CLOSEPERIOD_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
}