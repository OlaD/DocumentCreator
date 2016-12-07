using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace DC
{
				public partial class MainWindow : Form
				{
								public DateTime Date
								{
												get { return date.Value; }
												set { date.Value = value; }
								}
								public string OrganizationalUnit
								{
												get { return organizationalUnit.Text; }
												set { organizationalUnit.Text = value; }
								}
								public string CandidatName
								{
												get { return name.Text; }
												set { name.Text = value; }
								}
								public string CandidatSurname
								{
												get { return surname.Text; }
												set { surname.Text = value; }
								}
								public string PostCode
								{
												get { return postCode.Text; }
												set { postCode.Text = value; }
								}
								public string City
								{
												get { return city.Text; }
												set { city.Text = value; }
								}
								public string Street
								{
												get { return street.Text; }
												set { street.Text = value; }
								}
								public string HouseNumber
								{
												get { return houseNumber.Text; }
												set { houseNumber.Text = value;
												}
								}
								public string FlatNumber
								{
												get { return flatNumber.Text; }
												set { flatNumber.Text = value; }
								}
								public string AcademyName
								{
												get { return academyName.Text; }
												set { academyName.Text = value; }
								}
								public string FacultyName
								{
												get { return facultyName.Text; }
												set { facultyName.Text = value; }
								}
								public ListViewTable Titles { get; }
								public ListViewTable ExJobs { get; }
								public ListBoxTable Achievements { get; }
								public string Position
								{
												get { return position.Text; }
												set { position.Text = value; }
								}
								public DateTime StartDate
								{
												get { return startDate.Value; }
												set { startDate.Value = value; }
								}
								public bool IsDefiniteWorkTime
								{
												get 
												{
																if (forPeriod.SelectedIndex == 0)
																{
																				return true;
																}
																else
																{
																				return false;
																}
												}
												set
												{
																if (value == true)
																{
																				forPeriod.SelectedIndex = 0;
																}
																else
																{
																				forPeriod.SelectedIndex = 1;
																}
												}
								}
								public bool IsFullWorkTime
								{
												get { return fullWorkingTimeCheckBox.Checked; }
												set { fullWorkingTimeCheckBox.Checked = value; }
								}
								public DateTime EndDate
								{
												get { return endDate.Value; }
												set { endDate.Value = value; }
								}
								public string WorkTime
								{
												get { return workingTime.Text; }
												set { workingTime.Text = value; }
								}
								public bool IsContract
								{
												get { return contractRadioButton.Checked; }
												set 
												{
																if (value == true)
																{
																				contractRadioButton.Checked = true;
																}
																else
																{
																				nominationRadioButton.Checked = true;
																}
												}
								}
								public SaveFileDialog SaveFileDialog 
								{
												get { return saveFileDialog; }
								}

								private Presenter presenter;

								public MainWindow()
								{
												InitializeComponent();

												presenter = new Presenter(this);

												IsDefiniteWorkTime = true;
												IsFullWorkTime = true;
												IsContract = true;

												Titles = new ListViewTable(titlesTable);
												ExJobs = new ListViewTable(exJobsTable);
												Achievements = new ListBoxTable(achievementsList);
								}

								private void loadXml_Click(object sender, EventArgs e)
								{
								if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
								{
												presenter.LoadDataToFields(openFileDialog.FileName);
								}
								}

								private void titlesTable_SelectedIndexChanged(object sender, EventArgs e)
								{
												if (Titles.SelectedIndex != -1)
												{
																editTitle.Enabled = true;
																removeTitle.Enabled = true;
												}
												else 
												{
																editTitle.Enabled = false;
																removeTitle.Enabled = false;
												}
								}

								private void achievementsList_SelectedIndexChanged(object sender, EventArgs e)
								{
												if (Achievements.SelectedIndex != -1)
												{
																editAchievement.Enabled = true;
																removeAchievement.Enabled = true;
												}
												else
												{
																editAchievement.Enabled = false;
																removeAchievement.Enabled = false;
												}
								}

								private void exJobsTable_SelectedIndexChanged(object sender, EventArgs e)
								{
												if (ExJobs.SelectedIndex != -1)
												{
																editExJob.Enabled = true;
																removeExJob.Enabled = true;
												}
												else
												{
																editExJob.Enabled = false;
																removeExJob.Enabled = false;
												}
								}

								private void addTitle_Click(object sender, EventArgs e)
								{
												using (TitleWindow window = new TitleWindow(TitleWindow.Operation.Add))
												{
																var result = window.ShowDialog();
																if(result == DialogResult.OK)
																{
																				string[] row = window.Values;
																				Titles.Add(row);
																}
												}
								}

								private void editTitle_Click(object sender, EventArgs e)
								{
												using (TitleWindow window = new TitleWindow(TitleWindow.Operation.Edit, Titles.GetSelectedRow()))
												{
																var result = window.ShowDialog();
																if (result == DialogResult.OK)
																{
																				string[] editedValues = window.Values;
																				Titles.EditSelectedRow(editedValues);
																}
												}
								}

								private void removeTitle_Click(object sender, EventArgs e)
								{
												Titles.RemoveSelected();
								}

								private void exJobAdd_Click(object sender, EventArgs e)
								{
												using (ExJobWindow window = new ExJobWindow(ExJobWindow.Operation.Add))
												{
																var result = window.ShowDialog();
																if (result == DialogResult.OK)
																{
																				string[] row = window.Values;
																				ExJobs.Add(row);
																}
												}
								}

								private void exJobEdit_Click(object sender, EventArgs e)
								{
												using (ExJobWindow window = new ExJobWindow(ExJobWindow.Operation.Edit, ExJobs.GetSelectedRow()))
												{
																var result = window.ShowDialog();
																if (result == DialogResult.OK)
																{
																				string[] editedValues = window.Values;
																				ExJobs.EditSelectedRow(editedValues);
																}
												}
								}

								private void exJobRemove_Click(object sender, EventArgs e)
								{
												ExJobs.RemoveSelected();
								}

								private void addAchievement_Click(object sender, EventArgs e)
								{
												using (AchievementWindow window = new AchievementWindow(AchievementWindow.Operation.Add))
												{
																var result = window.ShowDialog();
																if (result == DialogResult.OK)
																{
																				string row = window.Value;
																				Achievements.Add(row);
																}
												}
								}

								private void editAchievement_Click(object sender, EventArgs e)
								{
												using (AchievementWindow window = new AchievementWindow(AchievementWindow.Operation.Edit, Achievements.GetSelectedRow()))
												{
																var result = window.ShowDialog();
																if (result == DialogResult.OK)
																{
																				string row = window.Value;
																				Achievements.EditSelectedRow(row);
																}
												}
								}

								private void removeAchievement_Click(object sender, EventArgs e)
								{
												Achievements.RemoveSelected();
								}

								private void forPeriod_SelectedIndexChanged(object sender, EventArgs e)
								{
												if (forPeriod.SelectedIndex == 0)    // czas zatrudnienia == określony
												{
																endDate.Visible = true;
																endDateLabel.Visible = true;
												}
												else
												{
																endDate.Visible = false;
																endDateLabel.Visible = false;
												}
								}

								private void fullWorkingTimeCheckBox_CheckedChanged(object sender, EventArgs e)
								{
												if (fullWorkingTimeCheckBox.Checked)
												{
																workingTime.Enabled = false;
																workingTime.Text = "pełny";
																workingTimeLabel.Enabled = false;
																workingTimeLabel.Text = "etat";
												}
												else
												{
																workingTime.Enabled = true;
																workingTime.Text = "";
																workingTimeLabel.Enabled = true;
																workingTimeLabel.Text = "etatu";
												}
								}

								private void validateAndSave_Click(object sender, EventArgs e)
								{
												presenter.ValidateAndSaveDocument();
								}

								private void postCode_Leave(object sender, EventArgs e)
								{
												string message = presenter.ValidateField(Fields.Field.postCode);
												if (message != "")
												{
																ToolTip error = new ToolTip();
																error.SetToolTip(postCode, message);
																postCode.ForeColor = System.Drawing.Color.Red;
												}
												else
												{
																string city = presenter.GetCity();
																if (city == "")
																{
																				ToolTip error = new ToolTip();
																				error.SetToolTip(postCode, "Nie znaleziono miejscowości o podanym kodzie pocztowym.");
																				postCode.ForeColor = System.Drawing.Color.Red;
																}
																else
																{
																				postCode.ForeColor = System.Drawing.Color.Black;
																				City = city;
																}
												}
								}

								private void generatePDF_Click(object sender, EventArgs e)
								{
												presenter.GeneratePDF();
								}

								private void name_Leave(object sender, EventArgs e)
								{
												string message = presenter.ValidateField(Fields.Field.name);
												if(message != "")
												{
																ToolTip error = new ToolTip();
																error.SetToolTip(name, message);
																name.ForeColor = System.Drawing.Color.Red;
												}
												else
												{
																name.ForeColor = System.Drawing.Color.Black;
												}
								}

								private void surname_Leave(object sender, EventArgs e)
								{
												string message = presenter.ValidateField(Fields.Field.surname);
												if (message != "")
												{
																ToolTip error = new ToolTip();
																error.SetToolTip(surname, message);
																surname.ForeColor = System.Drawing.Color.Red;
												}
												else
												{
																surname.ForeColor = System.Drawing.Color.Black;
												}
												
								}

								private void city_Leave(object sender, EventArgs e)
								{
												string message = presenter.ValidateField(Fields.Field.city);
												if (message != "")
												{
																ToolTip error = new ToolTip();
																error.SetToolTip(city, message);
																city.ForeColor = System.Drawing.Color.Red;
												}
												else
												{
																city.ForeColor = System.Drawing.Color.Black;
												}
								}

								private void workingTime_Leave(object sender, EventArgs e)
								{
												string message = presenter.ValidateField(Fields.Field.workTime);
												if (message != "")
												{
																ToolTip error = new ToolTip();
																error.SetToolTip(workingTime, message);
																workingTime.ForeColor = System.Drawing.Color.Red;
												}
												else
												{
																workingTime.ForeColor = System.Drawing.Color.Black;
												}
								}

								private void button1_Click(object sender, EventArgs e)
								{
												string message = presenter.ValidateField(Fields.Field.titles);
												if (message != "")
												{
																ToolTip error = new ToolTip();
																error.SetToolTip(button1, message);
																button1.ForeColor = System.Drawing.Color.Red;
												}
												else
												{
																button1.ForeColor = System.Drawing.Color.Black;
												}
								}

								private void clear_Click(object sender, EventArgs e)
								{
												presenter.CleanWindow();
								}
				}
}
