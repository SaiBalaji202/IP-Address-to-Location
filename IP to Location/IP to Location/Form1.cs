using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Windows.Forms;

namespace IP_to_Location
{
    public partial class FrmIPAddrHome : Form
    {
        public FrmIPAddrHome()
        {
            InitializeComponent();
        }

        private void btnFetchCurrentIPLocation_Click(object sender, EventArgs e)
        {
            txtIPLocationResult.Text = FetchCurrentIpLocation();
        }

        private void btnFetchLocationDetails_Click(object sender, EventArgs e)
        {
            if (txtIPAddress.Text.Equals("") == false)
            {
                txtIPLocationResult.Text = FetchCurrentIpLocation(txtIPAddress.Text);
            }
        }

        //To Fetch Location of Current IP Address
        private string FetchCurrentIpLocation()
        {
            string strIpLocation = string.Empty;

            var client = new RestClient("https://ipapi.co/json/");
            var request = new RestRequest()
            {
                Method = Method.GET
            };

            var response = client.Execute(request);

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            foreach (var key in dictionary.Keys)
            {
                strIpLocation += key.ToString() + ": " + dictionary[key] + "\r\n";
            }
            return strIpLocation;
        }

        //To Fetch Location of IP Address User Supplied
        private string FetchCurrentIpLocation(string strIP)
        {
            string strIpLocation = string.Empty;

            var client = new RestClient("https://ipapi.co/" + strIP + "/json/");
            var request = new RestRequest()
            {
                Method = Method.GET
            };

            var response = client.Execute(request);

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            foreach (var key in dictionary.Keys)
            {
                strIpLocation += key.ToString() + ": " + dictionary[key] + "\r\n";
            }
            return strIpLocation;
        }

    }
}
