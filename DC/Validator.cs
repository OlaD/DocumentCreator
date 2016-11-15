using System.Windows.Forms;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System;
using System.Text;

namespace DC
{
				class Validator
				{
								bool xmlValid;
								bool nodeNotValid;

								public bool Validate(XmlDocument xml)
								{
												xmlValid = true;
												xml.Schemas.Add(null, "schema.xsd");

												ValidateSingleNodes(xml);
												// jeśli walidacja pojedynczych węzłów nic nie wykryje, dla pewności przeprowadzamy walidację całego dokumentu
												if(xmlValid)
												{
																ValidateAll(xml);
												}

												return xmlValid;
								}

								void ValidateSingleNodes(XmlDocument xml)
								{
												ValidationEventHandler eventHandler = new ValidationEventHandler(validationNodeEvent);
												StringBuilder message = new StringBuilder();
												message.AppendLine("Błędy:");
												foreach (Fields.Field field in Enum.GetValues(typeof(Fields.Field)))
												{
																nodeNotValid = false;
																XmlNode node = xml.SelectSingleNode(Fields.fieldsPaths[field]);
																xml.Validate(eventHandler, node);
																if (nodeNotValid)
																{
																				message.AppendLine(Fields.fieldsMessages[field]);
																}
												}
												if(!xmlValid)
												{
																MessageBox.Show(message.ToString(), "Błąd", MessageBoxButtons.OK);
												}
								}

								void validationNodeEvent(object sender, ValidationEventArgs e)
								{
												xmlValid = false;
												nodeNotValid = true;
								}

								void ValidateAll(XmlDocument xml)
								{
												ValidationEventHandler eventHandler = new ValidationEventHandler(validationAllEvent);
												xml.Validate(eventHandler);
								}

								void validationAllEvent(object sender, ValidationEventArgs e)
								{
												xmlValid = false;
												MessageBox.Show(e.Message, "Błąd", MessageBoxButtons.OK);
								}
				}
}
