using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace DC
{
				public class ListViewTable
				{
								ListView table;

								public ListViewTable(ListView table)
								{
												this.table = table;
								}

								public void Add(string[] row)
								{
												ListViewItem item = new ListViewItem(row);
												item.Name = (table.Items.Count + 1).ToString();
												table.Items.Add(item);
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
												int index = table.SelectedItems[0].Index;
												string[] row = GetRow(index);
												return row;
								}

								public string[] GetRow(int index)
								{
												ListViewItem item = table.Items[index];
												int count = item.SubItems.Count;
												string[] row = new string[count];
												for (int i = 0; i < count; i++)
												{
																row[i] = item.SubItems[i].ToString();
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
