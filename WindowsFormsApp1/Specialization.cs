using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Specialization
    {
        public Dictionary<string, string> Info { get; private set; }

        public Specialization()
        {
            Info = new Dictionary<string, string>();
            Info.Add("City", "");
            Info.Add("School", "");
            Info.Add("Faculty", "");
            Info.Add("Specialization", "");
            Info.Add("Type", "");
            Info.Add("Price", "");
        }

        public void SetData(string name, string data)
        {
            if (!Info.ContainsKey("name"))
                throw new Exception("This key does not exist.");
            Info[name] = data;
            return;
        }
    }
}
