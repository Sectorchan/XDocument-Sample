using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XDocument_Sample
{
    class CreateXml
    {
        string file = "xml.xml";
        
        public CreateXml(string xml) {

            XDocument doc =
              new XDocument(
                new XElement("file",
                  new XElement("name", new XAttribute("filename", "sample")),
                  new XElement("date", new XAttribute("modified", DateTime.Now), new XAttribute("hallo", "dsd")),

                  // From here the CA Section
                  new XElement("CA",
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
}
