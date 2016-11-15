﻿using System;
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
				public partial class TitleWindow : Form
				{
								public string[] Values { get; set; }

								public enum Operation
								{
												Add,
												Edit
								}

								public TitleWindow(Operation operation, string[] values = null)
								{
												InitializeComponent();

												Values = new string[3];

												if(operation == Operation.Edit)
												{
																title.SelectedItem = values[0];//title.Items.IndexOf(values[0]);
																name.SelectedItem = values[1];
																year.Text = values[2];

																Text = "Edytuj";
												}
												else
												{
																Text = "Dodaj";
												}

												CancelButton = cancel;
								}

								private void title_SelectedIndexChanged(object sender, EventArgs e)
								{
												name.Items.Clear();
												switch(title.SelectedIndex)
												{
																case 0:
																				name.Items.Add("mgr");
																				name.Items.Add("mgr inz.");
																				break;
																case 1:
																				name.Items.Add("dr");
																				name.Items.Add("dr hab.");
																				break;
																case 2:
																				name.Items.Add("prof.");
																				break;
												}
												name.SelectedIndex = 0;
								}

								private void save_Click(object sender, EventArgs e)
								{
												Values[0] = title.SelectedItem.ToString();
												Values[1] = name.SelectedItem.ToString();
												Values[2] = year.Text;

												this.DialogResult = DialogResult.OK;
												this.Close();
								}
				}
}
