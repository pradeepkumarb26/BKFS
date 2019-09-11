using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BKFS.MergeCSV.WinForm.Common
{
    public class Common
    {
        public static DataTable ConvertCSVtoDataTable(string strFilePath, bool hasHeader)
        {
            try
            {
                string[] headers;
                DataTable dt = new DataTable();

                using (StreamReader sr = new StreamReader(strFilePath))
                {
                    //Verify the CSV file having header or not
                    if (hasHeader)
                    {
                        headers = sr.ReadLine().Split(',');
                        foreach (string header in headers)
                        {
                            dt.Columns.Add(header);
                        }
                    }
                    
                    //Loop the CSV file data until it reaches last data
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        //Skip the line if it is an empty
                        if (string.IsNullOrEmpty(line.Trim()))
                            continue;

                        // Split the data using comma separator
                        string[] rows = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                        if (!hasHeader)
                        {
                            int i = 0;
                            foreach (string header in rows)
                            {
                                dt.Columns.Add(i.ToString());
                                i++;
                            }
                            hasHeader = true;
                        }
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < rows.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }
                }
                MergeLog.Loginformation("Read the CSV file and created data table object.");
                return dt;
            }
            catch (Exception e)
            {
                MergeLog.LogError(e);
                throw e;
            }
        }

        public static string ListToJSONWithJavaScriptSerializer(object data)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            try
            {
                Dictionary<string, object> childRow;
                
                //type cast the received object 
                List<IEnumerable<DataRow>> list = data as List<IEnumerable<DataRow>>;

                //Loop the list and add its content to dictonary object
                foreach (IEnumerable<DataRow> rows in list)
                {
                    childRow = new Dictionary<string, object>();
                    string key = string.Empty;
                    List<object> objList = new List<object>();
                    foreach (var row in rows)
                    {
                        key = row[0].ToString();
                        objList.Add(row.ItemArray.Where(s => s.ToString() != row[0].ToString()));
                    }
                    childRow.Add(key, objList);

                    parentRow.Add(childRow);
                }
            }
            catch (Exception e)
            {
                MergeLog.LogError(e);
                throw e;
            }
            //convert the final dictionary object to serializable
            return jsSerializer.Serialize(parentRow);
        }
    }
}
