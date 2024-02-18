using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using MANDAL_SERVICES.CommonComponents;
using ContactBookService.CommonComponents;
using System.Xml;

namespace ContactBookService.BusinessClasses.Common
{
    public class COMPANY_BRANCH_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMPANY_BRANCH_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMPANY_BRANCH_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class COMPANY_BRANCH_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMPANY_BRANCH_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMPANY_BRANCH_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class GROUP_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "GROUP_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("GROUP_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class COMPANYMASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMPANYMASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMPANYMASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class COMPANYMASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMPANYMASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMPANYMASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class STICKEY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "STICKEY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("STICKEY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }


    public class GROUP_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "GROUP_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("GROUP_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class MASTER_CITY_STATE_COUNTRY_CRUDOPERATIONS : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MASTER_CITY_STATE_COUNTRY_CRUDOPERATIONS");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MASTER_CITY_STATE_COUNTRY_CRUDOPERATIONS", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class MASTER_COUNTRY_STATE_CITY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MASTER_COUNTRY_STATE_CITY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MASTER_COUNTRY_STATE_CITY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class CONTACT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "CONTACT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("CONTACT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class CONTACT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "CONTACT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("CONTACT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class LOGIN_AUTHENTICATION : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "LOGIN_AUTHENTICATION");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("LOGIN_AUTHENTICATION", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ANNI_BDAY_NOTIFICATION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ANNI_BDAY_NOTIFICATION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ANNI_BDAY_NOTIFICATION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SMSDEMO_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SMSDEMO_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SMSDEMO_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SMSDEMO_CRUDOPERATIONS : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SMSDEMO_CRUDOPERATIONS");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SMSDEMO_CRUDOPERATIONS", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class EMAILDEMO_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "EMAILDEMO_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("EMAILDEMO_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class EMAILDEMO_CRUDOPERATIONS : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "EMAILDEMO_CRUDOPERATIONS");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("EMAILDEMO_CRUDOPERATIONS", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class STATE_COUNTRYWISE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "STATE_COUNTRYWISE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("STATE_COUNTRYWISE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class MASTERDESIGN_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MASTERDESIGN_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MASTERDESIGN_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class MASTERDESIGN_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MASTERDESIGN_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MASTERDESIGN_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class BAGLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "BAGLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("BAGLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class BAGLIST_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "BAGLIST_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("BAGLIST_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class DESIGNTYPE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "DESIGNTYPE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("DESIGNTYPE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class USERDETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "USERDETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("USERDETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class USERDETAILS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "USERDETAILS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("USERDETAILS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SECURITY_USERACCESSGROUPS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SECURITY_USERACCESSGROUPS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SECURITY_USERACCESSGROUPS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SECURITY_USERACCESSGROUPS_CRUDOPERATIONS : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SECURITY_USERACCESSGROUPS_CRUDOPERATIONS");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SECURITY_USERACCESSGROUPS_CRUDOPERATIONS", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SECURITY_USERPERMISSION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SECURITY_USERPERMISSION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SECURITY_USERPERMISSION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SALES_WHOLESELLER_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SALES_WHOLESELLER_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SALES_WHOLESELLER_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SALES_WHOLESELLER_DETAILS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SALES_WHOLESELLER_DETAILS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SALES_WHOLESELLER_DETAILS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SALES_WHOLESELLER_FILES_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SALES_WHOLESELLER_FILES_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SALES_WHOLESELLER_FILES_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRIVACY_POLICY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRIVACY_POLICY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRIVACY_POLICY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRIVACY_POLICY_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRIVACY_POLICY_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRIVACY_POLICY_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class DESIGN_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "DESIGN_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("DESIGN_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class DESIGNDETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "DESIGNDETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("DESIGNDETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class MAKING_PRICELIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MAKING_PRICELIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MAKING_PRICELIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRICELIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRICELIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRICELIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class GOLD_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "GOLD_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("GOLD_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class GOLD_DETAILS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "GOLD_DETAILS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("GOLD_DETAILS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class APP_WOMAN_COLLECTION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "APP_WOMAN_COLLECTION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("APP_WOMAN_COLLECTION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class APP_WOMAN_COLLECTION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "APP_WOMAN_COLLECTION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("APP_WOMAN_COLLECTION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class CATEGORY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "CATEGORY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("CATEGORY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SUBCATEGORY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SUBCATEGORY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SUBCATEGORY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SUBCATEGORY_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SUBCATEGORY_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SUBCATEGORY_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class BUSINESS_POLICY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "BUSINESS_POLICY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("BUSINESS_POLICY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ALLOW_IP_LIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ALLOW_IP_LIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ALLOW_IP_LIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ALLOW_IP_LIST_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ALLOW_IP_LIST_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ALLOW_IP_LIST_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SECURITY_MENU_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SECURITY_MENU_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SECURITY_MENU_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class APP_LOGIN_AUTHENTICATION : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "APP_LOGIN_AUTHENTICATION");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("APP_LOGIN_AUTHENTICATION", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class APP_CATEGORY_DESIGN_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "APP_CATEGORY_DESIGN_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("APP_CATEGORY_DESIGN_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class APP_CATEGORY_DESIGN_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "APP_CATEGORY_DESIGN_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("APP_CATEGORY_DESIGN_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class APP_CATEGORY_SHARED_DESIGN_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "APP_CATEGORY_SHARED_DESIGN_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("APP_CATEGORY_SHARED_DESIGN_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class LATEST_GOLDRATE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "LATEST_GOLDRATE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("LATEST_GOLDRATE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class SHOPPINGCART_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SHOPPINGCART_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SHOPPINGCART_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class SHOPPINGCART_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SHOPPINGCART_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SHOPPINGCART_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class APP_USERPROFILE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "APP_USERPROFILE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("APP_USERPROFILE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class SALES_QUOTATION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SALES_QUOTATION_CRUD");
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(ResponseMessage);

                if (doc.SelectSingleNode("SERVICERESPONSE//RESPONSECODE").InnerText == "0")
                {
                    //string OrderNumber = "Q18190001", ERP_OrderNo = "TNT18-19001", FileName = "7E615B67-DCEC-4455-B5C1-CFA4FFDEAEA9";
                    string OrderNumber, ERP_OrderNo, FileName;
                    OrderNumber = doc.SelectSingleNode("SERVICERESPONSE//LOCAL_QUONO").InnerText;
                    ERP_OrderNo = doc.SelectSingleNode("SERVICERESPONSE//QUOTATIONNO").InnerText;
                    FileName = doc.SelectSingleNode("SERVICERESPONSE//FILENAME").InnerText;

                    string result = B2BOrderInvoice.B2BOrderPDF(OrderNumber, ERP_OrderNo, FileName);
                    if (result != "success")
                    {
                        ResponseMessage = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + result + "</RESPONSEMESSAGE></SERVICERESPONSE>";
                    }
                }
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SALES_QUOTATION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class WISHLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "WISHLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("WISHLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class SALES_QUOTATION_HISTORY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SALES_QUOTATION_HISTORY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SALES_QUOTATION_HISTORY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class SALES_QUOTATION_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SALES_QUOTATION_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SALES_QUOTATION_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class APP_CONTRY_STATE_CITY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "APP_CONTRY_STATE_CITY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("APP_CONTRY_STATE_CITY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class FEEDBACK_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "FEEDBACK_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("FEEDBACK_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class FEEDBACK_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "FEEDBACK_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("FEEDBACK_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SECURITY_USER_FORGOTPASSWORD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SECURITY_USER_FORGOTPASSWORD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SECURITY_USER_FORGOTPASSWORD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SALES_QUOTATION_LIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SALES_QUOTATION_LIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SALES_QUOTATION_LIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SALES_QUOTATION_DESIGN_ITEM_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SALES_QUOTATION_DESIGN_ITEM_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SALES_QUOTATION_DESIGN_ITEM_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class CART_ITEM_COUNT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "CART_ITEM_COUNT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("CART_ITEM_COUNT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class COMMON_CONTACT_ABOUTMAS_DATA_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CONTACT_ABOUTMAS_DATA_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CONTACT_ABOUTMAS_DATA_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACTIVITYLOCATIONDETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACTIVITYLOCATIONDETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACTIVITYLOCATIONDETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class APP_DESIGN_FILES_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "APP_DESIGN_FILES_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("APP_DESIGN_FILES_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class CHARNI_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "CHARNI_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("CHARNI_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class APP_CUSTOMIZE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "APP_CUSTOMIZE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("APP_CUSTOMIZE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class HOMEBOTTOMSLIDER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "HOMEBOTTOMSLIDER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("HOMEBOTTOMSLIDER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class HOMEBOTTOMSLIDER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "HOMEBOTTOMSLIDER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("HOMEBOTTOMSLIDER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ANNOUNCEMENT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ANNOUNCEMENT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ANNOUNCEMENT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class MAIN_LETTER_TEMPLATE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MAIN_LETTER_TEMPLATE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MAIN_LETTER_TEMPLATE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class MAIN_LETTER_TEMPLATE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MAIN_LETTER_TEMPLATE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MAIN_LETTER_TEMPLATE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class MAIN_LETTERTYPE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MAIN_LETTERTYPE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MAIN_LETTERTYPE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ANNOUNCEMENT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ANNOUNCEMENT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ANNOUNCEMENT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class DATA_MIGRATION_ERP_TO_TRINITY : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "DATA_MIGRATION_ERP_TO_TRINITY");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("DATA_MIGRATION_ERP_TO_TRINITY", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class MAIN_LETTERTEMPLATEIMAGE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MAIN_LETTERTEMPLATEIMAGE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MAIN_LETTERTEMPLATEIMAGE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class MAIN_LETTERTEMPLATEIMAGE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MAIN_LETTERTEMPLATEIMAGE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MAIN_LETTERTEMPLATEIMAGE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class DATAMIGRATE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "DATAMIGRATE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("DATAMIGRATE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class CONTACTUS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "CONTACTUS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("CONTACTUS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class CONTACTUS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "CONTACTUS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("CONTACTUS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class EMAILNOTIFICATION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "EMAILNOTIFICATION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("EMAILNOTIFICATION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class EMAILNOTIFICATION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "EMAILNOTIFICATION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("EMAILNOTIFICATION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class NEWLETTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "NEWLETTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("NEWLETTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class EMAILDEMOIMAGE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "EMAILDEMOIMAGE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("EMAILDEMOIMAGE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class EMAILDEMOIMAGE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "EMAILDEMOIMAGE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("EMAILDEMOIMAGE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SITEMAP_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SITEMAP_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SITEMAP_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class EMAILSERVER_SETTINGS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "EMAILSERVER_SETTINGS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("EMAILSERVER_SETTINGS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class EMAILSERVER_SETTINGS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "EMAILSERVER_SETTINGS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("EMAILSERVER_SETTINGS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class EMAILDEMO_PUBLISH : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "EMAILDEMO_PUBLISH");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("EMAILDEMO_PUBLISH", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class EMAILDEMO_PUBLISH_HISTORY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "EMAILDEMO_PUBLISH_HISTORY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("EMAILDEMO_PUBLISH_HISTORY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SMSDEMO_PUBLISH_HISTORY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SMSDEMO_PUBLISH_HISTORY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SMSDEMO_PUBLISH_HISTORY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SMSDEMO_PUBLISH : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SMSDEMO_PUBLISH");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SMSDEMO_PUBLISH", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class SMSSENT_RESPONSE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SMSSENT_RESPONSE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SMSSENT_RESPONSE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class SMSPUBLISH : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = SendSMS.StartProcess(InputXml);
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SMSPUBLISH", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class SMSSENTLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SMSSENTLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SMSSENTLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class EMAILSENTLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "EMAILSENTLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("EMAILSENTLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class COMMON_CHARTQUERY_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CHARTQUERY_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CHARTQUERY_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class COMMON_CHARTQUERY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CHARTQUERY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CHARTQUERY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class COMMON_CHARTFIELDLIST_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CHARTFIELDLIST_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CHARTFIELDLIST_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class COMMON_CHARTFIELDLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CHARTFIELDLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CHARTFIELDLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class COMMON_CHARTDESIGN_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CHARTDESIGN_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CHARTDESIGN_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class COMMON_CHARTDESIGN_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CHARTDESIGN_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CHARTDESIGN_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class COMMON_CHARTDESIGNDETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CHARTDESIGNDETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CHARTDESIGNDETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SECURITY_CHARTSPERMISSION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "SECURITY_CHARTSPERMISSION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SECURITY_CHARTSPERMISSION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class COMMON_PERMISSIONWISE_CHARTLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_PERMISSIONWISE_CHARTLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_PERMISSIONWISE_CHARTLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class COMMON_CHARTFILTERFIELD_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CHARTFILTERFIELD_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CHARTFILTERFIELD_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class COMMON_CHART_FILTERCRITERIA_CRUDOPERATIONS : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CHART_FILTERCRITERIA_CRUDOPERATIONS");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CHART_FILTERCRITERIA_CRUDOPERATIONS", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class COMMON_CHART_FILTERCRITERIA_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CHART_FILTERCRITERIA_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CHART_FILTERCRITERIA_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class COMMON_CHARTDATA_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_CHARTDATA_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_CHARTDATA_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class COMMON_USER_CHARTVIEWERSETTING_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_USER_CHARTVIEWERSETTING_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_USER_CHARTVIEWERSETTING_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_COPYDESIGNNO_TOSALESORDERDETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_COPYDESIGNNO_TOSALESORDERDETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_COPYDESIGNNO_TOSALESORDERDETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALESORDER_SUMMARY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESORDER_SUMMARY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESORDER_SUMMARY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALESORDER_SUMMARY_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESORDER_SUMMARY_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESORDER_SUMMARY_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALESORDERPRODUCT_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESORDERPRODUCT_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESORDERPRODUCT_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALESORDERPRODUCT_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESORDERPRODUCT_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESORDERPRODUCT_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALESORDER_PRODUCTDETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESORDER_PRODUCTDETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESORDER_PRODUCTDETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALESORDER_FINAL_SUBMIT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESORDER_FINAL_SUBMIT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESORDER_FINAL_SUBMIT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALESORDERPAYMENT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESORDERPAYMENT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESORDERPAYMENT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class OUTLET_SALESORDERPAYMENT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALESORDERPAYMENT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALESORDERPAYMENT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class STATIC_CONCEPTOF_MAS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "STATIC_CONCEPTOF_MAS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("STATIC_CONCEPTOF_MAS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ADMINNOTIFICATION_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ADMINNOTIFICATION_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ADMINNOTIFICATION_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ADMINNOTIFICATION_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ADMINNOTIFICATION_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ADMINNOTIFICATION_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class OUTLET_SALES_MASTER_ACCOUNTID_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "OUTLET_SALES_MASTER_ACCOUNTID_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("OUTLET_SALES_MASTER_ACCOUNTID_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class CURRENCY_EXCHANGERATE_DETAILS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "CURRENCY_EXCHANGERATE_DETAILS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("CURRENCY_EXCHANGERATE_DETAILS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class CURRENCY_EXCHANGERATE_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "CURRENCY_EXCHANGERATE_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("CURRENCY_EXCHANGERATE_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_CURRENCYWISE_CHARGES_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_CURRENCYWISE_CHARGES_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_CURRENCYWISE_CHARGES_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_CURRENCYWISE_CHARGES_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_CURRENCYWISE_CHARGES_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_CURRENCYWISE_CHARGES_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class APP_ENCRYPT_DESIGNCODE : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            string EncryptedDesignCode = string.Empty;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(InputXml);
                EncryptedDesignCode = Encryption.Encrypt_DesignCode(doc.SelectSingleNode("SERVICEREQUEST//DESINGCODE").InnerText);
                ResponseMessage = "<SERVICERESPONSE><RESPONSECODE>0</RESPONSECODE><RESPONSEMESSAGE>success</RESPONSEMESSAGE><ENCRYPTED_CODE>" + EncryptedDesignCode + "</ENCRYPTED_CODE></SERVICERESPONSE>";
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("APP_ENCRYPT_DESIGNCODE", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class NEW_DESIGN_DAYS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "NEW_DESIGN_DAYS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("NEW_DESIGN_DAYS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class NEW_DESIGN_DAYS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "NEW_DESIGN_DAYS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("NEW_DESIGN_DAYS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }


    #region "Manufacturing"
    public class STATIC_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "STATIC_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("STATIC_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class STATIC_MASTER_MULTIPLE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "STATIC_MASTER_MULTIPLE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("STATIC_MASTER_MULTIPLE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class USER_CURRENTACCOUNTYEAR_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "USER_CURRENTACCOUNTYEAR_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("USER_CURRENTACCOUNTYEAR_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_DESIGN_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESIGN_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESIGN_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_DESIGN_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESIGN_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESIGN_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_DESIGN_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESIGN_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESIGN_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_DESIGN_IMAGES_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESIGN_IMAGES_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESIGN_IMAGES_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_SELECTIONLIST_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_SELECTIONLIST_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_SELECTIONLIST_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_SELECTIONLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_SELECTIONLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_SELECTIONLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_SELECTIONLIST_ITEMS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_SELECTIONLIST_ITEMS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_SELECTIONLIST_ITEMS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_DESIGNSHARING_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESIGNSHARING_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESIGNSHARING_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACCOUNTMASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACCOUNTMASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACCOUNTMASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACCOUNTMASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACCOUNTMASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACCOUNTMASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACCOUNTMASTERFILES_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACCOUNTMASTERFILES_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACCOUNTMASTERFILES_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_DEPARTMENT_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DEPARTMENT_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DEPARTMENT_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_DEPARTMENT_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DEPARTMENT_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DEPARTMENT_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    #endregion

    #region "Master"
    public class ACC_ITEMMASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ITEMMASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ITEMMASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_ITEMMASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ITEMMASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ITEMMASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_ITEMDETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ITEMDETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ITEMDETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_TAX_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_TAX_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_TAX_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_TAX_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_TAX_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_TAX_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_TAXPROFILE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_TAXPROFILE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_TAXPROFILE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_TAXPROFILE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_TAXPROFILE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_TAXPROFILE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_TAXPROFILE_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_TAXPROFILE_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_TAXPROFILE_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    #endregion

    public class ACC_QUOTATION_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_QUOTATION_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_QUOTATION_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

      public class ACC_JEWELLERYTRANSACTION_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JEWELLERYTRANSACTION_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JEWELLERYTRANSACTION_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
 
    public class PRD_RELATED_DESIGNS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RELATED_DESIGNS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RELATED_DESIGNS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRODUCT_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRODUCT_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRODUCT_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_PRODUCT_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_PRODUCT_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_PRODUCT_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_SHARED_DESIGNS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_SHARED_DESIGNS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_SHARED_DESIGNS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_QUOTATION_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_QUOTATION_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_QUOTATION_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_QUOTATION_ITEM_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_QUOTATION_ITEM_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_QUOTATION_ITEM_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_ORDER_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ORDER_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ORDER_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_ORDER_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ORDER_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ORDER_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_ORDER_ITEM_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ORDER_ITEM_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ORDER_ITEM_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_DESIGNSHARING_ITEAM_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESIGNSHARING_ITEAM_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESIGNSHARING_ITEAM_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_DESIGNSHARING_ITEAM_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESIGNSHARING_ITEAM_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESIGNSHARING_ITEAM_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_SHARINGHISTORY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_SHARINGHISTORY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_SHARINGHISTORY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
   
    public class ACC_CATALOG_TO_QUOTATION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CATALOG_TO_QUOTATION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CATALOG_TO_QUOTATION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    

    public class ACC_JEWELLERY_SALE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JEWELLERY_SALE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JEWELLERY_SALE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_JEWELLERY_SALE_ITEM_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JEWELLERY_SALE_ITEM_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JEWELLERY_SALE_ITEM_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_JEWELLERY_SALE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JEWELLERY_SALE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JEWELLERY_SALE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACCOUNTMASTER_SHIPINGINFO_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACCOUNTMASTER_SHIPINGINFO_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACCOUNTMASTER_SHIPINGINFO_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACCOUNTMASTER_STAFFINFO_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACCOUNTMASTER_STAFFINFO_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACCOUNTMASTER_STAFFINFO_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACCOUNTMASTER_OTHERINFO_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACCOUNTMASTER_OTHERINFO_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACCOUNTMASTER_OTHERINFO_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class STATIC_ADDRESS_TYPE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "STATIC_ADDRESS_TYPE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("STATIC_ADDRESS_TYPE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class STATIC_ACCBOOK_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "STATIC_ACCBOOK_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("STATIC_ACCBOOK_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class STATIC_PRICELIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "STATIC_PRICELIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("STATIC_PRICELIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_SELECTIONLISTITEMS_CART_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_SELECTIONLISTITEMS_CART_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_SELECTIONLISTITEMS_CART_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_SELECTIONLISTITEMS_CART_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_SELECTIONLISTITEMS_CART_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_SELECTIONLISTITEMS_CART_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
  
    public class ACC_MATERIALTRANSACTION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIALTRANSACTION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIALTRANSACTION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_MATERIALTRANSACTION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIALTRANSACTION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIALTRANSACTION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_MATERIALTRANSACTION_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIALTRANSACTION_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIALTRANSACTION_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_MATERIAL_STOCK_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIAL_STOCK_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIAL_STOCK_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_MATERIALTRANSACTION_RETURN_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIALTRANSACTION_RETURN_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIALTRANSACTION_RETURN_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

   
    public class ACC_MATERIALTRANSACTION_FREIGHTDEATIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIALTRANSACTION_FREIGHTDEATIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIALTRANSACTION_FREIGHTDEATIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_ORDER_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_ORDER_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_ORDER_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class JEWELLERY_TRAN_DESIGNLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "JEWELLERY_TRAN_DESIGNLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("JEWELLERY_TRAN_DESIGNLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACCOUNTMASTER_MACPERMISSION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACCOUNTMASTER_MACPERMISSION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACCOUNTMASTER_MACPERMISSION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACCOUNTMASTER_MACPERMISSION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACCOUNTMASTER_MACPERMISSION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACCOUNTMASTER_MACPERMISSION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACCOUNTMASTER_REFERENCEDETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACCOUNTMASTER_REFERENCEDETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACCOUNTMASTER_REFERENCEDETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_QUOTATION_MATERIAL_RATE_LIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_QUOTATION_MATERIAL_RATE_LIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_QUOTATION_MATERIAL_RATE_LIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_QUOTATION_DESIGN_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_QUOTATION_DESIGN_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_QUOTATION_DESIGN_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_ORDER_DESIGN_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ORDER_DESIGN_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ORDER_DESIGN_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_ORDER_MATERIAL_RATE_LIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ORDER_MATERIAL_RATE_LIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ORDER_MATERIAL_RATE_LIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CATALOG_TO_ORDER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CATALOG_TO_ORDER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CATALOG_TO_ORDER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMCODE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMCODE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMCODE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMCODE_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMCODE_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMCODE_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }


    public class PRD_RMCATE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMCATE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMCATE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMCATE_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMCATE_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMCATE_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMSUBCATE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMSUBCATE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMSUBCATE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMSUBCATE_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMSUBCATE_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMSUBCATE_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMCOLOUR_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMCOLOUR_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMCOLOUR_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMCOLOUR_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMCOLOUR_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMCOLOUR_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMPURITY_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMPURITY_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMPURITY_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMPURITY_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMPURITY_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMPURITY_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMSHAPE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMSHAPE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMSHAPE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMSHAPE_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMSHAPE_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMSHAPE_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMCUT_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMCUT_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMCUT_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_RMCUT_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_RMCUT_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_RMCUT_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class LOCKERMASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "LOCKERMASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("LOCKERMASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class LOCKERMASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "LOCKERMASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("LOCKERMASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_PENDING_VOUCHER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_PENDING_VOUCHER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_PENDING_VOUCHER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_JEWELLERYTRANSACTION_ITEMS_LIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JEWELLERYTRANSACTION_ITEMS_LIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JEWELLERYTRANSACTION_ITEMS_LIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_JEWELLERYTRANSACTION_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JEWELLERYTRANSACTION_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JEWELLERYTRANSACTION_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_JEWELLERYTRANSACTION_DESIGN_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JEWELLERYTRANSACTION_DESIGN_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JEWELLERYTRANSACTION_DESIGN_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_DESGCATE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESGCATE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESGCATE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_DESGCATE_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESGCATE_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESGCATE_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_DESGSUBCATE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESGSUBCATE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESGSUBCATE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_DESGSUBCATE_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESGSUBCATE_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESGSUBCATE_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_JEWELLERY_MATERIAL_RATE_LIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JEWELLERY_MATERIAL_RATE_LIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JEWELLERY_MATERIAL_RATE_LIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CASHBANK_TRANSACTION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CASHBANK_TRANSACTION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CASHBANK_TRANSACTION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CASHBANK_TRANSACTION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CASHBANK_TRANSACTION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CASHBANK_TRANSACTION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_MATERIALTRANSACTION_FILESLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIALTRANSACTION_FILESLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIALTRANSACTION_FILESLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_JEWELLERYTRANSACTION_FILESLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JEWELLERYTRANSACTION_FILESLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JEWELLERYTRANSACTION_FILESLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CASHBANKBOOK_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CASHBANKBOOK_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CASHBANKBOOK_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_PRODUCT_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_PRODUCT_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_PRODUCT_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_CONTRAENTRY_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CONTRAENTRY_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CONTRAENTRY_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }


    public class ACC_CATALOG_TO_SALE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CATALOG_TO_SALE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CATALOG_TO_SALE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_GENERALEXPENSE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_GENERALEXPENSE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_GENERALEXPENSE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_GENERALEXPANSE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_GENERALEXPANSE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_GENERALEXPANSE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CONTRA_CHARGE_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CONTRA_CHARGE_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CONTRA_CHARGE_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_GENERALEXPANSE_FILES_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_GENERALEXPANSE_FILES_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_GENERALEXPANSE_FILES_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_GENERALEXPANSE_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_GENERALEXPANSE_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_GENERALEXPANSE_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class COMPANYMASTER_FILES_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMPANYMASTER_FILES_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMPANYMASTER_FILES_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_PROCESS_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_PROCESS_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_PROCESS_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class PRD_PROCESS_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_PROCESS_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_PROCESS_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CREDITDEBIT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CREDITDEBIT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CREDITDEBIT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CREDITDEBIT_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CREDITDEBIT_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CREDITDEBIT_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class USERACCESSGROUPS_PERMISSION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "USERACCESSGROUPS_PERMISSION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("USERACCESSGROUPS_PERMISSION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_ACCOUNTOPENINGBALANCE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ACCOUNTOPENINGBALANCE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ACCOUNTOPENINGBALANCE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_ACCOUNT_OPENING_BALANCE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ACCOUNT_OPENING_BALANCE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ACCOUNT_OPENING_BALANCE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_ACCOUNTOPENINGBALANCE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ACCOUNTOPENINGBALANCE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ACCOUNTOPENINGBALANCE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CURRENCYRATEDIFFERENCE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CURRENCYRATEDIFFERENCE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CURRENCYRATEDIFFERENCE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_JOURNAL_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JOURNAL_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JOURNAL_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_JOURNAL_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JOURNAL_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JOURNAL_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_SALEPURCHASEJV_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_SALEPURCHASEJV_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_SALEPURCHASEJV_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_SALEPURCHASEJV_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_SALEPURCHASEJV_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_SALEPURCHASEJV_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_SALEPURCHASEJV_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_SALEPURCHASEJV_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_SALEPURCHASEJV_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_OPENINGASSETS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_OPENINGASSETS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_OPENINGASSETS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_OPENINGASSETS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_OPENINGASSETS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_OPENINGASSETS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_OPENINGASSETS_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_OPENINGASSETS_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_OPENINGASSETS_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_OPENINGASSETS_FILES_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_OPENINGASSETS_FILES_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_OPENINGASSETS_FILES_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_HEAD_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_HEAD_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_HEAD_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_HEAD_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_HEAD_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_HEAD_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_SUBHEAD_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_SUBHEAD_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_SUBHEAD_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_SUBHEAD_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_SUBHEAD_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_SUBHEAD_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class PRD_DESIGNTREE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "PRD_DESIGNTREE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("PRD_DESIGNTREE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class COMMON_MENUMAS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "COMMON_MENUMAS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("COMMON_MENUMAS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class USERLOGINHISTORY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "USERLOGINHISTORY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("USERLOGINHISTORY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class LOGOUTMASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "LOGOUTMASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("LOGOUTMASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CREDITDEBITNOTE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CREDITDEBITNOTE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CREDITDEBITNOTE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CREDITDEBITNOTE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CREDITDEBITNOTE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CREDITDEBITNOTE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
      public class BRANCHMASTER_FILES_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "BRANCHMASTER_FILES_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("BRANCHMASTER_FILES_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_SALARYDETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_SALARYDETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_SALARYDETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_SALARY_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_SALARY_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_SALARY_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_SALARY_MASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_SALARY_MASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_SALARY_MASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CONTRA_CHARGE_AMT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CONTRA_CHARGE_AMT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CONTRA_CHARGE_AMT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_Change_Password_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_Change_Password_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_Change_Password_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_LEDGER_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_LEDGER_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_LEDGER_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_LEDGER_REPORT_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_LEDGER_REPORT_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_LEDGER_REPORT_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_BALANCE_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_BALANCE_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_BALANCE_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_OUTSTANDING_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_OUTSTANDING_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_OUTSTANDING_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_OUTSTANDING_REPORT_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_OUTSTANDING_REPORT_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_OUTSTANDING_REPORT_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_BALANCESHEET_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_BALANCESHEET_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_BALANCESHEET_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_VOUCHER_SIGNATURE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_VOUCHER_SIGNATURE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_VOUCHER_SIGNATURE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CASHBANKBOOK_PRINT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CASHBANKBOOK_PRINT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CASHBANKBOOK_PRINT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_GENERALEXPENSE_PRINT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_GENERALEXPENSE_PRINT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_GENERALEXPENSE_PRINT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_JEWELLERYTRANSACTION_PRINT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_JEWELLERYTRANSACTION_PRINT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_JEWELLERYTRANSACTION_PRINT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_MIX_EXPORT_PRINT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MIX_EXPORT_PRINT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MIX_EXPORT_PRINT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }


    public class ACC_MATERIALTRANSACTION_PRINT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIALTRANSACTION_PRINT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIALTRANSACTION_PRINT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_ORDERMASTER_PRINT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ORDERMASTER_PRINT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ORDERMASTER_PRINT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_QUOTATIONMASTER_PRINT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_QUOTATIONMASTER_PRINT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_QUOTATIONMASTER_PRINT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_FORGOTPASSWORD_OTP_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_FORGOTPASSWORD_OTP_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_FORGOTPASSWORD_OTP_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_VERIFY_OTP : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_VERIFY_OTP");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_VERIFY_OTP", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_RESET_PASSWORD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_RESET_PASSWORD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_RESET_PASSWORD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class YEARENDPROCESS_ACCOUNTLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "YEARENDPROCESS_ACCOUNTLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("YEARENDPROCESS_ACCOUNTLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }


    public class ACC_YEARENDPROCESS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_YEARENDPROCESS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_YEARENDPROCESS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_ACCOUNTYEAR_CLOSEPERIOD_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ACCOUNTYEAR_CLOSEPERIOD_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ACCOUNTYEAR_CLOSEPERIOD_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_ACCOUNTYEAR_CLOSEPERIOD_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ACCOUNTYEAR_CLOSEPERIOD_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ACCOUNTYEAR_CLOSEPERIOD_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_ACCOUNTOPENINGBALANCE_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_ACCOUNTOPENINGBALANCE_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_ACCOUNTOPENINGBALANCE_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_MATERIAL_PRICEMASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIAL_PRICEMASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIAL_PRICEMASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_MATERIAL_PRICELIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIAL_PRICELIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIAL_PRICELIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_MATERIAL_PRICEMASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIAL_PRICEMASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIAL_PRICEMASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_MATERIAL_PRICELIST_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIAL_PRICELIST_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIAL_PRICELIST_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_LABOUR_PRICEMASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_LABOUR_PRICEMASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_LABOUR_PRICEMASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_LABOUR_PRICELIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_LABOUR_PRICELIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_LABOUR_PRICELIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_LABOUR_PRICEMASTER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_LABOUR_PRICEMASTER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_LABOUR_PRICEMASTER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class ACC_LABOUR_PRICELIST_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_LABOUR_PRICELIST_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_LABOUR_PRICELIST_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_PARTYCOMMITMENTDETAILS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_PARTYCOMMITMENTDETAILS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_PARTYCOMMITMENTDETAILS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_PARTYCOMMITMENTDETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_PARTYCOMMITMENTDETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_PARTYCOMMITMENTDETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }


    public class ACC_OUTSTANDING_REPORT_CASHBANK_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_OUTSTANDING_REPORT_CASHBANK_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_OUTSTANDING_REPORT_CASHBANK_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_PROFITANDLOSS_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_PROFITANDLOSS_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_PROFITANDLOSS_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_TRAILBALANCE_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_TRAILBALANCE_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_TRAILBALANCE_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class JEWELLERY_EINVOICEBILL_UPDATE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "JEWELLERY_EINVOICEBILL_UPDATE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("JEWELLERY_EINVOICEBILL_UPDATE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class JEWELLERY_EINVOICEBILL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                BothResponse BothResponse = new BothResponse();
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "JEWELLERY_EINVOICEBILL_CRUD");
                E_Invoice CTObj = new E_Invoice();
                string CT_Request = ResponseMessage;
                BothResponse = CTObj.GetResponseXml_EINVOICE(ResponseMessage);
                ResponseMessage = BothResponse.xml_res;
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("JEWELLERY_EINVOICEBILL_CRUD:CommonMethod", ex);
            }
            finally {  }
            return ResponseMessage;
        }
    }

    public class MATERIAL_EINVOICEBILL_CANCLE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                BothResponse BothResponse = new BothResponse();
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MATERIAL_EINVOICEBILL_CANCLE_CRUD");
                E_Invoice_Cancel CTObj = new E_Invoice_Cancel();
                string CT_Request = ResponseMessage;
                BothResponse = CTObj.GetResponseXml_EINVOICE(ResponseMessage);
                ResponseMessage = BothResponse.xml_res;
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MATERIAL_EINVOICEBILL_CANCLE_CRUD:CommonMethod", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class JEWELLERY_EINVOICEBILL_CANCLE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                BothResponse BothResponse = new BothResponse();
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "JEWELLERY_EINVOICEBILL_CANCLE_CRUD");
                E_Invoice_Cancel CTObj = new E_Invoice_Cancel();
                string CT_Request = ResponseMessage;
                BothResponse = CTObj.GetResponseXml_EINVOICE(ResponseMessage);
                ResponseMessage = BothResponse.xml_res;
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("JEWELLERY_EINVOICEBILL_CANCLE_CRUD:CommonMethod", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class MATERIAL_EINVOICEBILL_UPDATE_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MATERIAL_EINVOICEBILL_UPDATE_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MATERIAL_EINVOICEBILL_UPDATE_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class MATERIAL_EINVOICEBILL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                BothResponse BothResponse = new BothResponse();
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "MATERIAL_EINVOICEBILL_CRUD");
                E_Invoice CTObj = new E_Invoice();
                string CT_Request = ResponseMessage;
                BothResponse = CTObj.GetResponseXml_EINVOICE(ResponseMessage);
                ResponseMessage = BothResponse.xml_res;
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("MATERIAL_EINVOICEBILL_CRUD:CommonMethod", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class GOLD_EXCHANGERATE_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "GOLD_EXCHANGERATE_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("GOLD_EXCHANGERATE_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    //public class EWAYBILL_CRUD : ICommon
    //{
    //    public string CommonMethod(string InputXml)
    //    {
    //        string ResponseMessage = string.Empty;
    //        try
    //        {
    //            BothResponse BothResponse = new BothResponse();
    //            GetXmlData xmlData = new GetXmlData();
    //            ResponseMessage = xmlData.GetResponseXml(InputXml, "EWAYBILL_CRUD");
    //            E_Invoice CTObj = new E_Invoice();
    //            string CT_Request = ResponseMessage;
    //            BothResponse = CTObj.GetResponseXml_EwayBill(ResponseMessage);
    //            ResponseMessage = BothResponse.xml_res;
    //        }
    //        catch (Exception ex)
    //        {
    //            ResponseMessage = ExceptionLogger.GetExceptionsDetails("EWAYBILL_CRUD:CommonMethod", ex);
    //        }
    //        finally { }
    //        return ResponseMessage;
    //    }
    //}
    public class ACC_MATERIAL_EXPORT_PRINT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_MATERIAL_EXPORT_PRINT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_MATERIAL_EXPORT_PRINT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CASHBANK_BANK_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CASHBANK_BANK_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CASHBANK_BANK_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CASHBANK_CASH_REPORT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CASHBANK_CASH_REPORT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CASHBANK_CASH_REPORT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class ACC_CASHBANK_REPORT_DETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "ACC_CASHBANK_REPORT_DETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("ACC_CASHBANK_REPORT_DETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
}
