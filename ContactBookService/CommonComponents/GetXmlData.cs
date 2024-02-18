using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ContactBookService.CommonComponents;

namespace ContactBookService.CommonComponents
{
    public class GetXmlData
    {
        private SqlConnection activeCN;
        Database dbConn = new Database();
         
        public string GetResponseXml(string inputXml, string SPName)
        {
            string ResponseXml = string.Empty;
            SqlParameter[] arParam = null;
            SqlDataReader dr = null;
            try
            {
                activeCN = dbConn.GetConnection();
                string RPXml = string.Empty;
                arParam = new SqlParameter[1];
                arParam[0] = new SqlParameter("@Inputstring", inputXml);
                dr = SqlHelper.ExecuteReader(connection: activeCN, commandType: CommandType.StoredProcedure, commandText: SPName, commandParameters: arParam);                
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        RPXml += dr.GetString(0);
                    }
                }
                dr.Close();
                dr.Dispose();
                ResponseXml = RPXml;
                RPXml = string.Empty;
            }
            catch (Exception ex)
            {
                if (activeCN.State == ConnectionState.Open)
                {
                    activeCN.Close();
                }
                ResponseXml = "<SERVICERESPONSE><RESPONSECODE>-1</RESPONSECODE><RESPONSEMESSAGE>DATABASE ERROR " + ex.Message + "</RESPONSEMESSAGE></SERVICERESPONSE>";
            }
            finally
            {
                if (activeCN.State == ConnectionState.Open)
                {
                    activeCN.Close();
                }

                arParam = null;
            }
            return ResponseXml;
        }
    }
}