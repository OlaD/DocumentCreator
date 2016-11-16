namespace DC
{
				partial class ExJobWindow
				{
								/// <summary>
								/// Required designer variable.
								/// </summary>
								private System.ComponentModel.IContainer components = null;

								/// <summary>
								/// Clean up any resources being used.
								/// </summary>
								/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
								protected override void Dispose(bool disposing)
								{
												if (disposing && (components != null))
												{
																components.Dispose();
												}
												base.Dispose(disposing);
								}

								#region Windows Form Designer generated code

								/// <summary>
								/// Required method for Designer support - do not modify
								/// the contents of this method with the code editor.
								/// </summary>
								private void InitializeComponent()
								{
												this.cancel = new System.Windows.Forms.Button();
												this.startYearLabel = new System.Windows.Forms.Label();
												this.nameLabel = new System.Windows.Forms.Label();
												this.positionLabel = new System.Windows.Forms.Label();
												this.startYear = new System.Windows.Forms.TextBox();
												this.save = new System.Windows.Forms.Button();
												this.endYearLabel = new System.Windows.Forms.Label();
												this.endYear = new System.Windows.Forms.TextBox();
												this.position = new System.Windows.Forms.TextBox();
												this.place = new System.Windows.Forms.TextBox();
												this.SuspendLayout();
												// 
												// cancel
												// 
												this.cancel.Location = new System.Drawing.Point(152, 127);
												this.cancel.Name = "cancel";
												this.cancel.Size = new System.Drawing.Size(100, 23);
												this.cancel.TabIndex = 6;
												this.cancel.Text = "Anuluj";
												this.cancel.UseVisualStyleBackColor = true;
												// 
												// startYearLabel
												// 
												this.startYearLabel.AutoSize = true;
												this.startYearLabel.Location = new System.Drawing.Point(15, 72);
												this.startYearLabel.Name = "startYearLabel";
												this.startYearLabel.Size = new System.Drawing.Size(90, 13);
												this.startYearLabel.TabIndex = 15;
												this.startYearLabel.Text = "Rok rozpoczęcia:";
												// 
												// nameLabel
												// 
												this.nameLabel.AutoSize = true;
												this.nameLabel.Location = new System.Drawing.Point(15, 45);
												this.nameLabel.Name = "nameLabel";
												this.nameLabel.Size = new System.Drawing.Size(46, 13);
												this.nameLabel.TabIndex = 14;
												this.nameLabel.Text = "Miejsce:";
												// 
												// positionLabel
												// 
												this.positionLabel.AutoSize = true;
												this.positionLabel.Location = new System.Drawing.Point(15, 18);
												this.positionLabel.Name = "positionLabel";
												this.positionLabel.Size = new System.Drawing.Size(65, 13);
												this.positionLabel.TabIndex = 13;
												this.positionLabel.Text = "Stanowisko:";
												// 
												// startYear
												// 
												this.startYear.Location = new System.Drawing.Point(111, 69);
												this.startYear.Name = "startYear";
												this.startYear.Size = new System.Drawing.Size(174, 20);
												this.startYear.TabIndex = 3;
												// 
												// save
												// 
												this.save.Location = new System.Drawing.Point(43, 127);
												this.save.Name = "save";
												this.save.Size = new System.Drawing.Size(100, 23);
												this.save.TabIndex = 5;
												this.save.Text = "Zapisz";
												this.save.UseVisualStyleBackColor = true;
												this.save.Click += new System.EventHandler(this.save_Click);
												// 
												// endYearLabel
												// 
												this.endYearLabel.AutoSize = true;
												this.endYearLabel.Location = new System.Drawing.Point(15, 98);
												this.endYearLabel.Name = "endYearLabel";
												this.endYearLabel.Size = new System.Drawing.Size(93, 13);
												this.endYearLabel.TabIndex = 19;
												this.endYearLabel.Text = "Rok zakończenia:";
												// 
												// endYear
												// 
												this.endYear.Location = new System.Drawing.Point(111, 95);
												this.endYear.Name = "endYear";
												this.endYear.Size = new System.Drawing.Size(174, 20);
												this.endYear.TabIndex = 4;
												// 
												// position
												// 
												this.position.Location = new System.Drawing.Point(111, 15);
												this.position.Name = "position";
												this.position.Size = new System.Drawing.Size(174, 20);
												this.position.TabIndex = 0;
												// 
												// place
												// 
												this.place.Location = new System.Drawing.Point(111, 42);
												this.place.Name = "place";
												this.place.Size = new System.Drawing.Size(174, 20);
												this.place.TabIndex = 1;
												// 
												// ExJobWindow
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(297, 162);
												this.Controls.Add(this.place);
												this.Controls.Add(this.position);
												this.Controls.Add(this.endYearLabel);
												this.Controls.Add(this.endYear);
												this.Controls.Add(this.cancel);
												this.Controls.Add(this.startYearLabel);
												this.Controls.Add(this.nameLabel);
												this.Controls.Add(this.positionLabel);
												this.Controls.Add(this.startYear);
												this.Controls.Add(this.save);
												this.Name = "ExJobWindow";
												this.Text = "exJobWindow";
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.Button cancel;
								private System.Windows.Forms.Label startYearLabel;
								private System.Windows.Forms.Label nameLabel;
								private System.Windows.Forms.Label positionLabel;
								private System.Windows.Forms.TextBox startYear;
								private System.Windows.Forms.Button save;
								private System.Windows.Forms.Label endYearLabel;
								private System.Windows.Forms.TextBox endYear;
								private System.Windows.Forms.TextBox position;
								private System.Windows.Forms.TextBox place;
				}
}