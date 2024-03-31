using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
  public partial class Admin : Form
  {
	public Admin()
	{
	  InitializeComponent();
	}
	SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0T3CC97;Initial Catalog=1618LibraryManager;Integrated Security=True;Trust Server Certificate=True");

	private void Admin_Load(object sender, EventArgs e)
	{
	  if (conn.State == ConnectionState.Closed)
	  {
		conn.Open();
		MessageBox.Show(conn.ConnectionString);
	  }
	}

	private void lb_genre_name_Paint(object sender, PaintEventArgs e)
	{

	}
  }
}
