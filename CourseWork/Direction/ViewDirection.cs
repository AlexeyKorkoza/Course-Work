﻿using System;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Direction
{
    public partial class ViewDirection : Form
    {
        IStorage _storage = new Storage();
        public ViewDirection()
        {
            InitializeComponent();
            View();
        }

        private void AddDirection_Click(object sender, EventArgs e)
        {
            var add = new AddDirection();
            add.Show();
        }

        private void View()
        {
            try
            {
                var direction = _storage.GetDirections();
                if (direction.Count > 0)
                {
                    for (var i = 0; i < direction.Count; i++)
                    {
                        datagridViewDirections.Rows.Add();
                        datagridViewDirections.Rows[i].Cells[0].Value = direction[i].NameOfDirection;
                        datagridViewDirections.Rows[i].Cells[1].Value = direction[i].Description;
                     }
                }
                else
                {
                    MessageBox.Show(@"Список направлений пуст");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            datagridViewDirections.Rows.Clear();
            View();
        }
        
        private void datagridViewDirections_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var edit = new EditDirection();
            edit.Show();
        }

        private void DeleteDirection_Click(object sender, EventArgs e)
        {
            var del = new DeleteDirection();
            del.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var search = new SearchDirection();
            search.Show();
        }
    }
}
