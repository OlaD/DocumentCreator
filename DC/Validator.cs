using System.Windows.Forms;
using System.Xml.Schema;
using System.Xml;
using System;
using System.Text;

namespace DC
{
				class Validator
				{
								bool xmlValid;
								bool nodeNotValid;
								bool detailMessage;

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
												message.AppendLine("Błędne pola:\n");
												foreach (Fields.Field field in Enum.GetValues(typeof(Fields.Field)))
												{
																nodeNotValid = false;
																XmlNode node = xml.SelectSingleNode(Fields.fieldsPaths[field]);
																if(node != null)
																{
																				xml.Validate(eventHandler, node);
																				if (nodeNotValid)
																				{
																								message.AppendLine(Fields.fieldsMessages[field]);
																				}
																}
																else
																{
																				nodeNotValid = true;
																				xmlValid = false;
																				message.AppendLine("Uzyskane tytuły: kandydat musi mieć uzyskany przynajmniej jeden tytuł zawodowy.");
																}
												}

												if (!xmlValid)
												{
																MessageBox.Show(message.ToString(), "Błąd", MessageBoxButtons.OK);
												}
								}

								public string ValidNode(Fields.Field field, XmlDocument xml)
								{
												//xmlValid = true;
												xml.Schemas.Add(null, "schema.xsd");

												ValidationEventHandler eventHandler = new ValidationEventHandler(validationNodeEvent);

												string message = "";

												nodeNotValid = false;
												XmlNode node = xml.SelectSingleNode(Fields.fieldsPaths[field]);

												if (node != null)
												{
																xml.Validate(eventHandler, node);
																if (nodeNotValid)
																{
																				message = Fields.fieldsMessages[field];
																}
												}
												else
												{
																nodeNotValid = true;
																xmlValid = false;
																message = "Uzyskane tytuły: kandydat musi mieć uzyskany przynajmniej jeden tytuł zawodowy.";
												}

												return message;
								}

								void validationNodeEvent(object sender, ValidationEventArgs e)
								{
												xmlValid = false;
												nodeNotValid = true;
								}

								public bool ValidateAll(XmlDocument xml, bool detailMessage = true)
								{
												xmlValid = true;
												xml.Schemas.Add(null, "schema.xsd");

												this.detailMessage = detailMessage;
												ValidationEventHandler eventHandler = new ValidationEventHandler(validationAllEvent);
												xml.Validate(eventHandler);

												return xmlValid;
								}

								void validationAllEvent(object sender, ValidationEventArgs e)
								{
												xmlValid = false;
												string message;
												if(detailMessage)
												{
																message = e.Message;
												}
												else
												{
																message = "Błędny dokument";
												}
												MessageBox.Show(message, "Błąd", MessageBoxButtons.OK);
								}
				}
}
