namespace LibraryManager
{
  partial class Student
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
	  dgv_book_list = new DataGridView();
	  pn_table_side = new Panel();
	  pn_control_side = new Panel();
	  dtp_date_filter = new DateTimePicker();
	  tb_genre = new TextBox();
	  tb_author = new TextBox();
	  tb_title = new TextBox();
	  btn_reset = new Button();
	  pn_radiobtn = new Panel();
	  rb_borrowed = new RadioButton();
	  rb_not_borrowed = new RadioButton();
	  btn_date_filter = new Button();
	  btn_genre_filter = new Button();
	  btn_author_filter = new Button();
	  btn_title_filter = new Button();
	  btn_borrow_book = new Button();
	  lb_genre = new Label();
	  lb_std_gmail = new Label();
	  lb_std_name = new Label();
	  tb_std_phone_number = new TextBox();
	  tb_std_gmail = new TextBox();
	  tb_std_name = new TextBox();
	  dgv_book_cart = new DataGridView();
	  col_book_id = new DataGridViewTextBoxColumn();
	  col_book_title = new DataGridViewTextBoxColumn();
	  col_author = new DataGridViewTextBoxColumn();
	  col_genre = new DataGridViewTextBoxColumn();
	  col_date = new DataGridViewTextBoxColumn();
	  col_isborrowed = new DataGridViewTextBoxColumn();
	  lb_book_cart = new Label();
	  ((System.ComponentModel.ISupportInitialize)dgv_book_list).BeginInit();
	  pn_table_side.SuspendLayout();
	  pn_control_side.SuspendLayout();
	  pn_radiobtn.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)dgv_book_cart).BeginInit();
	  SuspendLayout();
	  // 
	  // dgv_book_list
	  // 
	  dgv_book_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
	  dgv_book_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  dgv_book_list.Dock = DockStyle.Fill;
	  dgv_book_list.Location = new Point(0, 0);
	  dgv_book_list.Name = "dgv_book_list";
	  dgv_book_list.ReadOnly = true;
	  dgv_book_list.Size = new Size(621, 299);
	  dgv_book_list.TabIndex = 0;
	  dgv_book_list.CellDoubleClick += dgv_book_list_CellDoubleClick;
	  // 
	  // pn_table_side
	  // 
	  pn_table_side.Controls.Add(dgv_book_list);
	  pn_table_side.Location = new Point(12, 12);
	  pn_table_side.Name = "pn_table_side";
	  pn_table_side.Size = new Size(621, 299);
	  pn_table_side.TabIndex = 1;
	  // 
	  // pn_control_side
	  // 
	  pn_control_side.Controls.Add(dtp_date_filter);
	  pn_control_side.Controls.Add(tb_genre);
	  pn_control_side.Controls.Add(tb_author);
	  pn_control_side.Controls.Add(tb_title);
	  pn_control_side.Controls.Add(btn_reset);
	  pn_control_side.Controls.Add(pn_radiobtn);
	  pn_control_side.Controls.Add(btn_date_filter);
	  pn_control_side.Controls.Add(btn_genre_filter);
	  pn_control_side.Controls.Add(btn_author_filter);
	  pn_control_side.Controls.Add(btn_title_filter);
	  pn_control_side.Controls.Add(btn_borrow_book);
	  pn_control_side.Controls.Add(lb_genre);
	  pn_control_side.Controls.Add(lb_std_gmail);
	  pn_control_side.Controls.Add(lb_std_name);
	  pn_control_side.Controls.Add(tb_std_phone_number);
	  pn_control_side.Controls.Add(tb_std_gmail);
	  pn_control_side.Controls.Add(tb_std_name);
	  pn_control_side.Dock = DockStyle.Right;
	  pn_control_side.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  pn_control_side.ImeMode = ImeMode.NoControl;
	  pn_control_side.Location = new Point(639, 0);
	  pn_control_side.Name = "pn_control_side";
	  pn_control_side.Size = new Size(378, 478);
	  pn_control_side.TabIndex = 2;
	  // 
	  // dtp_date_filter
	  // 
	  dtp_date_filter.CustomFormat = "dd/MM/yyyy";
	  dtp_date_filter.Format = DateTimePickerFormat.Custom;
	  dtp_date_filter.Location = new Point(144, 167);
	  dtp_date_filter.Name = "dtp_date_filter";
	  dtp_date_filter.Size = new Size(200, 23);
	  dtp_date_filter.TabIndex = 19;
	  // 
	  // tb_genre
	  // 
	  tb_genre.Location = new Point(144, 134);
	  tb_genre.Name = "tb_genre";
	  tb_genre.Size = new Size(222, 23);
	  tb_genre.TabIndex = 18;
	  // 
	  // tb_author
	  // 
	  tb_author.Location = new Point(144, 98);
	  tb_author.Name = "tb_author";
	  tb_author.Size = new Size(222, 23);
	  tb_author.TabIndex = 17;
	  // 
	  // tb_title
	  // 
	  tb_title.Location = new Point(144, 62);
	  tb_title.Name = "tb_title";
	  tb_title.Size = new Size(222, 23);
	  tb_title.TabIndex = 16;
	  // 
	  // btn_reset
	  // 
	  btn_reset.Cursor = Cursors.Hand;
	  btn_reset.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_reset.ForeColor = Color.Red;
	  btn_reset.Location = new Point(3, 3);
	  btn_reset.Name = "btn_reset";
	  btn_reset.Size = new Size(54, 39);
	  btn_reset.TabIndex = 15;
	  btn_reset.Text = "Reset";
	  btn_reset.UseVisualStyleBackColor = true;
	  btn_reset.Click += btn_reset_Click;
	  // 
	  // pn_radiobtn
	  // 
	  pn_radiobtn.Controls.Add(rb_borrowed);
	  pn_radiobtn.Controls.Add(rb_not_borrowed);
	  pn_radiobtn.Location = new Point(84, 201);
	  pn_radiobtn.Name = "pn_radiobtn";
	  pn_radiobtn.Size = new Size(218, 29);
	  pn_radiobtn.TabIndex = 14;
	  // 
	  // rb_borrowed
	  // 
	  rb_borrowed.AutoSize = true;
	  rb_borrowed.Location = new Point(3, 7);
	  rb_borrowed.Name = "rb_borrowed";
	  rb_borrowed.Size = new Size(81, 19);
	  rb_borrowed.TabIndex = 12;
	  rb_borrowed.TabStop = true;
	  rb_borrowed.Text = "Borrowed";
	  rb_borrowed.UseVisualStyleBackColor = true;
	  // 
	  // rb_not_borrowed
	  // 
	  rb_not_borrowed.AutoSize = true;
	  rb_not_borrowed.Location = new Point(90, 7);
	  rb_not_borrowed.Name = "rb_not_borrowed";
	  rb_not_borrowed.Size = new Size(126, 19);
	  rb_not_borrowed.TabIndex = 13;
	  rb_not_borrowed.TabStop = true;
	  rb_not_borrowed.Text = "Not Borrowed yet";
	  rb_not_borrowed.UseVisualStyleBackColor = true;
	  // 
	  // btn_date_filter
	  // 
	  btn_date_filter.Cursor = Cursors.Hand;
	  btn_date_filter.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_date_filter.Location = new Point(3, 165);
	  btn_date_filter.Name = "btn_date_filter";
	  btn_date_filter.Size = new Size(135, 30);
	  btn_date_filter.TabIndex = 10;
	  btn_date_filter.Text = "Search by Date";
	  btn_date_filter.TextAlign = ContentAlignment.MiddleLeft;
	  btn_date_filter.UseVisualStyleBackColor = true;
	  // 
	  // btn_genre_filter
	  // 
	  btn_genre_filter.Cursor = Cursors.Hand;
	  btn_genre_filter.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_genre_filter.Location = new Point(3, 129);
	  btn_genre_filter.Name = "btn_genre_filter";
	  btn_genre_filter.Size = new Size(135, 30);
	  btn_genre_filter.TabIndex = 9;
	  btn_genre_filter.Text = "Search by Genre";
	  btn_genre_filter.TextAlign = ContentAlignment.MiddleLeft;
	  btn_genre_filter.UseVisualStyleBackColor = true;
	  // 
	  // btn_author_filter
	  // 
	  btn_author_filter.Cursor = Cursors.Hand;
	  btn_author_filter.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_author_filter.Location = new Point(3, 93);
	  btn_author_filter.Name = "btn_author_filter";
	  btn_author_filter.Size = new Size(135, 30);
	  btn_author_filter.TabIndex = 8;
	  btn_author_filter.Text = "Search by Author";
	  btn_author_filter.TextAlign = ContentAlignment.MiddleLeft;
	  btn_author_filter.UseVisualStyleBackColor = true;
	  // 
	  // btn_title_filter
	  // 
	  btn_title_filter.Cursor = Cursors.Hand;
	  btn_title_filter.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_title_filter.Location = new Point(3, 57);
	  btn_title_filter.Name = "btn_title_filter";
	  btn_title_filter.Size = new Size(135, 30);
	  btn_title_filter.TabIndex = 7;
	  btn_title_filter.Text = "Search by Title";
	  btn_title_filter.TextAlign = ContentAlignment.MiddleLeft;
	  btn_title_filter.UseVisualStyleBackColor = true;
	  // 
	  // btn_borrow_book
	  // 
	  btn_borrow_book.BackColor = Color.SeaGreen;
	  btn_borrow_book.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_borrow_book.ForeColor = SystemColors.ControlLightLight;
	  btn_borrow_book.Location = new Point(199, 352);
	  btn_borrow_book.Name = "btn_borrow_book";
	  btn_borrow_book.Size = new Size(81, 33);
	  btn_borrow_book.TabIndex = 6;
	  btn_borrow_book.Text = "Borrow";
	  btn_borrow_book.UseVisualStyleBackColor = false;
	  btn_borrow_book.Click += btn_borrow_book_Click;
	  // 
	  // lb_genre
	  // 
	  lb_genre.AutoSize = true;
	  lb_genre.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_genre.Location = new Point(50, 326);
	  lb_genre.Name = "lb_genre";
	  lb_genre.Size = new Size(134, 16);
	  lb_genre.TabIndex = 5;
	  lb_genre.Text = "Your phone number:";
	  // 
	  // lb_std_gmail
	  // 
	  lb_std_gmail.AutoSize = true;
	  lb_std_gmail.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_std_gmail.Location = new Point(107, 295);
	  lb_std_gmail.Name = "lb_std_gmail";
	  lb_std_gmail.Size = new Size(77, 16);
	  lb_std_gmail.TabIndex = 4;
	  lb_std_gmail.Text = "Your gmail:";
	  // 
	  // lb_std_name
	  // 
	  lb_std_name.AutoSize = true;
	  lb_std_name.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_std_name.Location = new Point(107, 266);
	  lb_std_name.Name = "lb_std_name";
	  lb_std_name.Size = new Size(77, 16);
	  lb_std_name.TabIndex = 3;
	  lb_std_name.Text = "Your name:";
	  // 
	  // tb_std_phone_number
	  // 
	  tb_std_phone_number.Cursor = Cursors.IBeam;
	  tb_std_phone_number.Location = new Point(190, 323);
	  tb_std_phone_number.Name = "tb_std_phone_number";
	  tb_std_phone_number.Size = new Size(100, 23);
	  tb_std_phone_number.TabIndex = 2;
	  // 
	  // tb_std_gmail
	  // 
	  tb_std_gmail.Cursor = Cursors.IBeam;
	  tb_std_gmail.Location = new Point(190, 292);
	  tb_std_gmail.Name = "tb_std_gmail";
	  tb_std_gmail.Size = new Size(100, 23);
	  tb_std_gmail.TabIndex = 1;
	  // 
	  // tb_std_name
	  // 
	  tb_std_name.Cursor = Cursors.IBeam;
	  tb_std_name.Location = new Point(190, 263);
	  tb_std_name.Name = "tb_std_name";
	  tb_std_name.Size = new Size(100, 23);
	  tb_std_name.TabIndex = 0;
	  // 
	  // dgv_book_cart
	  // 
	  dgv_book_cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  dgv_book_cart.Columns.AddRange(new DataGridViewColumn[] { col_book_id, col_book_title, col_author, col_genre, col_date, col_isborrowed });
	  dgv_book_cart.Location = new Point(12, 345);
	  dgv_book_cart.Name = "dgv_book_cart";
	  dgv_book_cart.ReadOnly = true;
	  dgv_book_cart.Size = new Size(621, 121);
	  dgv_book_cart.TabIndex = 3;
	  dgv_book_cart.CellDoubleClick += dgv_book_cart_CellDoubleClick;
	  // 
	  // col_book_id
	  // 
	  col_book_id.HeaderText = "ID";
	  col_book_id.Name = "col_book_id";
	  col_book_id.ReadOnly = true;
	  // 
	  // col_book_title
	  // 
	  col_book_title.HeaderText = "Title";
	  col_book_title.Name = "col_book_title";
	  col_book_title.ReadOnly = true;
	  // 
	  // col_author
	  // 
	  col_author.HeaderText = "Author";
	  col_author.Name = "col_author";
	  col_author.ReadOnly = true;
	  // 
	  // col_genre
	  // 
	  col_genre.HeaderText = "Genre";
	  col_genre.Name = "col_genre";
	  col_genre.ReadOnly = true;
	  // 
	  // col_date
	  // 
	  col_date.HeaderText = "Publish Date";
	  col_date.Name = "col_date";
	  col_date.ReadOnly = true;
	  // 
	  // col_isborrowed
	  // 
	  col_isborrowed.HeaderText = "Borrowed?";
	  col_isborrowed.Name = "col_isborrowed";
	  col_isborrowed.ReadOnly = true;
	  // 
	  // lb_book_cart
	  // 
	  lb_book_cart.AutoSize = true;
	  lb_book_cart.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_book_cart.Location = new Point(12, 323);
	  lb_book_cart.Name = "lb_book_cart";
	  lb_book_cart.Size = new Size(82, 19);
	  lb_book_cart.TabIndex = 4;
	  lb_book_cart.Text = "Your cart:";
	  // 
	  // Student
	  // 
	  AutoScaleDimensions = new SizeF(7F, 15F);
	  AutoScaleMode = AutoScaleMode.Font;
	  ClientSize = new Size(1017, 478);
	  Controls.Add(lb_book_cart);
	  Controls.Add(dgv_book_cart);
	  Controls.Add(pn_control_side);
	  Controls.Add(pn_table_side);
	  Name = "Student";
	  StartPosition = FormStartPosition.CenterScreen;
	  Text = "Student";
	  FormClosed += Student_FormClosed;
	  Load += Student_Load;
	  ((System.ComponentModel.ISupportInitialize)dgv_book_list).EndInit();
	  pn_table_side.ResumeLayout(false);
	  pn_control_side.ResumeLayout(false);
	  pn_control_side.PerformLayout();
	  pn_radiobtn.ResumeLayout(false);
	  pn_radiobtn.PerformLayout();
	  ((System.ComponentModel.ISupportInitialize)dgv_book_cart).EndInit();
	  ResumeLayout(false);
	  PerformLayout();
	}

	#endregion

	private DataGridView dgv_book_list;
	private Panel pn_table_side;
	private Panel pn_control_side;
	private Button btn_borrow_book;
	private Label lb_genre;
	private Label lb_std_gmail;
	private Label lb_std_name;
	private TextBox tb_std_phone_number;
	private TextBox tb_std_gmail;
	private TextBox tb_std_name;
	private Button btn_title_filter;
	private Button btn_genre_filter;
	private Button btn_author_filter;
	private Button btn_date_filter;
	private RadioButton rb_borrowed;
	private Panel pn_radiobtn;
	private RadioButton rb_not_borrowed;
	private Button btn_reset;
	private TextBox tb_title;
	private DateTimePicker dtp_date_filter;
	private TextBox tb_genre;
	private TextBox tb_author;
	private DataGridView dgv_book_cart;
	private Label lb_book_cart;
	private DataGridViewTextBoxColumn col_book_id;
	private DataGridViewTextBoxColumn col_book_title;
	private DataGridViewTextBoxColumn col_author;
	private DataGridViewTextBoxColumn col_genre;
	private DataGridViewTextBoxColumn col_date;
	private DataGridViewTextBoxColumn col_isborrowed;
  }
}