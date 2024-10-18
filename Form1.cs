using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XDocument_Sample
{
    public partial class Form1 : Form
    {

        readonly string file = "Sample.xml";
        readonly string xml = @"xml.xml";
        private string caliste = @"listen\ca-liste.txt";
        string interliste = @"listen\inter-liste.txt";
        string serverliste = @"listen\server-liste.txt";
        string userliste = @"listen\user-liste.txt";
        int CAident = Properties.Settings.Default.CAID;
        int Intident = Properties.Settings.Default.InterID;
        int Servident = Properties.Settings.Default.ServerID;
        int Usrident = Properties.Settings.Default.UserID;

        /// <summary>
        /// reads the CA-List
        /// </summary>
        /// <param name="refresh">clears upfront the listBox</param>
        public void Cblist_read(bool refreshList)
        {
            using (StreamReader sr = new StreamReader(caliste))
            {
                if (refreshList)
                {
                    lb_caliste.Items.Clear();
                }
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    lb_caliste.Items.Add(line); // Use line.
                }
            }
            lb_caliste.Sorted = true;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void bt_clist_write_Click(object sender, EventArgs e)
        {
            if (!lb_caliste.Items.Cast<string>().Contains(textBox1.Text))

            {
                MessageBox.Show("no duplicate");
            }
            else
            {
                MessageBox.Show("duplicate");
                return;
            };
            StreamWriter sw = new StreamWriter(caliste, true);
            sw.WriteLine(textBox1.Text);
            sw.Close();

            Cblist_read(true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Cblist_read(false);

            bool v = true;
            if (!v)
            {
                XDocument doc =
                  new XDocument(
                    new XElement("file",
                      new XElement("name", new XAttribute("filename", "sample")),
                      new XElement("date", new XAttribute("modified", DateTime.Now)),

                      // From here the CA Section
                      new XElement("CA",
                        new XElement("name", "Sample-CA"),
                        new XAttribute("Name", "TestPL"),
                        new XElement("type", "CA"),
                        new XElement("id", "0"),
                        new XElement("Private",
                            new XElement("Bits", "4096"),
                            new XElement("Pass", "passwortca"),
                            new XElement("file", "Sample-CA.key.pem")
                        ),
                        new XElement("Public",
                            new XElement("duration", "7300"),
                            new XElement("pass", "passwortca"),
                            new XElement("cnf", "openssl-ca.cnf"),
                            new XElement("subj",
                              new XElement("C", "DE"),
                              new XElement("ST", "Bavaria"),
                              new XElement("L", "Hausen"),
                              new XElement("OU", "IT"),
                              new XElement("CN", "Lang-CA"),
                              new XElement("email", "admin@admin.de")
                              )
                        )
                      ),

                      // From here the Intermediate Section
                      new XElement("Intermediate",
                        new XElement("name", "Sample-Intermediate"),
                        new XElement("type", "Intermediate"),
                        new XElement("id", "1"),
                        new XElement("Private",
                            new XElement("Bits", "4096"),
                            new XElement("pass", "passwortint")
                        ),
                        new XElement("CSR",
                          new XElement("cnf", "openssl-int.cnf"),
                          new XElement("pass_priv", "passwortint"),
                          new XElement("subj",
                              new XElement("C", "DE"),
                              new XElement("ST", "Bavaria"),
                              new XElement("L", "Hausen"),
                              new XElement("OU", "IT"),
                              new XElement("CN", "Lang-Intermediate"),
                              new XElement("email", "admin@admin.de")
                              )
                        ),
                        new XElement("Sign",
                            new XElement("cnf-ca", "openssl-ca.cnf"),
                            new XElement("duration", "3650"),
                            new XElement("CA",
                              new XElement("id", "0"),
                              new XElement("passCa", "passwordca")
                              )
                            )
                        ),
                      // From here server section
                      new XElement("Server",
                        new XElement("name", "Sample-Server"),

                        new XElement("type", "Server"),
                        new XElement("id", "1"),
                        new XElement("Private",

                            new XElement("Bits", "4096"),
                            new XElement("pass", "")
                            ),
                        new XElement("CSR",
                          new XElement("pass_priv", ""),
                          new XElement("subj",
                              new XElement("C", "DE"),
                              new XElement("ST", "Bavaria"),
                              new XElement("L", "Hausen"),
                              new XElement("OU", "IT"),
                              new XElement("CN", "Lang-Server"),
                              new XElement("email", "admin@admin.de")
                          ),
                          new XElement("SAN",
                            new XElement("DNS.1", "SAN"),
                            new XElement("IP.1", "192.168.1.1")
                            )
                        ),
                        new XElement("Sign",
                            new XElement("cnf", "openssl-int.cnf"),
                            new XElement("duration", "365"),
                            new XElement("passInt", "passwordint"),
                            new XElement("Intermediate",
                                new XElement("id", "1"),
                                new XElement("passInt", "passwordint")
                                )
                            )
                        )
                      )
                  );

                doc.Save(xml);
            }

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    XDocument doc = XDocument.Load("Sample.xml");
        //    //IEnumerable<XElement> elements = doc.Root.Elements("name");
        //    //foreach (XElement element in elements)
        //    //{
        //    //    // Process each element here
        //    //    MessageBox.Show(element.ToString(), "name", MessageBoxButtons.OK);
        //    //}
        //    XElement element = doc.Root.Element("data");
        //    MessageBox.Show(element.ToString(), "name", MessageBoxButtons.OK);
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{

        //    //var doc = XElement.Load(file);
        //    //var saveGame = doc
        //    //     .Element("file")
        //    //     .Elements("server")
        //    //     .Where(e => e.Element("name").Value == "Docker")
        //    //     .Single();

        //    //saveGame.Element("duration").Value = "50";

        //    //doc.Save(file);

        //    XDocument xmlDocument = XDocument.Load(file);
        //    XElement elementToReplace = xmlDocument.Descendants("name").FirstOrDefault();
        //    elementToReplace.Value = "NewValue";
        //    xmlDocument.Save(file);

        //}

        private void Createxml_Click(object sender, EventArgs e)
        {

            XDocument doc =
              new XDocument(
                new XElement("file",
                  new XElement("name", new XAttribute("filename", "sample")),
                  new XElement("date", new XAttribute("modified", DateTime.Now), new XAttribute("hallo", "dsd")),

                  // From here the CA Section
                  new XElement("CA",
                    new XElement("Sample-CA",
                    new XElement("type", "CA"),
                    new XElement("id", "0"),
                    new XElement("Private",
                        new XElement("Bits", "4096"),
                        new XElement("Pass", "passwortca"),
                        new XElement("file", "Sample-CA.key.pem")
                    ),
                    new XElement("Public",
                        new XElement("duration", "7300"),
                        new XElement("pass", "passwortca"),
                        new XElement("cnf", "openssl-ca.cnf"),
                        new XElement("subj",
                          new XElement("C", "DE"),
                          new XElement("ST", "Bavaria"),
                          new XElement("L", "Hausen"),
                          new XElement("OU", "IT"),
                          new XElement("CN", "Lang-CA"),
                          new XElement("email", "admin@admin.de")
                          )
                    )
                    )
                  ),
                  // From here the Intermediate Section
                  new XElement("Intermediate",
                    new XElement("name", "Sample-Intermediate"),
                    new XElement("type", "Intermediate"),
                    new XElement("id", "1"),
                    new XElement("Private",
                        new XElement("Bits", "4096"),
                        new XElement("pass", "passwortint")
                    ),
                    new XElement("CSR",
                      new XElement("cnf", "openssl-int.cnf"),
                      new XElement("pass_priv", "passwortint"),
                      new XElement("subj",
                          new XElement("C", "DE"),
                          new XElement("ST", "Bavaria"),
                          new XElement("L", "Hausen"),
                          new XElement("OU", "IT"),
                          new XElement("CN", "Lang-Intermediate"),
                          new XElement("email", "admin@admin.de")
                          )
                    ),
                    new XElement("Sign",
                        new XElement("cnf-ca", "openssl-ca.cnf"),
                        new XElement("duration", "3650"),
                        new XElement("CA",
                          new XElement("id", "0"),
                          new XElement("passCa", "passwordca")
                          )
                        )
                    ),
                  // From here server section
                  new XElement("Server",
                    new XElement("name", "Sample-Server"),

                    new XElement("type", "Server"),
                    new XElement("id", "1"),
                    new XElement("Private",

                        new XElement("Bits", "4096"),
                        new XElement("pass", "")
                        ),
                    new XElement("CSR",
                      new XElement("pass_priv", ""),
                      new XElement("subj",
                          new XElement("C", "DE"),
                          new XElement("ST", "Bavaria"),
                          new XElement("L", "Hausen"),
                          new XElement("OU", "IT"),
                          new XElement("CN", "Lang-Server"),
                          new XElement("email", "admin@admin.de")
                      ),
                      new XElement("SAN",
                        new XElement("DNS.1", "SAN"),
                        new XElement("IP.1", "192.168.1.1")
                        )
                    ),
                    new XElement("Sign",
                        new XElement("cnf", "openssl-int.cnf"),
                        new XElement("duration", "365"),
                        new XElement("passInt", "passwordint"),
                        new XElement("Intermediate",
                            new XElement("id", "1"),
                            new XElement("passInt", "passwordint")
                            )
                        )
                    )
                  )
              );

            doc.Save("xml.xml");
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            //XDocument xmlDocument = XDocument.Load("xml.xml");
            //XElement elementToReplace = xmlDocument.Descendants("name").ElementAt(1);
            //elementToReplace.Value = textBox3.Text;
            //xmlDocument.Save("xml.xml");

            XDocument doc = XDocument.Load("xml.xml");

            XElement penItemValue = doc
                 .Elements("file")
                 .Elements("Server")
                 .Elements("name")
                 .Single(name => name.Value == "Sample-Server");
            penItemValue.Value = textBox3.Text;
            //Element penItemValue = doc
            //     .Elements("file")
            //     .Elements("Server")
            //     .Elements("name")
            //     .Single(name => name.Value == "Sample-Server")
            //     .Parent
            //     .Element("id");
            //penItemValue.Value = textBox3.Text;

            doc.Save("xml.xml");
        }

        private void AddServer_Click(object sender, EventArgs e)
        {

            XDocument doc = XDocument.Load(xml);
            doc.Root.Element("CA").Add(
               new XElement("name", "Sample-CA"),
                    new XElement("type", "CA"),
                    new XElement("id", "0"),
                    new XElement("Private",
                        new XElement("Bits", "4096"),
                        new XElement("Pass", "passwortca"),
                        new XElement("file", "Sample-CA.key.pem")
                    ),
                    new XElement("Public",
                        new XElement("duration", "7300"),
                        new XElement("pass", "passwortca"),
                        new XElement("cnf", "openssl-ca.cnf"),
                        new XElement("subj",
                          new XElement("C", "DE"),
                          new XElement("ST", "Bavaria"),
                          new XElement("L", "Hausen"),
                          new XElement("OU", "IT"),
                          new XElement("CN", "Lang-CA"),
                          new XElement("email", "admin@admin.de")
                          )
                    )
                );
            doc.Save(xml);
        }

        private void Bt_delete_Click(object sender, EventArgs e)
        {
            string line;
            string line_to_delete = lb_caliste.SelectedItem.ToString();
            string calistetmp = "caliste.tmp";

            try
            {
                using (StreamReader reader = new StreamReader(caliste))
                {
                    using (StreamWriter writer = new StreamWriter(calistetmp))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (String.Compare(line, line_to_delete) == 0)
                                continue;

                            writer.WriteLine(line);
                        }
                    }
                }
                File.Move(calistetmp, caliste);
                File.Delete(calistetmp);
                Cblist_read(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sender.ToString());


            }
        }

        private void findServer_Click(object sender, EventArgs e)
        {
            string tmp = lb_caliste.SelectedItem.ToString();
            //XDocument doc = XDocument.Load("xml.xml");
            //IEnumerable<XElement> elements = doc.Descendants(tmp);

            //StreamWriter sw = new StreamWriter("tmp.txt");
            //sw.WriteLine(elements);
            //sw.Close();
            //MessageBox.Show("Found ");
            XDocument doc = XDocument.Load("xml.xml");
            var elements = doc.Descendants(tmp);

                StreamWriter sw = new StreamWriter("tmp.txt");
            foreach (var element in elements)
            {
                // Do something with the element
                sw.WriteLine(element);
                
            }
sw.Close();

        }
    }

}