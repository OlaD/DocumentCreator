using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DC
{
				public class ListBoxTable
				{
								ListBox table;

								public int Count
								{
												get { return table.Items.Count; }
								}
								public int SelectedIndex
								{
												get { return table.SelectedIndex; }
								}

								public ListBoxTable(ListBox table)
								{
												this.table = table;
								}

								public void Add(string row)
								{
												table.Items.Add(row);
								}

								public void RemoveSelected()
								{
												Remove(SelectedIndex);
								}

								public void Remove(int index)
								{
												if(index != -1)
																table.Items.RemoveAt(index);
								}

								public void Clear()
								{
												table.Items.Clear();
								}

								public string GetSelectedRow()
								{
												string row = GetRow(SelectedIndex);
												return row;
								}

								public string GetRow(int index)
								{
												string row = (string)table.Items[index];
												return row;
								}

								public List<string> GetAllRows()
								{
												List<string> rows = new List<string>();
												for (int i = 0; i < table.Items.Count; i++)
												{
																string row = GetRow(i);
																rows.Add(row);
												}
												return rows;
								}

								public void EditSelectedRow(string row)
								{
												table.Items[SelectedIndex] = row;
								}
				}
}
