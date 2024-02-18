using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace ContactBookService.CommonComponents
{
    public class Database
    {
        public Database()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ContactConnectionString"].ConnectionString;
            }
        }


        public SqlConnection GetConnection()
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }

        public void CloseConnection(SqlConnection cn)
        {
            if (cn != null)
            {
                cn.Dispose();
            }
        }
        public OleDbConnection GetEXLConnection(string fileLocation, string fileExtension)
        {
            OleDbConnection cn = null;

            if (fileExtension == ".xls")
            {
                cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileLocation + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"");
            }
            else if (fileExtension == ".xlsx")
            {
                cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileLocation + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"");
            }

            return cn;

        }

        public SqlConnection GetVendoreDbConnectionSQl(string Servername, string DatabaseName, string username, string userpassword)
        {
            SqlConnection activeVendorCn = null;
            string connectionStringDBVendor = "";
            connectionStringDBVendor = "Data Source= " + Servername + ";Initial Catalog= " + DatabaseName + ";Persist Security Info= False;User ID= " + username + ";Password = " + userpassword + ";";
            activeVendorCn = new SqlConnection(connectionStringDBVendor);
            activeVendorCn.Open();

            return activeVendorCn;

        }

    }
}