using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC
{
				public partial class ExJobWindow : Form
				{
								public string[] Values { get; set; }

								public enum Operation
								{
												Add,
												Edit
								}

								public ExJobWindow(Operation operation, string[] values = null)
								{
												InitializeComponent();

												Values = new string[4];
												fillYears();

												if (operation == Operation.Edit)
												{
																position.Text = values[0];
																place.Text = values[1];
																startYear.SelectedItem = values[2];
																endYear.SelectedItem = values[3];

																Text = "Edytuj";
												}
												else
												{
																Text = "Dodaj";
												}

												CancelButton = cancel;
								}

								private void fillYears()
								{
												List<int> l1 = Enumerable.Range(1900, 2016 - 1900).ToList();
												List<string> l2 = l1.ConvertAll<string>(x => x.ToString());
												List<string> l3 = l1.ConvertAll<string>(x => x.ToString());
												startYear.DataSource = l2;
												endYear.DataSource = l3;
								}

								private void save_Click(object sender, EventArgs e)
								{
												Values[0] = position.Text;
												Values[1] = place.Text;
												Values[2] = startYear.Text;
												Values[3] = endYear.Text;

												this.DialogResult = DialogResult.OK;
												this.Close();
								}
				}
}
