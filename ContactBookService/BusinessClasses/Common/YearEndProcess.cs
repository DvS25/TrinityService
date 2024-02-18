using ContactBookService.CommonComponents;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Xml;

namespace ContactBookService.BusinessClasses.Common
{
    public class YearEndProcess
    {

        public static string YearEndStartProcess(string InputXml)
        {
            string CommonNodes = string.Empty;
            string XMLValue = string.Empty, response = string.Empty, UserType = string.Empty, SecureKey = string.Empty;
            int YearEndAccountYearId = 0, LogInId = 0, EmpId = 0, BranchId = 0, CurrAccountYearId = 0; 
            int NextAccountYearId = 0, YearEndProcessId = 0;

            try
            {
                if (ExtractXml.getNodeValues(InputXml, "ACCOUNTYEARID") != "")
                {
                    YearEndAccountYearId = Convert.ToInt32(ExtractXml.getNodeValues(InputXml, "YEARENDACCOUNTYEARID"));
                }
                if (ExtractXml.getNodeValues(InputXml, "LOGINID") != "")
                {
                    LogInId = Convert.ToInt32(ExtractXml.getNodeValues(InputXml, "LOGINID"));
                }
                if (ExtractXml.getNodeValues(InputXml, "EMPID") != "")
                {
                    EmpId = Convert.ToInt32(ExtractXml.getNodeValues(InputXml, "EMPID"));
                }
                if (ExtractXml.getNodeValues(InputXml, "BRANCHID") != "")
                {
                    BranchId = Convert.ToInt32(ExtractXml.getNodeValues(InputXml, "BRANCHID"));
                }
                if (ExtractXml.getNodeValues(InputXml, "ACCOUNTYEARID") != "")
                {
                    CurrAccountYearId = Convert.ToInt32(ExtractXml.getNodeValues(InputXml, "ACCOUNTYEARID"));
                }
                if (ExtractXml.getNodeValues(InputXml, "USERTYPE") != "")
                {
                    UserType = ExtractXml.getNodeValues(InputXml, "USERTYPE");
                }
                if (ExtractXml.getNodeValues(InputXml, "SECUREKEY") != "")
                {
                    SecureKey = ExtractXml.getNodeValues(InputXml, "SECUREKEY");
                }

                CommonNodes = "<LOGINID>" + LogInId + "</LOGINID>";
                CommonNodes += "<USERTYPE>" + UserType + "</USERTYPE>";
                CommonNodes += "<EMPID>" + EmpId + "</EMPID>";
                CommonNodes += "<BRANCHID>" + BranchId + "</BRANCHID>";
                CommonNodes += "<ACCOUNTYEARID>" + CurrAccountYearId + "</ACCOUNTYEARID>";
                CommonNodes += "<SECUREKEY>" + SecureKey + "</SECUREKEY>";
                CommonNodes += "<YEARENDACCOUNTYEARID>" + YearEndAccountYearId + "</YEARENDACCOUNTYEARID>";

                response = PerformSpecifiedAction.InvokeMethods("YEARENDPROCESS_ACCOUNTLIST_GET", InputXml);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(response);

                if (doc.SelectSingleNode("SERVICERESPONSE//RESPONSECODE").InnerText == "0")
                {
                    NextAccountYearId = Convert.ToInt32(doc.SelectSingleNode("SERVICERESPONSE//NEXTYEARID").InnerText);
                    YearEndProcessId = Convert.ToInt32(doc.SelectSingleNode("SERVICERESPONSE//YEARENDPROCESSID").InnerText);
                    XMLValue = OpeningAccountBalance(CommonNodes, NextAccountYearId, YearEndProcessId);
                    //XMLValue = "<SERVICERESPONSE><RESPONSECODE>0</RESPONSECODE><RESPONSEMESSAGE>Success</RESPONSEMESSAGE></SERVICERESPONSE>";
                }
                else
                {
                    XMLValue = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + doc.SelectSingleNode("SERVICERESPONSE//RESPONSEMESSAGE").InnerText.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
                }
            }
            catch (Exception ex)
            {
                XMLValue = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + ex.StackTrace.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
            }
            return XMLValue;
        }

