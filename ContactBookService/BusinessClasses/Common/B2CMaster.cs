using ContactBookService.CommonComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactBookService.BusinessClasses.Common;

namespace ContactBookService.BusinessClasses.Common
{
    public class B2C_FESTIVALCOLLECTION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_FESTIVALCOLLECTION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_FESTIVALCOLLECTION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_FESTIVAL_COLLECTION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_FESTIVAL_COLLECTION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_FESTIVAL_COLLECTION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_COLLECTION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_COLLECTION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_COLLECTION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_COLLECTION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_COLLECTION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_COLLECTION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class B2C_OFFERS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_OFFERS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_OFFERS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_OFFERS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_OFFERS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_OFFERS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_PRODUCT_LISTING_ADS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_PRODUCT_LISTING_ADS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_PRODUCT_LISTING_ADS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }

    }
    public class B2C_PRODUCT_LISTING_ADS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_PRODUCT_LISTING_ADS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_PRODUCT_LISTING_ADS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_TESTIMONIAL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_TESTIMONIAL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_TESTIMONIAL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_TESTIMONIAL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_TESTIMONIAL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_TESTIMONIAL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_CART_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_CART_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_CART_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_CART_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_CART_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_CART_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_WISHLIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_WISHLIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_WISHLIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_WISHLIST_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_WISHLIST_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_WISHLIST_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_CUSTOMERDETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_CUSTOMERDETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_CUSTOMERDETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_CUSTOMERDETAILS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_CUSTOMERDETAILS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_CUSTOMERDETAILS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_LOGIN_AUTHENTICATION : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_LOGIN_AUTHENTICATION");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_LOGIN_AUTHENTICATION", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_PRODUCT_DESIGN_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_PRODUCT_DESIGN_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_PRODUCT_DESIGN_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_PRODUCT_DESIGN_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_PRODUCT_DESIGN_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_PRODUCT_DESIGN_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_MENULIST : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_MENULIST");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_MENULIST", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_SECURITY_USER_FORGOTPASSWORD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_SECURITY_USER_FORGOTPASSWORD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_SECURITY_USER_FORGOTPASSWORD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ERROR_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ERROR_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ERROR_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ERROR_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ERROR_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ERROR_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_FILTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_FILTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_FILTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_SEARCHHISTORY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_SEARCHHISTORY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_SEARCHHISTORY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_CUSTOMIZE_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_CUSTOMIZE_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_CUSTOMIZE_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_DOPAYMENT : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                ResponseMessage =  Payment.DoPayment(InputXml);
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_DOPAYMENT", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_SHIPPINGADDRESSDETAILS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_SHIPPINGADDRESSDETAILS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_SHIPPINGADDRESSDETAILS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class B2C_SHIPPINGADDRESSDETAILS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_SHIPPINGADDRESSDETAILS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_SHIPPINGADDRESSDETAILS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class B2C_ORDER_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class B2C_SEARCHHISTORY_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_SEARCHHISTORY_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_SEARCHHISTORY_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_CART_WISH_COUNT_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_CART_WISH_COUNT_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_CART_WISH_COUNT_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class GETANDSAVEPAYMENTDETAIL : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                ResponseMessage = Payment.GetAndSavePaymentDetail(InputXml);
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("GETANDSAVEPAYMENTDETAIL", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class CANCELORDERDETAILS : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                ResponseMessage = Payment.CancelOrderDetails(InputXml);
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("CANCELORDERDETAILS", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class B2C_ORDER_PAYMENT_DETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_PAYMENT_DETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_PAYMENT_DETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class B2C_ORDER_HISTORY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_HISTORY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_HISTORY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

    public class B2C_ORDER_HISTORY_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_HISTORY_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_HISTORY_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_CANCEL_REASON_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_CANCEL_REASON_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_CANCEL_REASON_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_CANCEL_SUMMARY_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_CANCEL_SUMMARY_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_CANCEL_SUMMARY_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_MAIN_ORDERACTION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_MAIN_ORDERACTION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_MAIN_ORDERACTION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_APPNOTIFICATION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_APPNOTIFICATION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_APPNOTIFICATION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_TRACKING_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_TRACKING_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_TRACKING_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_CITY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_CITY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_CITY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_NEARESTOUTLET_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_NEARESTOUTLET_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_NEARESTOUTLET_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_DELIVERY_DAYS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_DELIVERY_DAYS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_DELIVERY_DAYS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_DELIVERY_DAYS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_DELIVERY_DAYS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_DELIVERY_DAYS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_CHARGES_SETTINGS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_CHARGES_SETTINGS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_CHARGES_SETTINGS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_CHARGES_SETTINGS_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_CHARGES_SETTINGS_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_CHARGES_SETTINGS_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_RETURN_REASON_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_RETURN_REASON_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_RETURN_REASON_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_RETURN_SUMMARY_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_RETURN_SUMMARY_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_RETURN_SUMMARY_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_MAIN_STATIC_ORDERSTATUS_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_MAIN_STATIC_ORDERSTATUS_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_MAIN_STATIC_ORDERSTATUS_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_MAIN_ORDERACTION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_MAIN_ORDERACTION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_MAIN_ORDERACTION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_TERMSANDCONDITION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_TERMSANDCONDITION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_TERMSANDCONDITION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_PRIVACYPOLICY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_PRIVACYPOLICY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_PRIVACYPOLICY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_FAQ_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_FAQ_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_FAQ_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_NOTIFICATION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_NOTIFICATION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_NOTIFICATION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_NOTIFICATION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_NOTIFICATION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_NOTIFICATION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ALL_ORDER_LIST_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ALL_ORDER_LIST_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ALL_ORDER_LIST_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_PAYMENT_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_PAYMENT_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_PAYMENT_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_CANCEL_REFUND_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_CANCEL_REFUND_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_CANCEL_REFUND_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_RETURN_REFUND_DETAIL_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_RETURN_REFUND_DETAIL_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_RETURN_REFUND_DETAIL_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_CANCEL_REFUND_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_CANCEL_REFUND_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_CANCEL_REFUND_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_RETURN_REFUND_MASTER_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_RETURN_REFUND_MASTER_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_RETURN_REFUND_MASTER_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_CANCEL_REFUND_DETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_CANCEL_REFUND_DETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_CANCEL_REFUND_DETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_ORDER_RETURN_REFUND_DETAIL_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_ORDER_RETURN_REFUND_DETAIL_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_ORDER_RETURN_REFUND_DETAIL_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class SEND_NOTIFICATION : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                ResponseMessage = SendNotification.Notification(InputXml);
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("SEND_NOTIFICATION", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_SIGNALNOTIFICATION_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_SIGNALNOTIFICATION_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_SIGNALNOTIFICATION_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_SIGNALNOTIFICATION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_SIGNALNOTIFICATION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_SIGNALNOTIFICATION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_SIGNALNOTIFICATION_HISTORY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_SIGNALNOTIFICATION_HISTORY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_SIGNALNOTIFICATION_HISTORY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_SIGNALNOTIFICATION_HISTORY_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_SIGNALNOTIFICATION_HISTORY_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_SIGNALNOTIFICATION_HISTORY_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_BESTSELLINGCATEGORY_GET : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_BESTSELLINGCATEGORY_GET");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_BESTSELLINGCATEGORY_GET", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_PRIVACYPOLICY_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_PRIVACYPOLICY_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_PRIVACYPOLICY_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_TERMSANDCONDITION_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_TERMSANDCONDITION_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_TERMSANDCONDITION_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }
    public class B2C_FAQ_CRUD : ICommon
    {
        public string CommonMethod(string InputXml)
        {
            string ResponseMessage = string.Empty;
            try
            {
                GetXmlData xmlData = new GetXmlData();
                ResponseMessage = xmlData.GetResponseXml(InputXml, "B2C_FAQ_CRUD");
            }
            catch (Exception ex)
            {
                ResponseMessage = ExceptionLogger.GetExceptionsDetails("B2C_FAQ_CRUD", ex);
            }
            finally { }
            return ResponseMessage;
        }
    }

}