using BKFS.MergeCSV.WinForm.Contracts;
using BKFS.MergeCSV.WinForm.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKFS.MergeCSV.WinForm.Common
{
    public class BusinessFactory : IBusinessFactory
    {
        private static BusinessFactory instance = null;

        // Get the single instance
        public static IBusinessFactory Instance
        {
            get
            {
                if (instance == null)
                    instance = new BusinessFactory();
                return instance;
            }
        }

        public ICSVFile csvFile
        {
            get { return new CSVFile(); }
        }

        public IJsonFile jsonFile
        {
            get { return new JsonFile(); }
        }

    }
}
