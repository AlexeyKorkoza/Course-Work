using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CourseWork.Input
{
    public class CheckInput
    {
        public List<Inputs> ReadInputses(string filename)
        {
            var formatter = new XmlSerializer(typeof(Inputs[]));
            var fs = new FileStream(filename, FileMode.OpenOrCreate);
            var list = (List<Inputs>)formatter.Deserialize(fs);
            return list;
        }

        public bool Check(string filename,string login,string password)
        {
            var list = ReadInputses(filename);
            var flag = !(list[0].Password != password || list[1].Login != login);     
            return flag;
        }
    }
}
