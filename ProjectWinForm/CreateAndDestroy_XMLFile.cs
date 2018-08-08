using System;
using System.IO;
using System.Xml;
using System.Text;

/*
StreamReader sr = File.OpenText("Entries.txt");

XmlDocument xmlDoc = new XmlDocument();
XmlDeclaration xmlDecl = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);

xmlDoc.AppendChild(xmlDecl);

            XmlElement entriesElement = xmlDoc.CreateElement("entries");

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] fields = line.Split('|');

                XmlElement entryElement = xmlDoc.CreateElement("entry");
                entryElement.SetAttribute("type", fields[0]);

                                XmlElement amountElement = xmlDoc.CreateElement("amount");
                amountElement.InnerText = fields[1];
                                XmlElement dateElement = xmlDoc.CreateElement("date");
                dateElement.InnerText = fields[2];
                                XmlElement descriptionElement = xmlDoc.CreateElement("description");
                descriptionElement.InnerText = fields[3];
                                XmlElement categoryElement = xmlDoc.CreateElement("category");
                categoryElement.InnerText = fields[4];


                entryElement.AppendChild(amountElement);
                entryElement.AppendChild(dateElement);
                entryElement.AppendChild(descriptionElement);
                entryElement.AppendChild(categoryElement);

                entriesElement.AppendChild(entryElement);

            }

            xmlDoc.AppendChild(entriesElement);
            xmlDoc.Save("Eentries.xml");

            sr.Close();
*/

