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
				public partial class AchievementWindow : Form
				{
								public string Value { get; set; }

								public enum Operation
								{
												Add,
												Edit
								}

								public AchievementWindow(Operation operation, string value = null)
								{
												InitializeComponent();

												if (operation == Operation.Edit)
												{
																achievement.Text = value;

																Text = "Edytuj";
												}
												else
												{
																Text = "Dodaj";
												}

												CancelButton = cancel;
								}

								private void save_Click(object sender, EventArgs e)
								{
												Value = achievement.Text;

												this.DialogResult = DialogResult.OK;
												this.Close();
								}
				}
}
