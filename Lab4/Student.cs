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
	public partial class Student : Form
	{
		DataTable table = new DataTable("table");
		public Student()
		{
			InitializeComponent();
			table.Columns.Add("Book ID", Type.GetType("System.String"));
			table.Columns.Add("Book Name", Type.GetType("System.String"));
			table.Columns.Add("Publish Year", Type.GetType("System.String"));
			table.Columns.Add("Borrow Date", Type.GetType("System.String"));
			table.Columns.Add("Due Date", Type.GetType("System.String"));
			dataGridView1.DataSource = table;
		}

		private void Student_Load(object sender, EventArgs e)
		{

		}
	}
}
