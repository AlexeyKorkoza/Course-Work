using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CourseWork.Input
{
    public class CheckInput
    {
        public bool Check(string filename,string login,string password)
        {
            var flag = true;
            try
            {
                var formatter = new BinaryFormatter();
                var fs = new FileStream(filename, FileMode.OpenOrCreate);
                var list = (Admin) formatter.Deserialize(fs);
                flag = !(list.Password != password || list.Login != login);
                fs.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return flag;
        }
    }
}
