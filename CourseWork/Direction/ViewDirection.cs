using System.Linq;
using System.Windows.Forms;
using Raven.Client.Document;

namespace CourseWork.Direction
{
    public partial class ViewDirection : Form
    {
        public ViewDirection()
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
                var direction = session.Query<Models.Direction>().ToList();
                if (direction.Count > 0)
                {
                    for(var i = 0;i <direction.Count;i++)
                    {
                        datagridViewDirections.Rows.Add();
                        datagridViewDirections.Rows[i].Cells[0].Value = direction[i].NameOfDirection;
                        datagridViewDirections.Rows[i].Cells[1].Value = direction[i].Description;
                        datagridViewDirections.Rows[i].Cells[2].Value = direction[i].Services[0].NameService;
                        datagridViewDirections.Rows[i].Cells[3].Value = direction[i].Services[0].Duration;
                        datagridViewDirections.Rows[i].Cells[4].Value = direction[i].Services[0].Cost;
                    }
                }
                else
                {
                    MessageBox.Show(@"Список направлений пуст");
                }
                session.SaveChanges();
            }
        }
    }
}
