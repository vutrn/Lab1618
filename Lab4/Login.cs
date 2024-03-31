namespace Lab4
{
  public partial class Login : Form
  {
	public Login()
	{
	  InitializeComponent();
	}

	private void btn_login_Click(object sender, EventArgs e)
	{
	  if (tb_username.Text == "admin" && tb_password.Text == "123")
	  {
		MessageBox.Show("Login manager");
		Admin admin = new Admin();
		admin.Show();
	  }
	  else if (tb_password.Text == "Student" && tb_password.Text == "student")
	  {
		MessageBox.Show("Student");
		Student std = new Student();
		std.Show();
	  }
	  else
	  {
		MessageBox.Show("Invalid");
	  }
	}

	private void btn_register_Click(object sender, EventArgs e)
	{

	}

  }
}
