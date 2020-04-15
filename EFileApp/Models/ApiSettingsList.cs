using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EFileApp.Models
{
    [XmlRoot("ApiSettings")]
    public class ApiSettingsList
    {


        [XmlArray("ApiSettingListing")]

        [XmlArrayItem("ApiSetting", typeof(ApiSettings))]
        public List<ApiSettings> apiSettingList;

        // Constructor
        public ApiSettingsList()
        {
            apiSettingList = new List<ApiSettings>();
        }

        public void AddApiSetting(ApiSettings apiSetting)
        {
            apiSettingList.Add(apiSetting);
        }
    }
}
 
