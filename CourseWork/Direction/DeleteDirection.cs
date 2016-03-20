using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Direction
{
    public partial class DeleteDirection : Form
    {
        private List<Data.Models.Direction> _direction;
        IStorage storage = new Storage();
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
                var direction = storage.GetDirections();
                for (var i = 0; i < direction.Count; i++)
                {
                    var massive = direction[i].Id.Split('/');
                    storage.DeleteDirection(Convert.ToInt32(massive[1]));
                }
                MessageBox.Show(@"Выбранное направление успешно удалено");
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
                _direction = storage.GetDirections();
                foreach (var t in _direction)
                {
                    if (!DirectionName.Items.Contains(t.NameOfDirection))
                    {
                        DirectionName.Items.Add(t.NameOfDirection);
                    }
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
