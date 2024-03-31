namespace LibraryManager
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
	  tabControl1 = new TabControl();
	  tp_book = new TabPage();
	  panel1 = new Panel();
	  lb_book_list = new Label();
	  dgv_book_list = new DataGridView();
	  lb_genre_name = new Panel();
	  btn_create_book = new Button();
	  lb_genre = new Label();
	  lb_author_name = new Label();
	  lb_book_name = new Label();
	  tb_genre_name = new TextBox();
	  tb_author_name = new TextBox();
	  tb_book_name = new TextBox();
	  tp_student = new TabPage();
	  tabControl1.SuspendLayout();
	  tp_book.SuspendLayout();
	  panel1.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)dgv_book_list).BeginInit();
	  lb_genre_name.SuspendLayout();
	  SuspendLayout();
	  // 
	  // tabControl1
	  // 
	  tabControl1.Controls.Add(tp_book);
	  tabControl1.Controls.Add(tp_student);
	  tabControl1.Dock = DockStyle.Fill;
	  tabControl1.Location = new Point(0, 0);
	  tabControl1.Name = "tabControl1";
	  tabControl1.SelectedIndex = 0;
	  tabControl1.Size = new Size(800, 450);
	  tabControl1.TabIndex = 0;
	  // 
	  // tp_book
	  // 
	  tp_book.Controls.Add(panel1);
	  tp_book.Controls.Add(lb_genre_name);
	  tp_book.Location = new Point(4, 24);
	  tp_book.Name = "tp_book";
	  tp_book.Padding = new Padding(3);
	  tp_book.Size = new Size(792, 422);
	  tp_book.TabIndex = 0;
	  tp_book.Text = "Book Lists";
	  tp_book.UseVisualStyleBackColor = true;
	  // 
	  // panel1
	  // 
	  panel1.Controls.Add(lb_book_list);
	  panel1.Controls.Add(dgv_book_list);
	  panel1.Dock = DockStyle.Fill;
	  panel1.Location = new Point(3, 3);
	  panel1.Name = "panel1";
	  panel1.Size = new Size(486, 416);
	  panel1.TabIndex = 2;
	  // 
	  // lb_book_list
	  // 
	  lb_book_list.AutoSize = true;
	  lb_book_list.Font = new Font("Cambria", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
	  lb_book_list.Location = new Point(5, 0);
	  lb_book_list.Name = "lb_book_list";
	  lb_book_list.Size = new Size(122, 32);
	  lb_book_list.TabIndex = 7;
	  lb_book_list.Text = "Book List";
	  // 
	  // dgv_book_list
	  // 
	  dgv_book_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  dgv_book_list.Dock = DockStyle.Bottom;
	  dgv_book_list.Location = new Point(0, 35);
	  dgv_book_list.Name = "dgv_book_list";
	  dgv_book_list.Size = new Size(486, 381);
	  dgv_book_list.TabIndex = 2;
	  // 
	  // lb_genre_name
	  // 
	  lb_genre_name.Controls.Add(btn_create_book);
	  lb_genre_name.Controls.Add(lb_genre);
	  lb_genre_name.Controls.Add(lb_author_name);
	  lb_genre_name.Controls.Add(lb_book_name);
	  lb_genre_name.Controls.Add(tb_genre_name);
	  lb_genre_name.Controls.Add(tb_author_name);
	  lb_genre_name.Controls.Add(tb_book_name);
	  lb_genre_name.Dock = DockStyle.Right;
	  lb_genre_name.Location = new Point(489, 3);
	  lb_genre_name.Name = "lb_genre_name";
	  lb_genre_name.Size = new Size(300, 416);
	  lb_genre_name.TabIndex = 1;
	  lb_genre_name.Paint += lb_genre_name_Paint;
	  // 
	  // btn_create_book
	  // 
	  btn_create_book.Location = new Point(122, 219);
	  btn_create_book.Name = "btn_create_book";
	  btn_create_book.Size = new Size(75, 23);
	  btn_create_book.TabIndex = 6;
	  btn_create_book.Text = "Create";
	  btn_create_book.UseVisualStyleBackColor = true;
	  // 
	  // lb_genre
	  // 
	  lb_genre.AutoSize = true;
	  lb_genre.Location = new Point(19, 169);
	  lb_genre.Name = "lb_genre";
	  lb_genre.Size = new Size(38, 15);
	  lb_genre.TabIndex = 5;
	  lb_genre.Text = "Genre";
	  // 
	  // lb_author_name
	  // 
	  lb_author_name.AutoSize = true;
	  lb_author_name.Location = new Point(19, 123);
	  lb_author_name.Name = "lb_author_name";
	  lb_author_name.Size = new Size(44, 15);
	  lb_author_name.TabIndex = 4;
	  lb_author_name.Text = "Author";
	  // 
	  // lb_book_name
	  // 
	  lb_book_name.AutoSize = true;
	  lb_book_name.Location = new Point(19, 80);
	  lb_book_name.Name = "lb_book_name";
	  lb_book_name.Size = new Size(39, 15);
	  lb_book_name.TabIndex = 3;
	  lb_book_name.Text = "Name";
	  // 
	  // tb_genre_name
	  // 
	  tb_genre_name.Location = new Point(109, 166);
	  tb_genre_name.Name = "tb_genre_name";
	  tb_genre_name.Size = new Size(100, 23);
	  tb_genre_name.TabIndex = 2;
	  // 
	  // tb_author_name
	  // 
	  tb_author_name.Location = new Point(109, 120);
	  tb_author_name.Name = "tb_author_name";
	  tb_author_name.Size = new Size(100, 23);
	  tb_author_name.TabIndex = 1;
	  // 
	  // tb_book_name
	  // 
	  tb_book_name.Location = new Point(109, 77);
	  tb_book_name.Name = "tb_book_name";
	  tb_book_name.Size = new Size(100, 23);
	  tb_book_name.TabIndex = 0;
	  // 
	  // tp_student
	  // 
	  tp_student.Location = new Point(4, 24);
	  tp_student.Name = "tp_student";
	  tp_student.Padding = new Padding(3);
	  tp_student.Size = new Size(792, 422);
	  tp_student.TabIndex = 1;
	  tp_student.Text = "Student Lists";
	  tp_student.UseVisualStyleBackColor = true;
	  // 
	  // Admin
	  // 
	  AutoScaleDimensions = new SizeF(7F, 15F);
	  AutoScaleMode = AutoScaleMode.Font;
	  ClientSize = new Size(800, 450);
	  Controls.Add(tabControl1);
	  Name = "Admin";
	  Text = "Admin";
	  Load += Admin_Load;
	  tabControl1.ResumeLayout(false);
	  tp_book.ResumeLayout(false);
	  panel1.ResumeLayout(false);
	  panel1.PerformLayout();
	  ((System.ComponentModel.ISupportInitialize)dgv_book_list).EndInit();
	  lb_genre_name.ResumeLayout(false);
	  lb_genre_name.PerformLayout();
	  ResumeLayout(false);
	}

	#endregion

	private TabControl tabControl1;
	private TabPage tp_book;
	private TabPage tp_student;
	private TextBox tb_book_name;
	private Panel lb_genre_name;
	private Label lb_genre;
	private Label lb_author_name;
	private Label lb_book_name;
	private TextBox tb_genre_name;
	private TextBox tb_author_name;
	private DataGridView dgv_book_list;
	private Button btn_create_book;
	private Panel panel1;
	private Label lb_book_list;
  }
}