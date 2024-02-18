using ContactBookService.CommonComponents;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace ContactBookService.BusinessClasses.Common
{
    public class B2BOrderInvoice
    {
        public static string B2BOrderPDF(string OrderNumber, string ERP_OrderNo,string FileName)
        {
            try
            {
                string XMLValue = string.Empty;

                XMLValue = "<SERVICEREQUEST>" +
                            "<SERVICENAME>SALES_QUOTATION_INVOICE_GET</SERVICENAME>" +
                            "<QUOTATIONNO>" + OrderNumber + "</QUOTATIONNO>" +
                            "<ERPQUOTATIONNO>" + ERP_OrderNo + "</ERPQUOTATIONNO>" +
                            "</SERVICEREQUEST>";

                GetXmlData xmlData = new GetXmlData();
                XMLValue = xmlData.GetResponseXml(XMLValue, "SALES_QUOTATION_INVOICE_GET");
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(XMLValue);

                if (doc.SelectSingleNode("SERVICERESPONSE//RESPONSECODE").InnerText == "0")
                {
                    ReportDocument cryRpt = new ReportDocument();

                    ConnectionInfo crConnectionInfo = new ConnectionInfo();

                    string filename = "B2BOrderInvoice.rpt";
                    string path1 = "/CrystalReport/" + filename;
                    string path = HttpContext.Current.Server.MapPath("~" + path1);  //System.Configuration.ConfigurationManager.AppSettings["domainPath"] + path1;
                    cryRpt.Load(path);

                    /*----------------Bind Items List---------------*/
                    DataTable OrderItems = new DataTable();
                    OrderItems.Columns.Add("DesignNo", typeof(string));
                    OrderItems.Columns.Add("ImgPath", typeof(string));
                    OrderItems.Columns.Add("Size", typeof(string));
                    OrderItems.Columns.Add("Quantity", typeof(Int32));
                    OrderItems.Columns.Add("Particular", typeof(string));
                    OrderItems.Columns.Add("Price", typeof(string));
                    OrderItems.Columns.Add("Labour", typeof(decimal));
                    OrderItems.Columns.Add("Amount", typeof(decimal));
                    OrderItems.Columns.Add("MetalWgt", typeof(decimal));
                    OrderItems.Columns.Add("DiaPcs", typeof(Int32));
                    OrderItems.Columns.Add("DiaWgt", typeof(decimal));
                    OrderItems.Columns.Add("CSPcs", typeof(Int32));
                    OrderItems.Columns.Add("CSWgt", typeof(decimal));

                    if (doc.SelectSingleNode("SERVICERESPONSE//DETAILSLIST//ITEMSLIST") != null)
                    {
                        string img_path = System.Configuration.ConfigurationManager.AppSettings["ItemImgPath"];
                        XmlNodeList Items = doc.SelectNodes("SERVICERESPONSE//DETAILSLIST//ITEMSLIST//ITEMS");
                        foreach (XmlNode node in Items)
                        {
                            OrderItems.Rows.Add(node["DESIGNCODE"].InnerText, img_path + node["IMAGEPATH"].InnerText, node["JSIZE"].InnerText, node["TOTAL_QTY"].InnerText, node["PARTICULAR"].InnerText, node["PRICE"].InnerText, node["TOTAL_LBR"].InnerText, node["TOTAL_AMT"].InnerText, node["TOTAL_MWGT"].InnerText, node["TOTAL_DPCS"].InnerText, node["TOTAL_DWTG"].InnerText, node["TOTAL_CSPCS"].InnerText, node["TOTAL_CSWGT"].InnerText);
                        }
                    }
                    cryRpt.OpenSubreport("SR_OrderItems").SetDataSource(OrderItems);
                    /*----------------------------------------------------- */

                    XmlNode InvoiceDetail = doc.SelectSingleNode("SERVICERESPONSE//DETAILSLIST//DETAILS");
                    cryRpt.SetParameterValue("PartyName", InvoiceDetail["PARTY_CONTACTPERSONNAME"].InnerText.ToUpper());
                    cryRpt.SetParameterValue("CompanyName", InvoiceDetail["PARTYCOMPANY"].InnerText.ToUpper());
                    cryRpt.SetParameterValue("PartyMobile", InvoiceDetail["CONTACTNO"].InnerText);
                    cryRpt.SetParameterValue("PartyEmail", InvoiceDetail["EMAILID"].InnerText);
                    cryRpt.SetParameterValue("OrderNo", InvoiceDetail["QUOTATION_NO"].InnerText);
                    cryRpt.SetParameterValue("ERP_OrderNo", InvoiceDetail["ERP_QUOTAIONNO"].InnerText);
                    cryRpt.SetParameterValue("OrderDate", InvoiceDetail["QUOTATIONDATE"].InnerText);
                    cryRpt.SetParameterValue("OrderType", InvoiceDetail["QUOTATIONTYPE"].InnerText);

                    if (InvoiceDetail["CURRENCYTYPE"] != null)
                    {
                        cryRpt.SetParameterValue("CurrencyType", InvoiceDetail["CURRENCYTYPE"].InnerText);
                    }
                    else
                    {
                        cryRpt.SetParameterValue("CurrencyType", "");
                    }

                    if (InvoiceDetail["SALESPERSONNAME"] != null)
                    {
                        cryRpt.SetParameterValue("SalesPersonName", InvoiceDetail["SALESPERSONNAME"].InnerText);
                    }
                    else
                    {
                        cryRpt.SetParameterValue("SalesPersonName", "");
                    }

                    if (InvoiceDetail["REMARK"] != null)
                    {
                        cryRpt.SetParameterValue("Remark", InvoiceDetail["REMARK"].InnerText);
                    }
                    else
                    {
                        cryRpt.SetParameterValue("Remark", "--");
                    }

                    string FinalFilename;
                    string destFile = "/UploadFiles/B2BOrderInvoice/";
                    string destServerpath = HttpContext.Current.Server.MapPath("~" + destFile);

                    FinalFilename = FileName;

                    string ExportFileName = destServerpath + FinalFilename + ".pdf";
                    if (!Directory.Exists(destServerpath))
                    {
                        Directory.CreateDirectory(destServerpath);
                    }

                    if (System.IO.File.Exists(ExportFileName))
                        System.IO.File.Delete(ExportFileName);

                    cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, ExportFileName);

                    //return destFile + FinalFilename + ".pdf";
                    return "success";
                }
                else
                {
                    return "Error in order details get for PDF generation.";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}