using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace DC
{
				public class ListViewTable
				{
								ListView table;
								public int Count
								{
												get { return table.Items.Count; }
								}
								public int SelectedIndex
								{
												get 
												{ 
																if (table.SelectedIndices.Count == 0)
																{
																				return -1;
																}
																else
																{
																				return table.SelectedIndices[0];
																}
												}
								}

								public ListViewTable(ListView table)
								{
												this.table = table;
								}

								public void Add(string[] row)
								{
												ListViewItem item = new ListViewItem(row);
												table.Items.Add(item);
								}

								public void RemoveSelected()
								{
												Remove(SelectedIndex);
								}

								public void Remove(int index)
								{
												table.Items.RemoveAt(index);
								}

								public void Clear()
								{
												table.Items.Clear();
								}

								public string[] GetSelectedRow()
								{
												string[] row = GetRow(SelectedIndex);
												return row;
								}

								public string[] GetRow(int index)
								{
												ListViewItem item = table.Items[index];
												int count = item.SubItems.Count;
												string[] row = new string[count];
												for (int i = 0; i < count; i++)
												{
																row[i] = item.SubItems[i].Text;
												}
												return row;
								}

								public List<string[]> GetAllRows()
								{
												List<string[]> rows = new List<string[]>();
												for(int i = 0; i < table.Items.Count; i++)
												{
																string[] row = GetRow(i);
																rows.Add(row);
												}
												return rows;
								}

								public void EditSelectedRow(string[] row)
								{
												ListViewItem item = table.SelectedItems[0];
												int count = item.SubItems.Count;
												for (int i = 0; i < count; i++)
												{
																item.SubItems[i].Text = row[i];
												}
								}
				}
}
