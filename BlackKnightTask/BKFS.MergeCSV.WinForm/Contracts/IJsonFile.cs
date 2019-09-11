using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKFS.MergeCSV.WinForm.Contracts
{
    public interface IJsonFile
    {
        void WriteJson(object data);
    }
}
