using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EFileApp.Models;
namespace EFileApp.Helper
{
    public static class HelperMethods
    {
        //This method will load the app settings
        public static ApiSettingsList GetApiSettings()
        {
            try
            {
                ApiSettingsList lstApiSettings = new ApiSettingsList();
                string apiSettingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ApiSettings.xml");
                if (File.Exists(apiSettingsFile))
                {
                    // Create an instance of System.Xml.Serialization.XmlSerializer
                    XmlSerializer serializer = new XmlSerializer(lstApiSettings.GetType());

                    // Create an instance of System.IO.TextReader 
                    // to load the serialized data from disk
                    TextReader textReader = new StreamReader(apiSettingsFile);

                    // Assign the deserialized object to the new employeeList object
                    lstApiSettings = (ApiSettingsList)serializer.Deserialize(textReader);

                    // Close the TextReader
                    textReader.Close();

                }
                return lstApiSettings;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool CreateUpdateXmlFile(ApiSettings apiSettings)
        {
            try
            {

                ApiSettingsList lstApiSettings = GetApiSettings();
                var result = GetStateApiSettings(apiSettings.State);

                int index = lstApiSettings.apiSettingList.FindIndex(m => m.State == apiSettings.State);

                if (index >= 0)
                {
                    lstApiSettings.apiSettingList.RemoveAt(index);

                }
                lstApiSettings.AddApiSetting(apiSettings);
              
                
                // Create an instance of System.Xml.Serialization.XmlSerializer
                XmlSerializer serializer = new XmlSerializer(lstApiSettings.GetType());

                string apiSettingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ApiSettings.xml");

                if (File.Exists(apiSettingsFile))
                    File.Delete(apiSettingsFile);

                // Create an instance of System.IO.TextWriter 
                // to save the serialized object to disk
                TextWriter textWriter = new StreamWriter(apiSettingsFile);

                // Serialize the employeeList object
                serializer.Serialize(textWriter, lstApiSettings);

                // Close the TextWriter
                textWriter.Close();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static ApiSettings GetStateApiSettings(string state)
        {
            try
            {
                ApiSettingsList lstApiSettings = GetApiSettings();
                var result = lstApiSettings.apiSettingList.FirstOrDefault(m => m.State == state);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
