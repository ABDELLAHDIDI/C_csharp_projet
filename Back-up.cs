using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace projet
{
    public partial class Back_up : Form
    {
        public Back_up()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            if (box.Text == "")
            {
                MessageBox.Show("you should select an item");
                return;
            }
            var Tlist = new List<string>();
            Tlist.Add("filieres");
            Tlist.Add("eleves");
            Tlist.Add("modules");
            Tlist.Add("matieres");
            Tlist.Add("notes");
            Model.backup(Tlist, DateTime.Parse(box.Text));
            MessageBox.Show("done");
            box.Items.Clear();
            load();
        }
        private List<DateTime> getdates()
        {
            List<DateTime> dates = new List<DateTime>();
            dates= getdatesfromxml("./xmllog/filieres.xml");
            var ltemp = getdatesfromxml("./xmllog/eleves.xml");
            dates=mergedates(dates, ltemp);
            ltemp = getdatesfromxml("./xmllog/modules.xml");
            dates = mergedates(dates, ltemp);
            ltemp = getdatesfromxml("./xmllog/matieres.xml");
            dates = mergedates(dates, ltemp);
            ltemp = getdatesfromxml("./xmllog/notes.xml");
            dates = mergedates(dates, ltemp);

            return dates;

        }

        private List<DateTime> getdatesfromxml(string fn)
        {
            List<DateTime> dates = new List<DateTime>();
            var doc = XDocument.Load(fn);
            var root = doc.Root;

            while (root.HasElements)
            {
                var last = (XElement)root.LastNode;
                var date = DateTime.Parse(last.Attribute("timestamp").Value);
                dates.Add(date);
                last.Remove();
            }
            return dates;
        }

        private List<DateTime> mergedates(List<DateTime> list1, List<DateTime> list2)
        {
            List<DateTime> list3 = new List<DateTime>();
            while (list1.Any() && list2.Any())
            {
                var e1 = list1.First();
                var e2 = list2.First();
                if (e1 > e2)
                {
                    list3.Add(list1[0]);
                    list1.RemoveAt(0);
                }
                else
                {
                    list3.Add(list2[0]);
                    list2.RemoveAt(0);
                }
            }
            while (list1.Any())
            {
                list3.Add(list1[0]);
                list1.RemoveAt(0);
            }
            while (list2.Any())
            {
                list3.Add(list2[0]);
                list2.RemoveAt(0);
            }
            return list3;
        }
        private void load()
        {
            string temp = "";
            foreach (var date in getdates())
            {
                var str = date.ToString("yyyy-MM-dd HH:mm:ss");
                if (str != temp) box.Items.Add(str);
                temp = str;
            }
        }

        private void Back_up_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
