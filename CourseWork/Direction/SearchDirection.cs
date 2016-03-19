using System;
using System.Linq;
using System.Windows.Forms;
using Raven.Client.Document;

namespace CourseWork.Direction
{
    public partial class SearchDirection : Form
    {
        public SearchDirection()
        {
            InitializeComponent();
            DeleteDirection.Enabled = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Functions.Text.Length == 0)
            {
                MessageBox.Show(@"Выберите критерий для поиска!");
                return;
            }
            if (SearchStr.Text.Length == 0)
            {
                MessageBox.Show(@"Заполните строку для поиска!");
                return;
            }
            if (Functions.Text == (string) Functions.Items[0])
            {
                var documentStore = new DocumentStore
                {
                    Url = "http://localhost:8080/",
                    DefaultDatabase = "Center"
                };
                documentStore.Initialize();
                using (var session = documentStore.OpenSession())
                {
                    var direction =
                        session.Query<Models.Direction>().Where(x => x.NameOfDirection == SearchStr.Text).ToList();
                    for (var i = 0; i < direction.Count; i++)
                    {
                        if (direction[i].NameOfDirection != SearchStr.Text) continue;
                        datagridViewDirections.Rows.Add();
                        datagridViewDirections.Rows[i].Cells[0].Value = direction[i].NameOfDirection;
                        datagridViewDirections.Rows[i].Cells[1].Value = direction[i].Description;
                    }
                    session.SaveChanges();
                }
            }
            else
            {
                var documentStore = new DocumentStore
                {
                    Url = "http://localhost:8080/",
                    DefaultDatabase = "Center"
                };
                documentStore.Initialize();
                using (var session = documentStore.OpenSession())
                {
                    var direction =
                        session.Query<Models.Direction>().Where(x => x.Description == SearchStr.Text).ToList();
                    for (var i = 0; i < direction.Count; i++)
                    {
                        if (direction[i].NameOfDirection != SearchStr.Text) continue;
                        datagridViewDirections.Rows.Add();
                        datagridViewDirections.Rows[i].Cells[0].Value = direction[i].NameOfDirection;
                        datagridViewDirections.Rows[i].Cells[1].Value = direction[i].Description;
                    }
                    session.SaveChanges();
                }
            }
        }

        private void DeleteDirection_Click(object sender, EventArgs e)
        {
            try
            {
                var index = datagridViewDirections.CurrentRow.Index;
                var directionText = datagridViewDirections.Rows[index].Cells[0].Value;
                var documentStore = new DocumentStore
                {
                    Url = "http://localhost:8080/",
                    DefaultDatabase = "Center"
                };
                documentStore.Initialize();
                using (var session = documentStore.OpenSession())
                {
                    var direction = 
                        session.Query<Models.Direction>().Where(x => x.NameOfDirection == (string) directionText).ToList();
                    foreach (var t in direction)
                    {
                        var massive = t.Id.Split('/');
                        documentStore.DatabaseCommands.Delete("directions/" + massive[1], null);
                    }
                    MessageBox.Show(@"Выбранное направление успешно удалено");
                    session.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
