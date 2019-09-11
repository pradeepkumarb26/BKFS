using BKFS.MergeCSV.WinForm.Contracts;
using BKFS.MergeCSV.WinForm.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKFS.MergeCSV.WinForm.Common
{
    public class BusinessClient
    {
        private readonly IBusinessFactory businessFactory;
        private const string JsonFilename = "MergeCSVToJson.json";

        public BusinessClient()
        {
            //Create single business factory object
            businessFactory = BusinessFactory.Instance;
        }

        public void MergeCsvToJson(MergeCSVData mergeCSVData)
        {
            try
            {
                //Get the both csv file details
                var dtOne = businessFactory.csvFile.ReadCSVFile(mergeCSVData.CSVFilePath1, Convert.ToBoolean(mergeCSVData.HeaderExists));
                var dtTwo = businessFactory.csvFile.ReadCSVFile(mergeCSVData.CSVFilePath2, Convert.ToBoolean(mergeCSVData.HeaderExists));

                //merge the both csv file content using union
                var query = (from row_dtOne in dtOne.AsEnumerable() select row_dtOne).Concat(from row_dtTwo in dtTwo.AsEnumerable() select row_dtTwo);

                //group the columns data using fisrt column key
                var list = from key in query
                           orderby key[0]
                           group key by key[0] into keyGroup
                           let childrenOfkeyGroup =
                               from keylist in keyGroup
                               select keylist
                           select childrenOfkeyGroup;

                //Get the Json string vale by passing grouped linq object
                string jsonStr = Common.ListToJSONWithJavaScriptSerializer(list.ToList<IEnumerable<DataRow>>());

                //Save the JSON string content
                File.WriteAllText(mergeCSVData.JsonFilePath + @"\"+ JsonFilename, jsonStr);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

}
