using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKFS.MergeCSV.WinForm.Contracts
{
    public interface IBusinessFactory
    {
        ICSVFile csvFile { get; }
        IJsonFile jsonFile { get; }
    }
}
