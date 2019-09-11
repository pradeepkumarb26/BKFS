using BKFS.MergeCSV.WinForm.Common;
using BKFS.MergeCSV.WinForm.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKFS.MergeCSV.WinForm.Implementation
{
    public class JsonFile : IJsonFile
    {
        public void WriteJson(object data)
        {
            try
            {
                Common.Common.ListToJSONWithJavaScriptSerializer(data);
            }
            catch (Exception e)
            {
                MergeLog.LogError(e);
                throw e;
            }
        }
    }
}
