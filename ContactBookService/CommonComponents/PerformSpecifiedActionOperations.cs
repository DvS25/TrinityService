using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using ContactBookService.CommonComponents.Common;

namespace ContactBookService.CommonComponents
{
    public static class PerformSpecifiedAction
    {
        public static string InvokeMethods(string methodName, string XmlInput)
        {
            try
            {
                ICommon common = CommonFactoy.ExecuteMethod(methodName);

                return common.CommonMethod(XmlInput);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}