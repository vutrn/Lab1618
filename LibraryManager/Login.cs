using Microsoft.Data.SqlClient;

namespace LibraryManager
{
  public partial class Login : Form
  {
	public Login()
	{
	  InitializeComponent();
	}

	private void btn_admin_page_Click(object sender, EventArgs e)
	{
	  this.Hide();

	  Admin admin = new Admin();
	  admin.Show();

	  this.Hide();

	}

	private void btn_student_page_Click(object sender, EventArgs e)
	{
	  this.Hide();

	  Student std = new Student();
	  std.Show();

	  this.Hide();

	}

	private void Login_FormClosing(object sender, FormClosingEventArgs e)
	{
	  Application.Exit();
	}
  }
}
