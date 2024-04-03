namespace LibraryManager
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
	  label1 = new Label();
	  btn_admin_page = new Button();
	  label2 = new Label();
	  btn_student_page = new Button();
	  SuspendLayout();
	  // 
	  // label1
	  // 
	  label1.AutoSize = true;
	  label1.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
	  label1.Location = new Point(166, 25);
	  label1.Name = "label1";
	  label1.Size = new Size(67, 23);
	  label1.TabIndex = 0;
	  label1.Text = "Admin";
	  // 
	  // btn_admin_page
	  // 
	  btn_admin_page.Location = new Point(142, 51);
	  btn_admin_page.Name = "btn_admin_page";
	  btn_admin_page.Size = new Size(114, 23);
	  btn_admin_page.TabIndex = 1;
	  btn_admin_page.Text = "Go to Admin page";
	  btn_admin_page.UseVisualStyleBackColor = true;
	  btn_admin_page.Click += btn_admin_page_Click;
	  // 
	  // label2
	  // 
	  label2.AutoSize = true;
	  label2.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
	  label2.Location = new Point(166, 165);
	  label2.Name = "label2";
	  label2.Size = new Size(77, 23);
	  label2.TabIndex = 2;
	  label2.Text = "Student";
	  // 
	  // btn_student_page
	  // 
	  btn_student_page.Location = new Point(142, 191);
	  btn_student_page.Name = "btn_student_page";
	  btn_student_page.Size = new Size(121, 23);
	  btn_student_page.TabIndex = 3;
	  btn_student_page.Text = "Go to Student Page";
	  btn_student_page.UseVisualStyleBackColor = true;
	  btn_student_page.Click += btn_student_page_Click;
	  // 
	  // Login
	  // 
	  AutoScaleDimensions = new SizeF(7F, 15F);
	  AutoScaleMode = AutoScaleMode.Font;
	  ClientSize = new Size(407, 269);
	  Controls.Add(btn_student_page);
	  Controls.Add(label2);
	  Controls.Add(btn_admin_page);
	  Controls.Add(label1);
	  Name = "Login";
	  StartPosition = FormStartPosition.CenterScreen;
	  Text = "Login";
	  ResumeLayout(false);
	  PerformLayout();
	}

	#endregion

	private Label label1;
	private Button btn_admin_page;
	private Label label2;
	private Button btn_student_page;
  }
}
