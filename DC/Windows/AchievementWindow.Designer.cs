namespace DC
{
				partial class AchievementWindow
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
												this.save = new System.Windows.Forms.Button();
												this.achievement = new System.Windows.Forms.TextBox();
												this.achievementLabel = new System.Windows.Forms.Label();
												this.SuspendLayout();
												// 
												// cancel
												// 
												this.cancel.Location = new System.Drawing.Point(121, 110);
												this.cancel.Name = "cancel";
												this.cancel.Size = new System.Drawing.Size(100, 23);
												this.cancel.TabIndex = 2;
												this.cancel.Text = "Anuluj";
												this.cancel.UseVisualStyleBackColor = true;
												// 
												// save
												// 
												this.save.Location = new System.Drawing.Point(12, 110);
												this.save.Name = "save";
												this.save.Size = new System.Drawing.Size(100, 23);
												this.save.TabIndex = 1;
												this.save.Text = "Zapisz";
												this.save.UseVisualStyleBackColor = true;
												this.save.Click += new System.EventHandler(this.save_Click);
												// 
												// achievement
												// 
												this.achievement.Location = new System.Drawing.Point(12, 32);
												this.achievement.Multiline = true;
												this.achievement.Name = "achievement";
												this.achievement.Size = new System.Drawing.Size(209, 69);
												this.achievement.TabIndex = 0;
												// 
												// achievementLabel
												// 
												this.achievementLabel.AutoSize = true;
												this.achievementLabel.Location = new System.Drawing.Point(12, 13);
												this.achievementLabel.Name = "achievementLabel";
												this.achievementLabel.Size = new System.Drawing.Size(65, 13);
												this.achievementLabel.TabIndex = 13;
												this.achievementLabel.Text = "Osiągnięcie:";
												// 
												// AchievementWindow
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(233, 142);
												this.Controls.Add(this.achievementLabel);
												this.Controls.Add(this.achievement);
												this.Controls.Add(this.cancel);
												this.Controls.Add(this.save);
												this.Name = "AchievementWindow";
												this.Text = "achievementWindow";
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.Button cancel;
								private System.Windows.Forms.Button save;
								private System.Windows.Forms.TextBox achievement;
								private System.Windows.Forms.Label achievementLabel;
				}
}