using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlToPDF;

namespace projet
{
    public partial class xml_to_pdf : Form
    {
        private string _selectedClass = "";
        public xml_to_pdf()
        {
            InitializeComponent();

            // Add items to existing ComboBox control
            comboBox.Items.Add("Filieres");
            comboBox.Items.Add("Eleves");
            comboBox.Items.Add("Modules");
            comboBox.Items.Add("Matieres");
            comboBox.Items.Add("Notes");
            //comboBox.Items.Add("Moyennes");

            // Attach the event handler for SelectedIndexChanged event
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
        }

        private void xml_to_pdf_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedClass = comboBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(_selectedClass))
            {
                MessageBox.Show("File selected. Click the 'ToPDF' button to convert to PDF.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xmlFilePath = $"./xmllog/{_selectedClass.ToLower()}.xml";
            string pdfFilePath = $"./xmllog/{_selectedClass.ToLower()}.pdf";

            switch (_selectedClass)
            {
                case "Filieres":
                    XmlToPdfConverter.ConvertFiliereToPdf(xmlFilePath, pdfFilePath);
                    break;
                case "Eleves":
                    XmlToPdfConverter.ConvertEtudiantToPdf(xmlFilePath, pdfFilePath);
                    break;
                case "Modules":
                    XmlToPdfConverter.ConvertModuleToPdf(xmlFilePath, pdfFilePath);
                    break;
                case "Matieres":
                    XmlToPdfConverter.ConvertMatiereToPdf(xmlFilePath, pdfFilePath);
                    break;
                case "Notes":
                    XmlToPdfConverter.ConvertNotesToPdf(xmlFilePath, pdfFilePath);
                    break;
                /*case "Moyennes":
                    XmlToPdfConverter.ConvertMoyennesToPdf(xmlFilePath, pdfFilePath);
                    break;*/
                default:
                    return;
            }
            Process.Start(pdfFilePath);

            // MessageBox.Show("Conversion completed successfully!");
        }
    }
}
