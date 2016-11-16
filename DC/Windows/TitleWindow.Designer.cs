namespace DC
{
				partial class TitleWindow
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
												this.save = new System.Windows.Forms.Button();
												this.name = new System.Windows.Forms.ComboBox();
												this.titleLabel = new System.Windows.Forms.Label();
												this.nameLabel = new System.Windows.Forms.Label();
												this.yearLabel = new System.Windows.Forms.Label();
												this.title = new System.Windows.Forms.ComboBox();
												this.cancel = new System.Windows.Forms.Button();
												this.year = new System.Windows.Forms.TextBox();
												this.SuspendLayout();
												// 
												// save
												// 
												this.save.Location = new System.Drawing.Point(12, 106);
												this.save.Name = "save";
												this.save.Size = new System.Drawing.Size(100, 23);
												this.save.TabIndex = 3;
												this.save.Text = "Zapisz";
												this.save.UseVisualStyleBackColor = true;
												this.save.Click += new System.EventHandler(this.save_Click);
												// 
												// name
												// 
												this.name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
												this.name.FormattingEnabled = true;
												this.name.Location = new System.Drawing.Point(100, 43);
												this.name.Name = "name";
												this.name.Size = new System.Drawing.Size(121, 21);
												this.name.TabIndex = 1;
												// 
												// titleLabel
												// 
												this.titleLabel.AutoSize = true;
												this.titleLabel.Location = new System.Drawing.Point(15, 19);
												this.titleLabel.Name = "titleLabel";
												this.titleLabel.Size = new System.Drawing.Size(72, 13);
												this.titleLabel.TabIndex = 5;
												this.titleLabel.Text = "Stopień/tytuł:";
												// 
												// nameLabel
												// 
												this.nameLabel.AutoSize = true;
												this.nameLabel.Location = new System.Drawing.Point(15, 46);
												this.nameLabel.Name = "nameLabel";
												this.nameLabel.Size = new System.Drawing.Size(43, 13);
												this.nameLabel.TabIndex = 6;
												this.nameLabel.Text = "Nazwa:";
												// 
												// yearLabel
												// 
												this.yearLabel.AutoSize = true;
												this.yearLabel.Location = new System.Drawing.Point(15, 73);
												this.yearLabel.Name = "yearLabel";
												this.yearLabel.Size = new System.Drawing.Size(80, 13);
												this.yearLabel.TabIndex = 7;
												this.yearLabel.Text = "Rok uzyskania:";
												// 
												// title
												// 
												this.title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
												this.title.FormattingEnabled = true;
												this.title.Items.AddRange(new object[] {
            "tytuł zawodowy",
            "stopień naukowy",
            "tytuł naukowy"});
												this.title.Location = new System.Drawing.Point(100, 16);
												this.title.Name = "title";
												this.title.Size = new System.Drawing.Size(121, 21);
												this.title.TabIndex = 0;
												this.title.SelectedIndexChanged += new System.EventHandler(this.title_SelectedIndexChanged);
												// 
												// cancel
												// 
												this.cancel.Location = new System.Drawing.Point(121, 106);
												this.cancel.Name = "cancel";
												this.cancel.Size = new System.Drawing.Size(100, 23);
												this.cancel.TabIndex = 4;
												this.cancel.Text = "Anuluj";
												this.cancel.UseVisualStyleBackColor = true;
												// 
												// year
												// 
												this.year.Location = new System.Drawing.Point(100, 70);
												this.year.Name = "year";
												this.year.Size = new System.Drawing.Size(121, 20);
												this.year.TabIndex = 2;
												// 
												// TitleWindow
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(233, 142);
												this.Controls.Add(this.cancel);
												this.Controls.Add(this.title);
												this.Controls.Add(this.yearLabel);
												this.Controls.Add(this.nameLabel);
												this.Controls.Add(this.titleLabel);
												this.Controls.Add(this.name);
												this.Controls.Add(this.year);
												this.Controls.Add(this.save);
												this.Name = "TitleWindow";
												this.Text = "TitleWindow";
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.Button save;
								private System.Windows.Forms.ComboBox name;
								private System.Windows.Forms.Label titleLabel;
								private System.Windows.Forms.Label nameLabel;
								private System.Windows.Forms.Label yearLabel;
								private System.Windows.Forms.ComboBox title;
								private System.Windows.Forms.Button cancel;
								private System.Windows.Forms.TextBox year;
				}
}