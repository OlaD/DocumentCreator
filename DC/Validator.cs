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
												xml.Schemas.Add(null, "schema.xsd");
												ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventCallback);

												xmlValid = true;

												StringBuilder message = new StringBuilder();
												message.AppendLine("Błędy:");
												foreach ( Fields.Field field in Enum.GetValues(typeof(Fields.Field)) )
												{
																nodeNotValid = false;
																XmlNode node = xml.SelectSingleNode(Fields.fieldsPaths[field]);
																xml.Validate(eventHandler, node);
																if (nodeNotValid)
																{
																				message.AppendLine(Fields.fieldsMessages[field]);
																}
												}
												MessageBox.Show(message.ToString(), "Błąd", MessageBoxButtons.OK);

												return xmlValid;
								}

								void ValidationEventCallback(object sender, ValidationEventArgs e)
								{
												xmlValid = false;
												nodeNotValid = true;
								}
				}
}
