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
  public partial class Student : Form
  {
	public Student()
	{
	  InitializeComponent();
	}








	private void Student_FormClosed(object sender, FormClosedEventArgs e)
	{
	  Login login = new Login();
	  login.Show();
	}

	private void adminBindingSource_CurrentChanged(object sender, EventArgs e)
	{

	}
  }
}
