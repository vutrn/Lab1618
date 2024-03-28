namespace Lab4
{
  partial class Form1
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
	  SuspendLayout();
	  // 
	  // tb_username
	  // 
	  tb_username.Location = new Point(94, 69);
	  tb_username.Name = "tb_username";
	  tb_username.Size = new Size(100, 23);
	  tb_username.TabIndex = 0;
	  tb_username.TextChanged += textBox1_TextChanged;
	  // 
	  // tb_password
	  // 
	  tb_password.Location = new Point(94, 114);
	  tb_password.Name = "tb_password";
	  tb_password.Size = new Size(100, 23);
	  tb_password.TabIndex = 1;
	  // 
	  // btn_login
	  // 
	  btn_login.Location = new Point(104, 180);
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
	  lb_banner.Location = new Point(80, 27);
	  lb_banner.Name = "lb_banner";
	  lb_banner.Size = new Size(57, 15);
	  lb_banner.TabIndex = 3;
	  lb_banner.Text = "Welcome";
	  lb_banner.Click += lb_banner_Click;
	  // 
	  // Form1
	  // 
	  AutoScaleDimensions = new SizeF(7F, 15F);
	  AutoScaleMode = AutoScaleMode.Font;
	  ClientSize = new Size(800, 450);
	  Controls.Add(lb_banner);
	  Controls.Add(btn_login);
	  Controls.Add(tb_password);
	  Controls.Add(tb_username);
	  Name = "Form1";
	  Text = "Form1";
	  Load += Form1_Load;
	  ResumeLayout(false);
	  PerformLayout();
	}

	#endregion

	private TextBox tb_username;
	private TextBox tb_password;
	private Button btn_login;
	private Label lb_banner;
  }
}
