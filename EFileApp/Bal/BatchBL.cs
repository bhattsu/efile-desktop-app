using EFileApp.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace EFileApp.Bal
{
    public static class BatchBL
    {
        //Parse XSV File

        public static List<Dictionary<string, string>> ParseXSVFile(string datapath)
        {
            try
            {

                string csvBody = File.ReadAllText(@datapath);
                var databaseTable = new List<Dictionary<string, string>>();
                var headers = new List<string>();

                var rows = Regex.Split(csvBody, "\r\n");
                var rowindex = 0;
                foreach (String row in rows)
                {
                    string line = row.Trim();

                    if (line.Length == 0 || line.StartsWith(AppConstants.COMMENT_OUT))
                    {
                        continue;
                    }

                    var cols = Regex.Split(line,AppConstants.XSV_SEPERATOR);

                    //-----------------------------------------
                    if (rowindex == 0)
                    {
                        foreach (String col in cols)
                        {
                            headers.Add(col); //Collect headers
                        }
                    }
                    else
                    {
                        var keyValues = new Dictionary<string, string>();
                        var colindex = 0;
                        foreach (String col in cols)
                        {
                            var colvalue = col.Trim();
                            keyValues.Add(headers[colindex], colvalue);
                            colindex++;
                        }
                        databaseTable.Add(keyValues);
                    }
                    //-----------------------------------------
                    rowindex++;
                }

                return databaseTable;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Read Templates from template folder and load in a dictionary
        public static Dictionary<string, string> InitiTemplates(string path)
        {
            try
            {

                var templates = new Dictionary<string, string>();

                string[] filePaths = Directory.GetFileSystemEntries(@path, "*.json", SearchOption.AllDirectories);
                for (int i = 0; i < filePaths.Length; i++)
                {
                    string filePath = filePaths[i];
                    string fileName = Path.GetFileName(filePath);
                    if (fileName.EndsWith(AppConstants.JSON_PATTERN))
                    {
                        string content = File.ReadAllText(@filePath);
                        templates.Add(fileName.Replace(AppConstants.JSON_PATTERN, ""), content);
                    }
                }
                return templates;

            }
            catch (Exception)
            {

                throw;
            }
        }
         
       //Download batch
        public static bool DownloadBatch(string batchid, string downloadfolder)
        {
            try
            {
                dynamic batchdetails = AppConstants.ApiCaller.GetBatchDetails(batchid);
                var item = batchdetails["item"];
                var envelopes = item["envelopes"];
                string exportfolder = downloadfolder + "/BATCH_" + batchid;
                System.IO.Directory.CreateDirectory(exportfolder);
                foreach (var envelope in envelopes)
                {
                    var envelope_id = envelope["envelope_id"];
                   EnvelopeBL.DownloadEnvelope(envelope_id, exportfolder);
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Refresh batch
        public static void refreshBatch(string batchid)
        {
            try
            {
                dynamic batchdetails = AppConstants.ApiCaller.GetBatchDetails(batchid);
                var item = batchdetails["item"];
                if (item.ContainsKey("envelopes"))
                {
                    if (AppConstants.LoginState == "MD")
                    {
                        AppConstants.ApiCaller.refreshBatch(batchid); //Refresh only if envelope is present
                    }
                    var envelopes = item["envelopes"];
                    foreach (var envelope in envelopes)
                    {
                        var envelope_id = envelope["envelope_id"];
                        AppConstants.ApiCaller.refreshEnvelope(envelope_id);

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
