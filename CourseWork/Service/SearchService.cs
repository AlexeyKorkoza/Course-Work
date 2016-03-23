using System;
using System.Windows.Forms;
using Raven.Client;
using Raven.Client.Document;

namespace CourseWork.Service
{
    public partial class SearchService : Form
    {
        private IDocumentStore store;
        public SearchService()
        {
            InitializeComponent();
        }
        public void ConnectDbDirection()
        {
            store = new DocumentStore
            {
                Url = "http://localhost:8080/",
                DefaultDatabase = "Center"
            };
            store.Initialize();
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
    }
}
