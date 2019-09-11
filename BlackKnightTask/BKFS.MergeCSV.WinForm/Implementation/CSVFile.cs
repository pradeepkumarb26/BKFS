using BKFS.MergeCSV.WinForm.Common;
using BKFS.MergeCSV.WinForm.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BKFS.MergeCSV.WinForm.Implementation
{
    public class CSVFile : ICSVFile
    {
        public DataTable ReadCSVFile(string file, bool NoHeader)
        {
            try
            {
                return Common.Common.ConvertCSVtoDataTable(file, NoHeader);
            }
            catch (Exception e)
            {
                MergeLog.LogError(e);
                throw e;
            }
        }
    }
}
