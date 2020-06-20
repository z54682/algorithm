using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace algorithm
{
    public partial class GridView : Form
    {
        public GridView()
        {
            InitializeComponent();
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            //4.5預設未使用，需手動設定TLS1.2
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string strBaseUri = "https://opendata.epa.gov.tw/ws/Data/ATM00698/?format=json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strBaseUri);
            request.Method = "GET";
            request.BeginGetResponse(new AsyncCallback(ReadJsonCallback), request);
        }

        public void ReadJsonCallback(IAsyncResult asyc)
        {
            HttpWebRequest request = (HttpWebRequest)asyc.AsyncState;
            HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(asyc);
            this.Invoke(new Action(() =>
            {
                Stream stream = response.GetResponseStream();
                string strJson = new StreamReader(stream).ReadToEnd();
                var JsonData00698 = JsonConvert.DeserializeObject<DataTable>(strJson);
                dataGridView1.DataSource = JsonData00698;
            }));
        }
    }
}
