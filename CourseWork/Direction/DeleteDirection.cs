using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Raven.Client.Document;

namespace CourseWork.Direction
{
    public partial class DeleteDirection : Form
    {
        private List<Models.Direction> _direction;
        public DeleteDirection()
        {
            InitializeComponent();
            DirectionName.DropDownStyle = ComboBoxStyle.DropDownList;
            View();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DirectionName.Text.Length == 0)
                {
                    MessageBox.Show(@"Выберите направление для удаления");
                    return;
                }
                var documentStore = new DocumentStore
                {
                    Url = "http://localhost:8080/",
                    DefaultDatabase = "Center"
                };
                documentStore.Initialize();
                using (var session = documentStore.OpenSession())
                {
                    var direction =
                        session.Query<Models.Direction>().Where(x => x.NameOfDirection == DirectionName.Text).ToList();
                    for (var i = 0; i < direction.Count; i++)
                    {
                        var massive = direction[i].Id.Split('/');
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

        private void Refresh_Click(object sender, EventArgs e)
        {
            View();
        }

        private void View()
        {
            try
            {
                var documentStore = new DocumentStore
                {
                    Url = "http://localhost:8080/",
                    DefaultDatabase = "Center"
                };
                documentStore.Initialize();
                using (var session = documentStore.OpenSession())
                {
                    _direction = session.Query<Models.Direction>().ToList();
                    foreach (var t in _direction)
                    {
                        if (!DirectionName.Items.Contains(t.NameOfDirection))
                        {
                            DirectionName.Items.Add(t.NameOfDirection);
                        }
                    }
                    session.SaveChanges();
                }
                if (_direction.Count == 0)
                {
                    MessageBox.Show(@"Направлений нету!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
