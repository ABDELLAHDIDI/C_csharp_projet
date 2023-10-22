using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Globalization;

namespace XmlToPDF
{
    public static class XmlToPdfConverter
    {
        public static void ConvertEtudiantToPdf(string xmlFilePath, string pdfFilePath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFilePath);

            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30))
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                    pdfDoc.Open();

                    // Add title
                    string title = "Etudiant List";

                    // Create a page header with the title

                    PdfPTable headerTable = new PdfPTable(1);
                    headerTable.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                  /* PdfPCell headerCell = new PdfPCell(new Phrase(title, new Font(Font.FontFamily.HELVETICA, 20f, Font.BOLD)));
                    headerCell.Border = 0;
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerTable.AddCell(headerCell);*/

                    // Add space between title and table
                    pdfDoc.Add(headerTable);
                    pdfDoc.Add(new Paragraph("\n\n\n\n"));

                    // Create the PDF table
                    PdfPTable pdfTable = new PdfPTable(7);
                    pdfTable.WidthPercentage = 100;
                    pdfTable.SpacingBefore = 10f;
                    pdfTable.SpacingAfter = 10f;

                    // Add the table headers
                    pdfTable.AddCell("opr");
                    pdfTable.AddCell("ID");
                    pdfTable.AddCell("nom");
                    pdfTable.AddCell("prenom");
                    pdfTable.AddCell("niveau");
                    pdfTable.AddCell("code_fil");
                    pdfTable.AddCell("date");

                    // Sort the student nodes by timestamp attribute in ascending order
                    XmlNodeList studentList = xmlDocument.SelectNodes("//etudiant[@timestamp]");
                    List<XmlNode> studentNodes = new List<XmlNode>();
                    foreach (XmlNode studentNode in studentList)
                    {
                        studentNodes.Add(studentNode);
                    }
                    List<XmlNode> sortedStudentNodes = studentNodes.OrderByDescending(n => DateTime.Parse(n.Attributes["timestamp"].Value)).ToList();


                    // Add the table rows

                    foreach (XmlNode studentNode in sortedStudentNodes)
                    {
                        string opr = studentNode.Attributes["opr"].Value;
                        string date = studentNode.Attributes["timestamp"].Value;
                        string id = "";
                        string nom = "";
                        string prenom = "";
                        string niveau = "";
                        string code_fil = "";

                        if (opr == "update")
                        {
                            id = studentNode.SelectSingleNode("id").SelectSingleNode("newValue").InnerText;
                            nom = studentNode.SelectSingleNode("nom").SelectSingleNode("newValue").InnerText;
                            prenom = studentNode.SelectSingleNode("prenom").SelectSingleNode("newValue").InnerText;
                            niveau = studentNode.SelectSingleNode("niveau").SelectSingleNode("newValue").InnerText;
                            code_fil = studentNode.SelectSingleNode("code_fil").SelectSingleNode("newValue").InnerText;

                        }
                        else
                        {
                            id = studentNode.SelectSingleNode("id").InnerText;
                            nom = studentNode.SelectSingleNode("nom").InnerText;
                            prenom = studentNode.SelectSingleNode("prenom").InnerText;
                            niveau = studentNode.SelectSingleNode("niveau").InnerText;
                            code_fil = studentNode.SelectSingleNode("code_fil").InnerText;
                        }



                        pdfTable.AddCell(opr);
                        pdfTable.AddCell(id);
                        pdfTable.AddCell(nom);
                        pdfTable.AddCell(prenom);
                        pdfTable.AddCell(niveau);
                        pdfTable.AddCell(code_fil);
                        pdfTable.AddCell(date);
                    }

                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();
                }
            }
        }

        public static void ConvertFiliereToPdf(string xmlFilePath, string pdfFilePath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFilePath);

            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30))
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                    pdfDoc.Open();

                    // Add title
                    string title = "Filiere List";

                    // Create a page header with the title
                    PdfPTable headerTable = new PdfPTable(1);
                    headerTable.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                   /* PdfPCell headerCell = new PdfPCell(new Phrase(title, new Font(Font.FontFamily.HELVETICA, 20f, Font.BOLD)));
                    headerCell.Border = 0;
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;*/
                   // headerTable.AddCell(headerCell);

                    // Add space between title and table
                    pdfDoc.Add(headerTable);
                    pdfDoc.Add(new Paragraph("\n\n\n\n"));

                    // Create the PDF table
                    PdfPTable pdfTable = new PdfPTable(5);
                    pdfTable.WidthPercentage = 100;
                    pdfTable.SpacingBefore = 10f;
                    pdfTable.SpacingAfter = 10f;

                    // Add the table headers
                    pdfTable.AddCell("opr");
                    pdfTable.AddCell("id");
                    pdfTable.AddCell("code");
                    pdfTable.AddCell("designation");
                    pdfTable.AddCell("date");

                    // Sort the filiere nodes by timestamp attribute in ascending order
                    XmlNodeList filiereList = xmlDocument.SelectNodes("//Filiere[@timestamp]");
                    List<XmlNode> filiereNodes = new List<XmlNode>();
                    foreach (XmlNode filiereNode in filiereList)
                    {
                        filiereNodes.Add(filiereNode);
                    }
                    List<XmlNode> sortedFiliereNodes = filiereNodes.OrderByDescending(n => DateTime.Parse(n.Attributes["timestamp"].Value)).ToList();

                    // Add the table rows
                    foreach (XmlNode filiereNode in sortedFiliereNodes)
                    {
                        string date = filiereNode.Attributes["timestamp"].Value;
                        string opr = filiereNode.Attributes["opr"].Value;
                        string id = "";
                        string code = "";
                        string designation = "";

                        if (opr == "update")
                        {
                            id = filiereNode.SelectSingleNode("id").SelectSingleNode("newValue").InnerText;
                            code = filiereNode.SelectSingleNode("code").SelectSingleNode("newValue").InnerText;
                            designation = filiereNode.SelectSingleNode("designation").SelectSingleNode("newValue").InnerText;

                        }
                        else
                        {
                            id = filiereNode.SelectSingleNode("id").InnerText;
                            code = filiereNode.SelectSingleNode("code").InnerText;
                            designation = filiereNode.SelectSingleNode("designation").InnerText;

                        }



                        pdfTable.AddCell(opr);
                        pdfTable.AddCell(id);
                        pdfTable.AddCell(code);
                        pdfTable.AddCell(designation);
                        pdfTable.AddCell(date);
                    }

                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();
                }
            }
        }


        public static void ConvertModuleToPdf(string xmlFilePath, string pdfFilePath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFilePath);

            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30))
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                    pdfDoc.Open();

                    // Add title
                    string title = "Module List";

                    // Create a page header with the title
                    PdfPTable headerTable = new PdfPTable(1);
                    headerTable.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                 /*   PdfPCell headerCell = new PdfPCell(new Phrase(title, new Font(Font.FontFamily.HELVETICA, 20f, Font.BOLD)));
                    headerCell.Border = 0;
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerTable.AddCell(headerCell);*/

                    // Add space between title and table
                    pdfDoc.Add(headerTable);
                    pdfDoc.Add(new Paragraph("\n\n\n\n"));

                    // Create the PDF table
                    PdfPTable pdfTable = new PdfPTable(8);
                    pdfTable.WidthPercentage = 100;
                    pdfTable.SpacingBefore = 10f;
                    pdfTable.SpacingAfter = 10f;

                    // Add the table headers
                    pdfTable.AddCell("opr");
                    pdfTable.AddCell("ID");
                    pdfTable.AddCell("code");
                    pdfTable.AddCell("designation");
                    pdfTable.AddCell("semestre");
                    pdfTable.AddCell("niveau");
                    pdfTable.AddCell("code_fil");
                    pdfTable.AddCell("date");

                    // Sort the module nodes by timestamp attribute in ascending order
                    XmlNodeList moduleList = xmlDocument.SelectNodes("//Module[@timestamp]");
                    List<XmlNode> moduleNodes = new List<XmlNode>();
                    foreach (XmlNode moduleNode in moduleList)
                    {
                        moduleNodes.Add(moduleNode);
                    }
                    List<XmlNode> sortedModuleNodes = moduleNodes.OrderByDescending(n => DateTime.Parse(n.Attributes["timestamp"].Value)).ToList();

                    // Add the table rows
                    foreach (XmlNode moduleNode in sortedModuleNodes)
                    {
                        string opr = moduleNode.Attributes["opr"].Value;
                        string date = moduleNode.Attributes["timestamp"].Value;
                        string id = "";
                        string code = "";
                        string designation = "";
                        string semestre = "";
                        string niveau = "";
                        string code_fil = "";
                        if (opr == "update")
                        {
                            id = moduleNode.SelectSingleNode("id").SelectSingleNode("newValue").InnerText;
                            code = moduleNode.SelectSingleNode("code").SelectSingleNode("newValue").InnerText;
                            designation = moduleNode.SelectSingleNode("designation").SelectSingleNode("newValue").InnerText;
                            semestre = moduleNode.SelectSingleNode("semestre").SelectSingleNode("newValue").InnerText;
                            niveau = moduleNode.SelectSingleNode("niveau").SelectSingleNode("newValue").InnerText;
                            code_fil = moduleNode.SelectSingleNode("code_fil").SelectSingleNode("newValue").InnerText;

                        }
                        else
                        {
                            id = moduleNode.SelectSingleNode("id").InnerText;
                            code = moduleNode.SelectSingleNode("code").InnerText;
                            designation = moduleNode.SelectSingleNode("designation").InnerText;
                            semestre = moduleNode.SelectSingleNode("semestre").InnerText;
                            niveau = moduleNode.SelectSingleNode("niveau").InnerText;
                            code_fil = moduleNode.SelectSingleNode("code_fil").InnerText;

                        }



                        pdfTable.AddCell(opr);
                        pdfTable.AddCell(id);
                        pdfTable.AddCell(code);
                        pdfTable.AddCell(designation);
                        pdfTable.AddCell(semestre);
                        pdfTable.AddCell(niveau);
                        pdfTable.AddCell(code_fil);
                        pdfTable.AddCell(date);
                    }

                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();
                }
            }
        }

        public static void ConvertMatiereToPdf(string xmlFilePath, string pdfFilePath)
        {

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFilePath);

            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30))
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                    pdfDoc.Open();

                    // Add title
                    string title = "Matiere List";

                    // Create a page header with the title

                    PdfPTable headerTable = new PdfPTable(1);
                    headerTable.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                   /* PdfPCell headerCell = new PdfPCell(new Phrase(title, new Font(Font.FontFamily.HELVETICA, 20f, Font.BOLD)));
                    headerCell.Border = 0;
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerTable.AddCell(headerCell);*/

                    // Add space between title and table
                    pdfDoc.Add(headerTable);
                    pdfDoc.Add(new Paragraph("\n\n\n\n"));

                    // Create the PDF table
                    PdfPTable pdfTable = new PdfPTable(7);
                    pdfTable.WidthPercentage = 100;
                    pdfTable.SpacingBefore = 10f;
                    pdfTable.SpacingAfter = 10f;

                    // Add the table headers
                    pdfTable.AddCell("opr");
                    pdfTable.AddCell("code");
                    pdfTable.AddCell("designation");
                    pdfTable.AddCell("VH");
                    pdfTable.AddCell("code_module");
                    pdfTable.AddCell("id");
                    pdfTable.AddCell("date");


                    // Sort the matiere nodes by timestamp attribute in ascending order
                    XmlNodeList matiereList = xmlDocument.SelectNodes("//matiere[@timestamp]");
                    List<XmlNode> matiereNodes = new List<XmlNode>();
                    foreach (XmlNode matiereNode in matiereList)
                    {
                        matiereNodes.Add(matiereNode);
                    }
                    List<XmlNode> sortedMatiereNodes = matiereNodes.OrderByDescending(n => DateTime.Parse(n.Attributes["timestamp"].Value)).ToList();


                    // Add the table rows

                    foreach (XmlNode matiereNode in sortedMatiereNodes)
                    {
                        string opr = matiereNode.Attributes["opr"].Value;
                        string date = matiereNode.Attributes["timestamp"].Value;
                        string code = "";
                        string designation = ""; ;
                        string VH = ""; ;
                        string code_module = ""; ;
                        string id = ""; ;

                        if (opr == "update")
                        {
                            code = matiereNode.SelectSingleNode("code").SelectSingleNode("newValue").InnerText;
                            designation = matiereNode.SelectSingleNode("designation").SelectSingleNode("newValue").InnerText;
                            VH = matiereNode.SelectSingleNode("VH").SelectSingleNode("newValue").InnerText;
                            code_module = matiereNode.SelectSingleNode("code_module").SelectSingleNode("newValue").InnerText;
                            id = matiereNode.SelectSingleNode("id").SelectSingleNode("newValue").InnerText;
                        }
                        else
                        {
                            code = matiereNode.SelectSingleNode("code").InnerText;
                            designation = matiereNode.SelectSingleNode("designation").InnerText;
                            VH = matiereNode.SelectSingleNode("VH").InnerText;
                            code_module = matiereNode.SelectSingleNode("code_module").InnerText;
                            id = matiereNode.SelectSingleNode("id").InnerText;
                        }

                        pdfTable.AddCell(opr);
                        pdfTable.AddCell(code);
                        pdfTable.AddCell(designation);
                        pdfTable.AddCell(VH);
                        pdfTable.AddCell(code_module);
                        pdfTable.AddCell(id);
                        pdfTable.AddCell(date);

                    }

                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();
                }
            }
        }

        public static void ConvertNotesToPdf(string xmlFilePath, string pdfFilePath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFilePath);

            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30))
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                    pdfDoc.Open();

                    // Add title
                    string title = "Notes List";

                    // Create a page header with the title
                    PdfPTable headerTable = new PdfPTable(1);
                    headerTable.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                   /* PdfPCell headerCell = new PdfPCell(new Phrase(title, new Font(Font.FontFamily.HELVETICA, 20f, Font.BOLD)));
                    headerCell.Border = 0;
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerTable.AddCell(headerCell);*/

                    // Add space between title and table
                    pdfDoc.Add(headerTable);
                    pdfDoc.Add(new Paragraph("\n\n\n\n"));

                    // Create the PDF table
                    PdfPTable pdfTable = new PdfPTable(6);
                    pdfTable.WidthPercentage = 100;
                    pdfTable.SpacingBefore = 10f;
                    pdfTable.SpacingAfter = 10f;

                    // Add the table headers
                    pdfTable.AddCell("id");
                    pdfTable.AddCell("opr");
                    pdfTable.AddCell("Code Eleve");
                    pdfTable.AddCell("Code Mat");
                    pdfTable.AddCell("Note");
                    pdfTable.AddCell("Date");

                    // Sort the notes nodes by timestamp attribute in ascending order
                    XmlNodeList noteList = xmlDocument.SelectNodes("//notes[@timestamp]");
                    List<XmlNode> noteNodes = new List<XmlNode>();
                    foreach (XmlNode noteNode in noteList)
                    {
                        noteNodes.Add(noteNode);
                    }
                    List<XmlNode> sortedNoteNodes = noteNodes.OrderBy(n => DateTime.Parse(n.Attributes["timestamp"].Value)).ToList();

                    // Add the table rows
                    int id = 1;
                    foreach (XmlNode noteNode in sortedNoteNodes)
                    {
                        string opr = noteNode.Attributes["opr"].Value;
                        string date = noteNode.Attributes["timestamp"].Value;
                        string codeEleve = "";
                        string codeMat = "";
                        string note = "";

                        if (opr == "update")
                        {
                            codeEleve = noteNode.SelectSingleNode("code_eleve").SelectSingleNode("newValue").InnerText;
                            codeMat = noteNode.SelectSingleNode("code_mat").SelectSingleNode("newValue").InnerText;
                            note = noteNode.SelectSingleNode("note").SelectSingleNode("newValue").InnerText;

                        }
                        else
                        {
                            codeEleve = noteNode.SelectSingleNode("code_eleve").InnerText;
                            codeMat = noteNode.SelectSingleNode("code_mat").InnerText;
                            note = noteNode.SelectSingleNode("note").InnerText;
                            date = noteNode.Attributes["timestamp"].Value;
                        }

                        pdfTable.AddCell(id.ToString());
                        pdfTable.AddCell(opr);
                        pdfTable.AddCell(codeEleve);
                        pdfTable.AddCell(codeMat);
                        pdfTable.AddCell(note);
                        pdfTable.AddCell(date);

                        id++;
                    }

                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();
                }
            }
        }


    }

}
