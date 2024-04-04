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
	  pn_book_table = new Panel();
	  lb_book_list = new Label();
	  dgv_book_list = new DataGridView();
	  lb_genre_name = new Panel();
	  btn_reset = new Button();
	  cb_isBorrowed = new CheckBox();
	  tb_book_id = new TextBox();
	  lb_book_id = new Label();
	  btn_delete_book = new Button();
	  btn_update_book = new Button();
	  btn_create_book = new Button();
	  lb_genre = new Label();
	  lb_author_name = new Label();
	  lb_book_name = new Label();
	  tb_genre_name = new TextBox();
	  tb_author_name = new TextBox();
	  tb_book_name = new TextBox();
	  tp_student = new TabPage();
	  btn_remove_std = new Button();
	  panel1 = new Panel();
	  tb_std_id = new TextBox();
	  dgv_std_list = new DataGridView();
	  label2 = new Label();
	  pn_student_table = new Panel();
	  btn_refresh = new Button();
	  label1 = new Label();
	  dgv_borrowed_book = new DataGridView();
	  tabControl1.SuspendLayout();
	  tp_book.SuspendLayout();
	  pn_book_table.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)dgv_book_list).BeginInit();
	  lb_genre_name.SuspendLayout();
	  tp_student.SuspendLayout();
	  panel1.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)dgv_std_list).BeginInit();
	  pn_student_table.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)dgv_borrowed_book).BeginInit();
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
	  tabControl1.Size = new Size(937, 450);
	  tabControl1.TabIndex = 0;
	  // 
	  // tp_book
	  // 
	  tp_book.Controls.Add(pn_book_table);
	  tp_book.Controls.Add(lb_genre_name);
	  tp_book.Location = new Point(4, 24);
	  tp_book.Name = "tp_book";
	  tp_book.Padding = new Padding(3);
	  tp_book.Size = new Size(929, 422);
	  tp_book.TabIndex = 0;
	  tp_book.Text = "Book Lists";
	  tp_book.UseVisualStyleBackColor = true;
	  // 
	  // pn_book_table
	  // 
	  pn_book_table.Controls.Add(lb_book_list);
	  pn_book_table.Controls.Add(dgv_book_list);
	  pn_book_table.Dock = DockStyle.Fill;
	  pn_book_table.Location = new Point(3, 3);
	  pn_book_table.Name = "pn_book_table";
	  pn_book_table.Size = new Size(623, 416);
	  pn_book_table.TabIndex = 2;
	  // 
	  // lb_book_list
	  // 
	  lb_book_list.AutoSize = true;
	  lb_book_list.Font = new Font("Cambria", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
	  lb_book_list.Location = new Point(5, 0);
	  lb_book_list.Name = "lb_book_list";
	  lb_book_list.Size = new Size(134, 32);
	  lb_book_list.TabIndex = 7;
	  lb_book_list.Text = "Book Lists";
	  // 
	  // dgv_book_list
	  // 
	  dgv_book_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
	  dgv_book_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  dgv_book_list.Dock = DockStyle.Bottom;
	  dgv_book_list.Location = new Point(0, 35);
	  dgv_book_list.Name = "dgv_book_list";
	  dgv_book_list.ReadOnly = true;
	  dgv_book_list.Size = new Size(623, 381);
	  dgv_book_list.TabIndex = 2;
	  dgv_book_list.CellClick += dgv_book_list_CellClick;
	  // 
	  // lb_genre_name
	  // 
	  lb_genre_name.Controls.Add(btn_reset);
	  lb_genre_name.Controls.Add(cb_isBorrowed);
	  lb_genre_name.Controls.Add(tb_book_id);
	  lb_genre_name.Controls.Add(lb_book_id);
	  lb_genre_name.Controls.Add(btn_delete_book);
	  lb_genre_name.Controls.Add(btn_update_book);
	  lb_genre_name.Controls.Add(btn_create_book);
	  lb_genre_name.Controls.Add(lb_genre);
	  lb_genre_name.Controls.Add(lb_author_name);
	  lb_genre_name.Controls.Add(lb_book_name);
	  lb_genre_name.Controls.Add(tb_genre_name);
	  lb_genre_name.Controls.Add(tb_author_name);
	  lb_genre_name.Controls.Add(tb_book_name);
	  lb_genre_name.Dock = DockStyle.Right;
	  lb_genre_name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_genre_name.ImeMode = ImeMode.NoControl;
	  lb_genre_name.Location = new Point(626, 3);
	  lb_genre_name.Name = "lb_genre_name";
	  lb_genre_name.Size = new Size(300, 416);
	  lb_genre_name.TabIndex = 1;
	  // 
	  // btn_reset
	  // 
	  btn_reset.BackColor = Color.Honeydew;
	  btn_reset.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_reset.ForeColor = Color.Red;
	  btn_reset.Location = new Point(214, 8);
	  btn_reset.Name = "btn_reset";
	  btn_reset.Size = new Size(81, 33);
	  btn_reset.TabIndex = 14;
	  btn_reset.Text = "Reset";
	  btn_reset.UseVisualStyleBackColor = false;
	  btn_reset.Click += btn_reset_Click;
	  // 
	  // cb_isBorrowed
	  // 
	  cb_isBorrowed.AutoSize = true;
	  cb_isBorrowed.Location = new Point(192, 47);
	  cb_isBorrowed.Name = "cb_isBorrowed";
	  cb_isBorrowed.Size = new Size(82, 19);
	  cb_isBorrowed.TabIndex = 13;
	  cb_isBorrowed.Text = "Borrowed";
	  cb_isBorrowed.UseVisualStyleBackColor = true;
	  // 
	  // tb_book_id
	  // 
	  tb_book_id.Cursor = Cursors.No;
	  tb_book_id.ForeColor = Color.Red;
	  tb_book_id.Location = new Point(87, 45);
	  tb_book_id.Name = "tb_book_id";
	  tb_book_id.ReadOnly = true;
	  tb_book_id.Size = new Size(41, 23);
	  tb_book_id.TabIndex = 11;
	  // 
	  // lb_book_id
	  // 
	  lb_book_id.AutoSize = true;
	  lb_book_id.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_book_id.Location = new Point(27, 48);
	  lb_book_id.Name = "lb_book_id";
	  lb_book_id.Size = new Size(54, 15);
	  lb_book_id.TabIndex = 10;
	  lb_book_id.Text = "Book ID";
	  // 
	  // btn_delete_book
	  // 
	  btn_delete_book.BackColor = Color.Crimson;
	  btn_delete_book.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_delete_book.ForeColor = SystemColors.ControlLightLight;
	  btn_delete_book.Location = new Point(214, 213);
	  btn_delete_book.Name = "btn_delete_book";
	  btn_delete_book.Size = new Size(81, 33);
	  btn_delete_book.TabIndex = 9;
	  btn_delete_book.Text = "Delete";
	  btn_delete_book.UseVisualStyleBackColor = false;
	  btn_delete_book.Click += btn_delete_book_Click;
	  // 
	  // btn_update_book
	  // 
	  btn_update_book.BackColor = Color.Gold;
	  btn_update_book.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_update_book.ForeColor = SystemColors.ControlLightLight;
	  btn_update_book.Location = new Point(109, 213);
	  btn_update_book.Name = "btn_update_book";
	  btn_update_book.Size = new Size(81, 33);
	  btn_update_book.TabIndex = 8;
	  btn_update_book.Text = "Update";
	  btn_update_book.UseVisualStyleBackColor = false;
	  btn_update_book.Click += btn_update_book_Click;
	  // 
	  // btn_create_book
	  // 
	  btn_create_book.BackColor = Color.SeaGreen;
	  btn_create_book.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_create_book.ForeColor = SystemColors.ControlLightLight;
	  btn_create_book.Location = new Point(6, 213);
	  btn_create_book.Name = "btn_create_book";
	  btn_create_book.Size = new Size(81, 33);
	  btn_create_book.TabIndex = 6;
	  btn_create_book.Text = "Create";
	  btn_create_book.UseVisualStyleBackColor = false;
	  btn_create_book.Click += btn_create_book_Click;
	  // 
	  // lb_genre
	  // 
	  lb_genre.AutoSize = true;
	  lb_genre.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_genre.Location = new Point(38, 169);
	  lb_genre.Name = "lb_genre";
	  lb_genre.Size = new Size(43, 15);
	  lb_genre.TabIndex = 5;
	  lb_genre.Text = "Genre";
	  // 
	  // lb_author_name
	  // 
	  lb_author_name.AutoSize = true;
	  lb_author_name.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_author_name.Location = new Point(32, 123);
	  lb_author_name.Name = "lb_author_name";
	  lb_author_name.Size = new Size(49, 15);
	  lb_author_name.TabIndex = 4;
	  lb_author_name.Text = "Author";
	  // 
	  // lb_book_name
	  // 
	  lb_book_name.AutoSize = true;
	  lb_book_name.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_book_name.Location = new Point(39, 80);
	  lb_book_name.Name = "lb_book_name";
	  lb_book_name.Size = new Size(42, 15);
	  lb_book_name.TabIndex = 3;
	  lb_book_name.Text = "Name";
	  // 
	  // tb_genre_name
	  // 
	  tb_genre_name.Cursor = Cursors.IBeam;
	  tb_genre_name.Location = new Point(87, 166);
	  tb_genre_name.Name = "tb_genre_name";
	  tb_genre_name.Size = new Size(187, 23);
	  tb_genre_name.TabIndex = 2;
	  // 
	  // tb_author_name
	  // 
	  tb_author_name.Cursor = Cursors.IBeam;
	  tb_author_name.Location = new Point(87, 120);
	  tb_author_name.Name = "tb_author_name";
	  tb_author_name.Size = new Size(187, 23);
	  tb_author_name.TabIndex = 1;
	  // 
	  // tb_book_name
	  // 
	  tb_book_name.Cursor = Cursors.IBeam;
	  tb_book_name.Location = new Point(87, 77);
	  tb_book_name.Name = "tb_book_name";
	  tb_book_name.Size = new Size(187, 23);
	  tb_book_name.TabIndex = 0;
	  // 
	  // tp_student
	  // 
	  tp_student.Controls.Add(btn_remove_std);
	  tp_student.Controls.Add(panel1);
	  tp_student.Controls.Add(pn_student_table);
	  tp_student.Location = new Point(4, 24);
	  tp_student.Name = "tp_student";
	  tp_student.Padding = new Padding(3);
	  tp_student.Size = new Size(929, 422);
	  tp_student.TabIndex = 1;
	  tp_student.Text = "Student Lists";
	  tp_student.UseVisualStyleBackColor = true;
	  // 
	  // btn_remove_std
	  // 
	  btn_remove_std.BackColor = Color.Crimson;
	  btn_remove_std.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_remove_std.ForeColor = SystemColors.ControlLightLight;
	  btn_remove_std.Location = new Point(441, 259);
	  btn_remove_std.Name = "btn_remove_std";
	  btn_remove_std.Size = new Size(128, 33);
	  btn_remove_std.TabIndex = 10;
	  btn_remove_std.Text = "Remove Student";
	  btn_remove_std.UseVisualStyleBackColor = false;
	  btn_remove_std.Click += btn_remove_std_Click;
	  // 
	  // panel1
	  // 
	  panel1.Controls.Add(tb_std_id);
	  panel1.Controls.Add(dgv_std_list);
	  panel1.Controls.Add(label2);
	  panel1.Location = new Point(3, 224);
	  panel1.Name = "panel1";
	  panel1.Size = new Size(432, 192);
	  panel1.TabIndex = 1;
	  // 
	  // tb_std_id
	  // 
	  tb_std_id.Location = new Point(168, 9);
	  tb_std_id.Name = "tb_std_id";
	  tb_std_id.Size = new Size(49, 23);
	  tb_std_id.TabIndex = 10;
	  tb_std_id.Visible = false;
	  // 
	  // dgv_std_list
	  // 
	  dgv_std_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
	  dgv_std_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  dgv_std_list.Dock = DockStyle.Bottom;
	  dgv_std_list.Location = new Point(0, 35);
	  dgv_std_list.Name = "dgv_std_list";
	  dgv_std_list.ReadOnly = true;
	  dgv_std_list.Size = new Size(432, 157);
	  dgv_std_list.TabIndex = 2;
	  dgv_std_list.CellClick += dgv_std_list_CellClick;
	  // 
	  // label2
	  // 
	  label2.AutoSize = true;
	  label2.Font = new Font("Cambria", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
	  label2.Location = new Point(5, 0);
	  label2.Name = "label2";
	  label2.Size = new Size(164, 32);
	  label2.TabIndex = 9;
	  label2.Text = "Student Lists";
	  // 
	  // pn_student_table
	  // 
	  pn_student_table.Controls.Add(btn_refresh);
	  pn_student_table.Controls.Add(label1);
	  pn_student_table.Controls.Add(dgv_borrowed_book);
	  pn_student_table.Location = new Point(3, 6);
	  pn_student_table.Name = "pn_student_table";
	  pn_student_table.Size = new Size(918, 212);
	  pn_student_table.TabIndex = 0;
	  // 
	  // btn_refresh
	  // 
	  btn_refresh.BackColor = Color.RoyalBlue;
	  btn_refresh.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_refresh.ForeColor = SystemColors.ControlLightLight;
	  btn_refresh.Location = new Point(216, -1);
	  btn_refresh.Name = "btn_refresh";
	  btn_refresh.Size = new Size(71, 33);
	  btn_refresh.TabIndex = 11;
	  btn_refresh.Text = "Refresh";
	  btn_refresh.UseVisualStyleBackColor = false;
	  btn_refresh.Click += btn_refresh_Click;
	  // 
	  // label1
	  // 
	  label1.AutoSize = true;
	  label1.Font = new Font("Cambria", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
	  label1.Location = new Point(3, 0);
	  label1.Name = "label1";
	  label1.Size = new Size(207, 32);
	  label1.TabIndex = 8;
	  label1.Text = "Borrowed Books";
	  // 
	  // dgv_borrowed_book
	  // 
	  dgv_borrowed_book.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
	  dgv_borrowed_book.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  dgv_borrowed_book.Dock = DockStyle.Bottom;
	  dgv_borrowed_book.Location = new Point(0, 35);
	  dgv_borrowed_book.Name = "dgv_borrowed_book";
	  dgv_borrowed_book.ReadOnly = true;
	  dgv_borrowed_book.Size = new Size(918, 177);
	  dgv_borrowed_book.TabIndex = 0;
	  // 
	  // Admin
	  // 
	  AutoScaleDimensions = new SizeF(7F, 15F);
	  AutoScaleMode = AutoScaleMode.Font;
	  ClientSize = new Size(937, 450);
	  Controls.Add(tabControl1);
	  Name = "Admin";
	  StartPosition = FormStartPosition.CenterScreen;
	  Text = "Admin";
	  FormClosed += Admin_FormClosed;
	  Load += Admin_Load;
	  tabControl1.ResumeLayout(false);
	  tp_book.ResumeLayout(false);
	  pn_book_table.ResumeLayout(false);
	  pn_book_table.PerformLayout();
	  ((System.ComponentModel.ISupportInitialize)dgv_book_list).EndInit();
	  lb_genre_name.ResumeLayout(false);
	  lb_genre_name.PerformLayout();
	  tp_student.ResumeLayout(false);
	  panel1.ResumeLayout(false);
	  panel1.PerformLayout();
	  ((System.ComponentModel.ISupportInitialize)dgv_std_list).EndInit();
	  pn_student_table.ResumeLayout(false);
	  pn_student_table.PerformLayout();
	  ((System.ComponentModel.ISupportInitialize)dgv_borrowed_book).EndInit();
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
	private Panel pn_book_table;
	private Label lb_book_list;
	private Button btn_delete_book;
	private Button btn_update_book;
	private Label lb_book_id;
	private TextBox tb_book_id;
	private CheckBox cb_isBorrowed;
	private Button btn_reset;
	private Panel pn;
	private DataGridView dgv_borrowed_book;
	private Panel pn_student_table;
	private Label label1;
	private Panel panel1;
	private DataGridView dgv_std_list;
	private Label label2;
	private Button btn_remove_std;
	private TextBox tb_std_id;
	private Button btn_refresh;
  }
}