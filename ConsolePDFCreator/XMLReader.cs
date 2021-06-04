using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsolePDFCreator
{
    public class XMLReader
    {
        //On here recive the XML Document 
        public static string[] Reader(string XMLDocument)
        {
            string[] ArrayListData = new string[1];
            //Obtainet the name of the documetnt
            string DocumentName = Path.GetFileName(XMLDocument);
            //Create variables what contains the values of the XML
            string[] XMLValues = new string [13];
            int counter = 0;
            //Start with the reading of the XML Document
            XmlTextReader xmlReader = new XmlTextReader(XMLDocument);
            //XmlReader xmlReader = XmlReader.Create(new StringReader(XMLDocument));
            while (xmlReader.Read())
			{
				switch (xmlReader.NodeType)
				{
					case XmlNodeType.Element:
						while (xmlReader.MoveToNextAttribute())
						{
							//Read the value of Serie
							if (xmlReader.Name.Equals("Serie") || xmlReader.Name.Equals("serie"))
							{
                                if (XMLValues[counter] == null)
                                {
                                    XMLValues[counter] = xmlReader.Value;
                                    counter++;
                                }
							}
							//Read the value of Folio
                            else if (xmlReader.Name.Equals("Folio") || xmlReader.Name.Equals("folio"))
                            {
                                if (XMLValues[counter] == null)
                                {
                                    XMLValues[counter] = xmlReader.Value;
                                    counter++;
                                }
                            }
                            //Read the value of SubTotal
                            else if (xmlReader.Name.Equals("SubTotal") || xmlReader.Name.Equals("subtotal") || xmlReader.Name.Equals("subTotal") || xmlReader.Name.Equals("Subtotal"))
                            {
                                XMLValues[counter] = xmlReader.Value;
                                counter++;
                            }
                            //Read the value of Moneda
                            else if (xmlReader.Name.Equals("Moneda") || xmlReader.Name.Equals("moneda"))
                            {
                                XMLValues[counter] = xmlReader.Value;
                                counter++;
                            }
                            //Read the value of Total
                            else if (xmlReader.Name.Equals("Total") || xmlReader.Name.Equals("total"))
                            {
                                XMLValues[counter] = xmlReader.Value;
                                counter++;
                            }
                            //Read the value of RFC
                            else if (xmlReader.Name.Equals("RFC") || xmlReader.Name.Equals("Rfc") || xmlReader.Name.Equals("rfc"))
                            {
                                XMLValues[counter] = xmlReader.Value;
                                counter++;
                            }
                            //Read the value of Nombre
                            else if (xmlReader.Name.Equals("Nombre") || xmlReader.Name.Equals("nombre"))
                            {
                                XMLValues[counter] = xmlReader.Value;
                                counter++;
                            }
                            //Read the value of Clave producto o servicio
                            else if (xmlReader.Name.Equals("ClaveProdServ") || xmlReader.Name.Equals("claveprodserv"))
                            {
                                XMLValues[counter] = xmlReader.Value;
                                counter++;
                            }
                            //Read the value  of Clave Unidad 
                            else if (xmlReader.Name.Equals("ClaveUnidad") || xmlReader.Name.Equals("claveunidad"))
                            {
                                XMLValues[counter] = xmlReader.Value;
                                counter++;
                            }
                            //Read the value  of Unidad 
                            else if (xmlReader.Name.Equals("Unidad") || xmlReader.Name.Equals("unidad"))
                            {
                                XMLValues[counter] = xmlReader.Value;
                                counter++;
                            }
                            //Read the value  of Descripcion 
                            else if (xmlReader.Name.Equals("Descripcion") || xmlReader.Name.Equals("descripcion"))
                            {
                                XMLValues[counter] = xmlReader.Value;
                                counter++;
                            }
                           
                        }
						break;
				}
			}

            return XMLValues;

        }
    }
}
