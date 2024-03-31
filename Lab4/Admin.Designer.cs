namespace Lab4
{
  partial class Admin
  {
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
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
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
	  btn_add = new Button();
	  dataGridView1 = new DataGridView();
	  tb_student_id = new TextBox();
	  tb_student_name = new TextBox();
	  tb_student_email = new TextBox();
	  label1 = new Label();
	  tb_book = new TextBox();
	  label2 = new Label();
	  label3 = new Label();
	  label4 = new Label();
	  btn_remove = new Button();
	  btn_save = new Button();
	  tabControl1 = new TabControl();
	  tabPage1 = new TabPage();
	  tabPage2 = new TabPage();
	  ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
	  tabControl1.SuspendLayout();
	  tabPage1.SuspendLayout();
	  SuspendLayout();
	  // 
	  // btn_add
	  // 
	  btn_add.Location = new Point(13, 193);
	  btn_add.Name = "btn_add";
	  btn_add.Size = new Size(75, 23);
	  btn_add.TabIndex = 0;
	  btn_add.Text = "Add book";
	  btn_add.UseVisualStyleBackColor = true;
	  btn_add.Click += btn_add_Click;
	  // 
	  // dataGridView1
	  // 
	  dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
	  dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
	  dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  dataGridView1.Location = new Point(278, 6);
	  dataGridView1.Name = "dataGridView1";
	  dataGridView1.Size = new Size(496, 277);
	  dataGridView1.TabIndex = 2;
	  // 
	  // tb_student_id
	  // 
	  tb_student_id.Location = new Point(132, 5);
	  tb_student_id.Name = "tb_student_id";
	  tb_student_id.Size = new Size(100, 23);
	  tb_student_id.TabIndex = 3;
	  // 
	  // tb_student_name
	  // 
	  tb_student_name.Location = new Point(132, 43);
	  tb_student_name.Name = "tb_student_name";
	  tb_student_name.Size = new Size(100, 23);
	  tb_student_name.TabIndex = 4;
	  // 
	  // tb_student_email
	  // 
	  tb_student_email.Location = new Point(132, 78);
	  tb_student_email.Name = "tb_student_email";
	  tb_student_email.Size = new Size(100, 23);
	  tb_student_email.TabIndex = 5;
	  // 
	  // label1
	  // 
	  label1.AutoSize = true;
	  label1.Location = new Point(46, 16);
	  label1.Name = "label1";
	  label1.Size = new Size(62, 15);
	  label1.TabIndex = 6;
	  label1.Text = "Student ID";
	  // 
	  // tb_book
	  // 
	  tb_book.Location = new Point(132, 107);
	  tb_book.Name = "tb_book";
	  tb_book.Size = new Size(100, 23);
	  tb_book.TabIndex = 7;
	  // 
	  // label2
	  // 
	  label2.AutoSize = true;
	  label2.Location = new Point(46, 49);
	  label2.Name = "label2";
	  label2.Size = new Size(83, 15);
	  label2.TabIndex = 8;
	  label2.Text = "Student Name";
	  // 
	  // label3
	  // 
	  label3.AutoSize = true;
	  label3.Location = new Point(55, 81);
	  label3.Name = "label3";
	  label3.Size = new Size(36, 15);
	  label3.TabIndex = 9;
	  label3.Text = "Email";
	  // 
	  // label4
	  // 
	  label4.AutoSize = true;
	  label4.Location = new Point(55, 113);
	  label4.Name = "label4";
	  label4.Size = new Size(39, 15);
	  label4.TabIndex = 10;
	  label4.Text = "Books";
	  // 
	  // btn_remove
	  // 
	  btn_remove.Location = new Point(92, 193);
	  btn_remove.Name = "btn_remove";
	  btn_remove.Size = new Size(75, 23);
	  btn_remove.TabIndex = 11;
	  btn_remove.Text = "Remove";
	  btn_remove.UseVisualStyleBackColor = true;
	  btn_remove.Click += btn_remove_Click;
	  // 
	  // btn_save
	  // 
	  btn_save.Location = new Point(173, 193);
	  btn_save.Name = "btn_save";
	  btn_save.Size = new Size(75, 23);
	  btn_save.TabIndex = 12;
	  btn_save.Text = "Save";
	  btn_save.UseVisualStyleBackColor = true;
	  // 
	  // tabControl1
	  // 
	  tabControl1.Controls.Add(tabPage1);
	  tabControl1.Controls.Add(tabPage2);
	  tabControl1.Dock = DockStyle.Fill;
	  tabControl1.Location = new Point(0, 0);
	  tabControl1.Margin = new Padding(0);
	  tabControl1.Name = "tabControl1";
	  tabControl1.SelectedIndex = 0;
	  tabControl1.Size = new Size(800, 374);
	  tabControl1.TabIndex = 13;
	  // 
	  // tabPage1
	  // 
	  tabPage1.Controls.Add(tb_student_id);
	  tabPage1.Controls.Add(btn_add);
	  tabPage1.Controls.Add(btn_remove);
	  tabPage1.Controls.Add(btn_save);
	  tabPage1.Controls.Add(label1);
	  tabPage1.Controls.Add(dataGridView1);
	  tabPage1.Controls.Add(label4);
	  tabPage1.Controls.Add(tb_student_name);
	  tabPage1.Controls.Add(tb_book);
	  tabPage1.Controls.Add(label3);
	  tabPage1.Controls.Add(tb_student_email);
	  tabPage1.Controls.Add(label2);
	  tabPage1.Location = new Point(4, 24);
	  tabPage1.Name = "tabPage1";
	  tabPage1.Padding = new Padding(3);
	  tabPage1.Size = new Size(792, 346);
	  tabPage1.TabIndex = 0;
	  tabPage1.Text = "tabPage1";
	  // 
	  // tabPage2
	  // 
	  tabPage2.Location = new Point(4, 24);
	  tabPage2.Name = "tabPage2";
	  tabPage2.Padding = new Padding(3);
	  tabPage2.Size = new Size(768, 322);
	  tabPage2.TabIndex = 1;
	  tabPage2.Text = "tabPage2";
	  tabPage2.UseVisualStyleBackColor = true;
	  // 
	  // Admin
	  // 
	  AutoScaleDimensions = new SizeF(7F, 15F);
	  AutoScaleMode = AutoScaleMode.Font;
	  ClientSize = new Size(800, 374);
	  Controls.Add(tabControl1);
	  Name = "Admin";
	  Text = "Admin";
	  ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
	  tabControl1.ResumeLayout(false);
	  tabPage1.ResumeLayout(false);
	  tabPage1.PerformLayout();
	  ResumeLayout(false);
	}

	#endregion

	private Button btn_add;
	private DataGridView dataGridView1;
	private TextBox tb_student_id;
	private TextBox tb_student_name;
	private TextBox tb_student_email;
	private Label label1;
	private TextBox tb_book;
	private Label label2;
	private Label label3;
	private Label label4;
	private Button btn_remove;
	private Button btn_save;
	private TabControl tabControl1;
	private TabPage tabPage1;
	private TabPage tabPage2;
  }
}