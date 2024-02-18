using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ContactBookService.BusinessClasses.Common
{
    public class Encryption
    {
        public static string Decript(string vsEncptData)
        //Decript the ERP Password
        {
            Int64 victr, viLen;
            String vsResult = string.Empty;
            Int64 ServerSecond = 0;

            string[] vArrDecpt = vsEncptData.Split(("€").ToCharArray());

            ServerSecond = Int64.Parse(vArrDecpt[0]);
            char vsSecond = (char)ServerSecond;
            int ValvsSecond = int.Parse(vsSecond.ToString().Trim());
            viLen = vArrDecpt.GetUpperBound(0) + ValvsSecond;

            for (victr = 1; victr < vArrDecpt.GetUpperBound(0) + 1; victr++)
            {
                vsResult += (char)(int.Parse(vArrDecpt[victr]) - viLen);
                viLen = viLen - 1;
            }

            return vsResult;
        }

        public static string Encrypt_DesignCode(string clearText)
        {
            string EncryptionKey = "Trinity";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        public static string Decrypt_DesignCode(string cipherText)
        {
            string EncryptionKey = "Trinity";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }

}