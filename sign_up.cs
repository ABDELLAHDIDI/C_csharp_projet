using DB;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace projet
{
    public partial class sign_up : Form
    {
        Gestion f = null;
            public sign_up()
        {
            InitializeComponent();
            panel2.Enabled = false;
            
        }
        public sign_up(Gestion a)
        {
            f = a;
            InitializeComponent();
            panel2.Enabled = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(suivant.Text == "Terminer") suivant.Text = "Tester";
            panel1.Enabled = true;
            panel2.Enabled = false;
        }

        private void suivant_Click(object sender, EventArgs e)
        {
          
              if (suivant.Text == "Tester")
            {
                if (c_SGBD.Text.Length > 0 && t_SN.Text.Length > 0 && t_host.Text.Length > 0 && t_port.Text.Length > 0 )
                {
                    panel1.Enabled = false;
                    panel2.Enabled = true;

                    XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", "no"),
                                            new XElement("database_connection_parameters"));
                    XElement root = doc.Root;

                    root.Add(new XAttribute("DB_CONNECTION", c_SGBD.Text));
                    root.Add(new XAttribute("DB_HOST", t_host.Text));
                    root.Add(new XAttribute("DB_PORT", t_port.Text));
                    root.Add(new XAttribute("DB_DATABASE", t_SN.Text));
                    root.Add(new XAttribute("DB_USERNAME", t_log.Text));
                    root.Add(new XAttribute("DB_PASSWORD", t_pwd.Text));

                    doc.Save(@".\env.xml");
                    try { Connection.Connect(); }
                    catch(Exception ex) { MessageBox.Show(ex.Message); return; }
                   
                    suivant.Text = "Terminer";
                        return;
                       
                }
                else MessageBox.Show("il faut remplir tout le formulaire !!!!!!!!!!!!!!!!");

            }
            else

              if (suivant.Text == "Terminer")
            {
              

                if (c_SGBD.Text.Length > 0 && t_SN.Text.Length > 0 && t_host.Text.Length > 0 && t_port.Text.Length > 0 )
                {
                    MessageBox.Show("vous avez bien creer un compte ! ");
                    this.Close();
                }

            }
            if (t_log.Text.Length > 0 && t_pwd.Text.Length >= 0 && t_conf.Text.Length >= 0)
            {
                if (t_pwd.Text == t_conf.Text)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = true;
                    suivant.Text = "Tester";
                    return;
                }
                else MessageBox.Show("le password est incorrecte !!!!!!!!!!!!!!!!");
            }

        }

        private void sign_up_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void sign_up_Load(object sender, EventArgs e)
        {


            try
            {
                string filePath = "./env.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                // Get the root element
                XmlElement root = xmlDoc.DocumentElement;
                c_SGBD.SelectedItem = root.GetAttribute("DB_CONNECTION");
                t_host.Text= root.GetAttribute("DB_HOST");
                t_SN.Text= root.GetAttribute("DB_DATABASE");
                t_log.Text= root.GetAttribute("DB_USERNAME");
                t_pwd.Text= root.GetAttribute("DB_PASSWORD");
                t_port.Text = root.GetAttribute("DB_PORT");
            }
            catch (Exception ex)
            {
                
            }





            System.Object[] ItemObject = new System.Object[2];

            ItemObject[0] = "mysql";
            ItemObject[1] = "oracle";
            c_SGBD.Items.AddRange(ItemObject);
        }

        private void c_SGBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(c_SGBD.Text=="mysql")
            {
                label6.Text = "database name ";
             /*   label4.Enabled= false;
                t_port.Enabled= false;
                label4.Visible= false;
                t_port.Visible= false;*/
                return;
            }
            label6.Text = "service name ";
           /* label4.Enabled = true;
            t_port.Enabled = true;
            label4.Visible = true;
            t_port.Visible = true;*/
        }

        private void sign_up_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (f != null)
            {
                if (f.Enabled == false) f.Enabled = true;
                f.Sg = null;
                return;
            }
            f = new Gestion();
            f.ShowDialog();
        }
    }
}
