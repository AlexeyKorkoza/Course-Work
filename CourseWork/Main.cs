using System;
using System.IO;
using System.Windows.Forms;
using CourseWork.Client;
using CourseWork.Input;
using CourseWork.Models;
using Raven.Client.Document;

namespace CourseWork
{
    public partial class Main : Form
    {
        public Main()
        {
            try
            {
                InitializeComponent();
                
                //var documentStore = new DocumentStore
                //{
                //    Url = "http://localhost:8080/",
                //    DefaultDatabase = "Center"
                //};
                //documentStore.Initialize();
                //using (var session = documentStore.OpenSession())
                //{
                //    session.Store(new Client
                //    {
                //        Lastname = "Ivanov",
                //        Name = "Alexey",
                //        MiddleName = "Nikolaevich",
                //        Date = "06.10.1995",
                //        AgeCategory = "Adult"
                //    });
                //    session.Store(new Direction
                //    {
                //        NameOfService = "Bassejn",
                //        Description = "GOooddfefhiefihef"
                //    });
                //    session.Store(new Service
                //    {
                //        Duration = "OOKKKK", 
                //        Cost = 20000
                //    });
                //    session.Store(new Discount
                //    {
                //        Code = 1234556, 
                //        Size = 2,
                //        Visit = "One"
                //    });
                //    session.SaveChanges();
                //}
            }
            catch (IOException ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var setting = new Settings();
            setting.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new AddClient();
            client.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            var input = new InputOfAdmin();
            input.Show();
        }
    }
}
