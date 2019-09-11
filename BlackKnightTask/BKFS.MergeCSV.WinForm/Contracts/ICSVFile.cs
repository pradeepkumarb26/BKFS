using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKFS.MergeCSV.WinForm.Contracts
{
    public interface ICSVFile
    {
        DataTable ReadCSVFile(string file, bool NoHeader);
    }
}
