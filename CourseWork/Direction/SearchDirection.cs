using System;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Direction
{
    public partial class SearchDirection : Form
    {
        IStorage storage = new Storage();
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
            if (Functions.Text == (string)Functions.Items[0])
            {
                var direction = storage.GetDirectionsDirectionName(SearchStr.Text);
                for (var i = 0; i < direction.Count; i++)
                {
                    if (direction[i].NameOfDirection != SearchStr.Text) continue;
                    datagridViewDirections.Rows.Add();
                    datagridViewDirections.Rows[i].Cells[0].Value = direction[i].NameOfDirection;
                    datagridViewDirections.Rows[i].Cells[1].Value = direction[i].Description;
                }
            }
            else
            {
                var direction = storage.GetDirectionsDirectionName(SearchStr.Text);
                for (var i = 0; i < direction.Count; i++)
                {
                    if (direction[i].NameOfDirection != SearchStr.Text) continue;
                    datagridViewDirections.Rows.Add();
                    datagridViewDirections.Rows[i].Cells[0].Value = direction[i].NameOfDirection;
                    datagridViewDirections.Rows[i].Cells[1].Value = direction[i].Description;
                }
            }
        }

        private void DeleteDirection_Click(object sender, EventArgs e)
        {
            try
            {
                var index = datagridViewDirections.CurrentRow.Index;
                var directionText = (string)datagridViewDirections.Rows[index].Cells[0].Value;
                var direction = storage.GetDirectionsDirectionName(directionText);

                foreach (var t in direction)
                {
                    var massive = t.Id.Split('/');
                    storage.DeleteDirection(Convert.ToInt32(massive[1]));
                }
                MessageBox.Show(@"Выбранное направление успешно удалено");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
