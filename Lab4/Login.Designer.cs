namespace Lab4
{
  partial class Login
  {
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
	  tb_username = new TextBox();
	  tb_password = new TextBox();
	  btn_login = new Button();
	  lb_banner = new Label();
	  btn_register = new Button();
	  SuspendLayout();
	  // 
	  // tb_username
	  // 
	  tb_username.Location = new Point(124, 68);
	  tb_username.Name = "tb_username";
	  tb_username.Size = new Size(100, 23);
	  tb_username.TabIndex = 0;
	  // 
	  // tb_password
	  // 
	  tb_password.Location = new Point(124, 111);
	  tb_password.Name = "tb_password";
	  tb_password.Size = new Size(100, 23);
	  tb_password.TabIndex = 1;
	  // 
	  // btn_login
	  // 
	  btn_login.Location = new Point(80, 164);
	  btn_login.Name = "btn_login";
	  btn_login.Size = new Size(75, 23);
	  btn_login.TabIndex = 2;
	  btn_login.Text = "Login";
	  btn_login.UseVisualStyleBackColor = true;
	  btn_login.Click += btn_login_Click;
	  // 
	  // lb_banner
	  // 
	  lb_banner.AutoSize = true;
	  lb_banner.Location = new Point(144, 20);
	  lb_banner.Name = "lb_banner";
	  lb_banner.Size = new Size(57, 15);
	  lb_banner.TabIndex = 3;
	  lb_banner.Text = "Welcome";
	  // 
	  // btn_register
	  // 
	  btn_register.Location = new Point(186, 164);
	  btn_register.Name = "btn_register";
	  btn_register.Size = new Size(75, 23);
	  btn_register.TabIndex = 4;
	  btn_register.Text = "Register";
	  btn_register.UseVisualStyleBackColor = true;
	  btn_register.Click += btn_register_Click;
	  // 
	  // Login
	  // 
	  AutoScaleDimensions = new SizeF(7F, 15F);
	  AutoScaleMode = AutoScaleMode.Font;
	  ClientSize = new Size(351, 254);
	  Controls.Add(btn_register);
	  Controls.Add(lb_banner);
	  Controls.Add(btn_login);
	  Controls.Add(tb_password);
	  Controls.Add(tb_username);
	  Name = "Login";
	  StartPosition = FormStartPosition.CenterScreen;
	  Text = "Login";
	  ResumeLayout(false);
	  PerformLayout();
	}

	#endregion

	private TextBox tb_username;
	private TextBox tb_password;
	private Button btn_login;
	private Label lb_banner;
	private Button btn_register;
  }
}
