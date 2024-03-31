using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	public partial class Admin : Form
	{
		DataTable table = new DataTable("table");
		public Admin()
		{
			InitializeComponent();
			table.Columns.Add("Student ID", Type.GetType("System.String"));
			table.Columns.Add("Student Name", Type.GetType("System.String"));
			table.Columns.Add("Student Email", Type.GetType("System.String"));
			table.Columns.Add("Borrowed Books", Type.GetType("System.String"));
			dataGridView1.DataSource = table;
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			string id = tb_student_id.Text;
			string name = tb_student_name.Text;
			string email = tb_student_email.Text;
			string book = tb_book.Text;
			table.Rows.Add(id, name, email, book);

		}

		private void btn_remove_Click(object sender, EventArgs e)
		{
			var index = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.Rows.RemoveAt(index);
		}

	}
}
