using System;
using System.IO;
using System.Windows.Forms;
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
                var documentStore = new DocumentStore
                {
                    Url = "http://localhost:8080/",
                    DefaultDatabase = "Center"
                };
                documentStore.Initialize();
                using (var session = documentStore.OpenSession())
                {
                    session.Store(new Client
                    {
                        Lastname = "Ivanov",
                        Name = "Alexey",
                        MiddleName = "Nikolaevich",
                        Date = "06.10.1995",
                        AgeCategory = "Adult"
                    });
                    session.Store(new Direction
                    {
                        NameOfService = "Bassejn",
                        Description = "GOooddfefhiefihef"
                    });
                    session.Store(new Service 
                    {Duration = "OOKKKK", Cost = 20000}
                   );
                    session.Store(new Discount { Code = 1234556, Size = 2 });
                    session.Store(new Subscription{NameOfSubscription = "hour",CostOfSubscription = 3000});
                    session.SaveChanges();
                }
                
                    //db.Client.Add(client1);
                    //db.SaveChanges();
                    //var direction1 = 
                    //db.Direction.AddRange(new List<Direction> {direction1});
                    //db.SaveChanges();
                    //var service1 = new Service {Duration = "OOKKKK", Cost = 20000};
                    //db.Service.AddRange(new List<Service> {service1});
                    //db.SaveChanges();
                    //var discount1 = new Discount {Code = 1234556, Size = 2};
                    //db.Discount.AddRange(new List<Discount> {discount1});
                    //db.SaveChanges();
                
            }
            catch (IOException ex)
            {
               MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var setting = new Settings();
            setting.Show();
        }
    }
}