        public static string OpeningAccountBalance(string Commonxml, int NextAccountYearId, int YearEndProcessId)
        {
            string InputXml = string.Empty, AccountsList = string.Empty;
            string Result = string.Empty;
            try
            {
                InputXml = "<SERVICEREQUEST><SERVICENAME>YEARENDPROCESS_ACCOUNTLIST_GET</SERVICENAME>";
                InputXml += "<oper>edit</oper><FLAG>AccountList</FLAG>";
                InputXml += "<YEARENDPROCESSID>" + YearEndProcessId + "</YEARENDPROCESSID>";
                InputXml += Commonxml;
                InputXml += "</SERVICEREQUEST>";
                InputXml = PerformSpecifiedAction.InvokeMethods("YEARENDPROCESS_ACCOUNTLIST_GET", InputXml);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(InputXml);

                if (doc.SelectSingleNode("SERVICERESPONSE//RESPONSECODE").InnerText == "0")
                {
                    if (doc.GetElementsByTagName("DETAILSLIST").Count > 0)
                    {
                        int i = 0, TotalAccounts = 0;
                        if (doc.GetElementsByTagName("DETAILSLIST")[0].ChildNodes.Count > 0)
                        {
                            int empChunkCount = 10;
                            int counter = 0, threadno = 0;
                            DataSet ds = new DataSet();
                            ds.ReadXml(new XmlTextReader(new StringReader(InputXml)));
                            if (ds.Tables.Count > 1 && ds.Tables["DETAILS"] != null)
                            {
                                TotalAccounts = ds.Tables["DETAILS"].Rows.Count;
                                if (ds.Tables["DETAILS"].Rows.Count > 0)
                                {
                                    int RecTypeIndex = ds.Tables["DETAILS"].Columns["ACCOUNTMASID"].Ordinal;

                                    for (i = 0; i < TotalAccounts; i++)
                                    {
                                        if (counter <= empChunkCount)
                                        {
                                            if (Convert.ToString(ds.Tables["DETAILS"].Rows[i].ItemArray[RecTypeIndex]) != "")
                                            {
                                                AccountsList += ds.Tables["DETAILS"].Rows[i].ItemArray[RecTypeIndex] + ",";
                                            }
                                            counter++;
                                        }

                                        if (counter == empChunkCount || i == (TotalAccounts - 1))
                                        {
                                            threadno++;
                                            AccountsList = AccountsList.Substring(0, AccountsList.Length - 1);
                                            CommonYearEndProcess obj = new CommonYearEndProcess();
                                            obj.prop_nextaccountyearid = NextAccountYearId;
                                            obj.prop_yearendprocessid = YearEndProcessId;
                                            obj.prop_accountslist = AccountsList;
                                            obj.prop_commonnodes = Commonxml;
                                            ThreadPool.QueueUserWorkItem(ProcessEnd, obj); // call thread
                                            counter = 0;
                                            AccountsList = "";
                                        }

                                        if (i == (TotalAccounts - 1))
                                        {
                                            string XMLValue = string.Empty;
                                            XMLValue = "<SERVICEREQUEST><SERVICENAME>YEARENDPROCESS_ACCOUNTLIST_GET</SERVICENAME>" + Commonxml;
                                            XMLValue += "<oper>edit</oper><FLAG>OpnBalanceComplete</FLAG>";
                                            XMLValue += "<NEXTACCOUNTYEARID>" + NextAccountYearId + "</NEXTACCOUNTYEARID>";
                                            XMLValue += "<YEARENDPROCESSID>" + YearEndProcessId + "</YEARENDPROCESSID>";
                                            XMLValue += "</SERVICEREQUEST>";
                                            XMLValue = PerformSpecifiedAction.InvokeMethods("YEARENDPROCESS_ACCOUNTLIST_GET", XMLValue);

                                            XmlDocument doc1 = new XmlDocument();
                                            doc1.LoadXml(XMLValue);

                                            if (doc1.SelectSingleNode("SERVICERESPONSE//RESPONSECODE").InnerText == "0")
                                            {
                                                if (doc1.SelectSingleNode("SERVICERESPONSE//ERRORMESSAGE").InnerText == "")
                                                {
                                                    XMLValue = StockTransfer(Commonxml, NextAccountYearId, YearEndProcessId);
                                                    XmlDocument doc2 = new XmlDocument();
                                                    doc2.LoadXml(XMLValue);

                                                    if (doc2.SelectSingleNode("SERVICERESPONSE//RESPONSECODE").InnerText == "0")
                                                    {
                                                        Result = XMLValue;
                                                    }
                                                    else
                                                    {
                                                        Result = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + doc2.SelectSingleNode("SERVICERESPONSE//RESPONSEMESSAGE").InnerText.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
                                                    }
                                                }
                                                else
                                                {
                                                    Result = XMLValue;
                                                }
                                            }
                                            else
                                            {
                                                Result = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + doc1.SelectSingleNode("SERVICERESPONSE//RESPONSEMESSAGE").InnerText.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Result = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>No Records Found</RESPONSEMESSAGE></SERVICERESPONSE>";
                                }
                            }
                            else
                            {
                                Result = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>No Records Found</RESPONSEMESSAGE></SERVICERESPONSE>";
                            }
                        }
                    }
                    else
                    {
                        Result = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>No Records Found</RESPONSEMESSAGE></SERVICERESPONSE>";
                    }
                }
                else
                {
                    Result = InputXml;
                }
            }
            catch (Exception ex)
            {
                Result = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + ex.InnerException.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
            }
            return Result;
        }

        public static void ProcessEnd(object Obj)
        {
            CommonYearEndProcess threadobj = (CommonYearEndProcess)Obj;
            string InOutPutXml = string.Empty;
            try
            {
                string[] AccountArr = threadobj.prop_accountslist.ToString().Split(',');
                int totAcc = AccountArr.Length, i = 0;
                for (i = 0; i < totAcc; i++)
                {
                    InOutPutXml = "<SERVICEREQUEST><SERVICENAME>OUTLET_YEAREND_ACCOUNTOPENING_CRUD</SERVICENAME>";
                    InOutPutXml += threadobj.prop_commonnodes;
                    InOutPutXml += "<ACCOUNTMASID>" + AccountArr[i] + "</ACCOUNTMASID>";
                    InOutPutXml += "<YEARENDPROCESSID>" + threadobj.prop_yearendprocessid + "</YEARENDPROCESSID>";
                    InOutPutXml += "<NEXTACCOUNTYEARID>" + threadobj.prop_nextaccountyearid + "</NEXTACCOUNTYEARID></SERVICEREQUEST>";
                    InOutPutXml = PerformSpecifiedAction.InvokeMethods("OUTLET_YEAREND_ACCOUNTOPENING_CRUD", InOutPutXml);
                    XmlDocument doc1 = new XmlDocument();
                    doc1.LoadXml(InOutPutXml);
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public static string StockTransfer(string Commonxml, int NextAccountYearId, int YearEndProcessId)
        {
            string InputXml = string.Empty;
            string Result = string.Empty;
            try
            {
                InputXml = "<SERVICEREQUEST><SERVICENAME>OUTLET_YEARENDPROCESS_STOCKTRANSFER_CRUD</SERVICENAME>";
                InputXml += "<oper>Add</oper>";
                InputXml += "<YEARENDPROCESSID>" + YearEndProcessId + "</YEARENDPROCESSID>";
                InputXml += "<NEXTACCOUNTYEARID>" + NextAccountYearId + "</NEXTACCOUNTYEARID>";
                InputXml += Commonxml;
                InputXml += "</SERVICEREQUEST>";
                Result = PerformSpecifiedAction.InvokeMethods("OUTLET_YEARENDPROCESS_STOCKTRANSFER_CRUD", InputXml);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(InputXml);


            }
            catch (Exception ex)
            {
                Result = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>" + ex.InnerException.ToString() + "</RESPONSEMESSAGE></SERVICERESPONSE>";
            }
            return Result;
        }

    }
}