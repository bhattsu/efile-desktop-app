using EFileApp.Helper;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace EFileApp.Bal
{
    public static class EnvelopeBL
    {
        //Get list of envelopes
        public static dynamic GetEnvelopes(string batchid)
        {
            try
            {
                dynamic batchdetails = AppConstants.ApiCaller.GetBatchDetails(batchid);
                //var item = batchdetails["item"];
                //dynamic envelopes = item["envelopes"];

                return batchdetails;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Get Envelope details
        public static dynamic GetEnvelopeDetails(string envelopeid)
        {
            try
            {
                dynamic envelopedetails = AppConstants.ApiCaller.GetEnvelopDetails(envelopeid);
                var item = envelopedetails["item"];
                var filings = item["filings"];
                return filings;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Download Envelopes
        public static bool DownloadEnvelope(string envelopeid, string downloadfolder)
        {
            try
            {

                dynamic envelopedetails = AppConstants.ApiCaller.GetEnvelopDetails(envelopeid);
                var item = envelopedetails["item"];
                var filings = item["filings"];
                var request = new RestRequest(Method.GET);
                string exportfolder = downloadfolder + "/ENVELOPE_" + envelopeid;
                System.IO.Directory.CreateDirectory(exportfolder);
                foreach (var filing in filings)
                {
                    var filing_id = filing["id"];
                    dynamic filingdetails = AppConstants.ApiCaller.GetFilingDetails(filing_id);
                    var actualfilings = filingdetails["item"]["filing"];
                    foreach (var actualfiling in actualfilings)
                    {
                        Download(actualfiling, exportfolder);

                        if (actualfiling.ContainsKey("attachment"))
                        {
                            var attachments = actualfiling["attachment"];
                            foreach (var attachment in attachments)
                            {
                                Download(attachment, exportfolder);
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Download envelope
        public static bool Download(dynamic node, string exportfolder)
        {
            try
            {
                if (node.ContainsKey("stamped_document"))
                {
                    var stamped_document = node["stamped_document"];
                    var file_name = node["file_name"];
                    // Console.WriteLine("Downloading: " + stamped_document);
                    var client = new RestClient();
                    byte[] bytes = client.DownloadData(new RestRequest(stamped_document, Method.GET));//.SaveAs("example.csv");
                    File.WriteAllBytes(exportfolder + "/" + file_name, bytes);

                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
