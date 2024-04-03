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
	  dataGridView1 = new DataGridView();
	  panel1 = new Panel();
	  lb_book_list = new Label();
	  lb_genre_name = new Panel();
	  btn_borrow_book = new Button();
	  lb_genre = new Label();
	  lb_std_gmail = new Label();
	  lb_std_name = new Label();
	  tb_std_phone_number = new TextBox();
	  tb_std_gmail = new TextBox();
	  tb_std_name = new TextBox();
	  ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
	  panel1.SuspendLayout();
	  lb_genre_name.SuspendLayout();
	  SuspendLayout();
	  // 
	  // dataGridView1
	  // 
	  dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  dataGridView1.Dock = DockStyle.Bottom;
	  dataGridView1.Location = new Point(0, 44);
	  dataGridView1.Name = "dataGridView1";
	  dataGridView1.Size = new Size(416, 406);
	  dataGridView1.TabIndex = 0;
	  // 
	  // panel1
	  // 
	  panel1.Controls.Add(lb_book_list);
	  panel1.Controls.Add(dataGridView1);
	  panel1.Dock = DockStyle.Left;
	  panel1.Location = new Point(0, 0);
	  panel1.Name = "panel1";
	  panel1.Size = new Size(416, 450);
	  panel1.TabIndex = 1;
	  // 
	  // lb_book_list
	  // 
	  lb_book_list.AutoSize = true;
	  lb_book_list.Font = new Font("Cambria", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
	  lb_book_list.Location = new Point(12, 9);
	  lb_book_list.Name = "lb_book_list";
	  lb_book_list.Size = new Size(122, 32);
	  lb_book_list.TabIndex = 10;
	  lb_book_list.Text = "Book List";
	  // 
	  // lb_genre_name
	  // 
	  lb_genre_name.Controls.Add(btn_borrow_book);
	  lb_genre_name.Controls.Add(lb_genre);
	  lb_genre_name.Controls.Add(lb_std_gmail);
	  lb_genre_name.Controls.Add(lb_std_name);
	  lb_genre_name.Controls.Add(tb_std_phone_number);
	  lb_genre_name.Controls.Add(tb_std_gmail);
	  lb_genre_name.Controls.Add(tb_std_name);
	  lb_genre_name.Dock = DockStyle.Right;
	  lb_genre_name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_genre_name.ImeMode = ImeMode.NoControl;
	  lb_genre_name.Location = new Point(422, 0);
	  lb_genre_name.Name = "lb_genre_name";
	  lb_genre_name.Size = new Size(378, 450);
	  lb_genre_name.TabIndex = 2;
	  // 
	  // btn_borrow_book
	  // 
	  btn_borrow_book.BackColor = Color.SeaGreen;
	  btn_borrow_book.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  btn_borrow_book.ForeColor = SystemColors.ControlLightLight;
	  btn_borrow_book.Location = new Point(137, 213);
	  btn_borrow_book.Name = "btn_borrow_book";
	  btn_borrow_book.Size = new Size(81, 33);
	  btn_borrow_book.TabIndex = 6;
	  btn_borrow_book.Text = "Borrow";
	  btn_borrow_book.UseVisualStyleBackColor = false;
	  // 
	  // lb_genre
	  // 
	  lb_genre.AutoSize = true;
	  lb_genre.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_genre.Location = new Point(19, 169);
	  lb_genre.Name = "lb_genre";
	  lb_genre.Size = new Size(132, 15);
	  lb_genre.TabIndex = 5;
	  lb_genre.Text = "Your phone number:";
	  // 
	  // lb_std_gmail
	  // 
	  lb_std_gmail.AutoSize = true;
	  lb_std_gmail.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_std_gmail.Location = new Point(19, 123);
	  lb_std_gmail.Name = "lb_std_gmail";
	  lb_std_gmail.Size = new Size(77, 16);
	  lb_std_gmail.TabIndex = 4;
	  lb_std_gmail.Text = "Your gmail:";
	  // 
	  // lb_std_name
	  // 
	  lb_std_name.AutoSize = true;
	  lb_std_name.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
	  lb_std_name.Location = new Point(19, 80);
	  lb_std_name.Name = "lb_std_name";
	  lb_std_name.Size = new Size(77, 16);
	  lb_std_name.TabIndex = 3;
	  lb_std_name.Text = "Your name:";
	  // 
	  // tb_std_phone_number
	  // 
	  tb_std_phone_number.Cursor = Cursors.Hand;
	  tb_std_phone_number.Location = new Point(152, 166);
	  tb_std_phone_number.Name = "tb_std_phone_number";
	  tb_std_phone_number.Size = new Size(100, 23);
	  tb_std_phone_number.TabIndex = 2;
	  // 
	  // tb_std_gmail
	  // 
	  tb_std_gmail.Cursor = Cursors.Hand;
	  tb_std_gmail.Location = new Point(152, 120);
	  tb_std_gmail.Name = "tb_std_gmail";
	  tb_std_gmail.Size = new Size(100, 23);
	  tb_std_gmail.TabIndex = 1;
	  // 
	  // tb_std_name
	  // 
	  tb_std_name.Cursor = Cursors.Hand;
	  tb_std_name.Location = new Point(152, 77);
	  tb_std_name.Name = "tb_std_name";
	  tb_std_name.Size = new Size(100, 23);
	  tb_std_name.TabIndex = 0;
	  // 
	  // Student
	  // 
	  AutoScaleDimensions = new SizeF(7F, 15F);
	  AutoScaleMode = AutoScaleMode.Font;
	  ClientSize = new Size(800, 450);
	  Controls.Add(lb_genre_name);
	  Controls.Add(panel1);
	  Name = "Student";
	  StartPosition = FormStartPosition.CenterScreen;
	  Text = "Student";
	  FormClosed += Student_FormClosed;
	  ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
	  panel1.ResumeLayout(false);
	  panel1.PerformLayout();
	  lb_genre_name.ResumeLayout(false);
	  lb_genre_name.PerformLayout();
	  ResumeLayout(false);
	}

	#endregion

	private DataGridView dataGridView1;
	private Panel panel1;
	private Panel lb_genre_name;
	private Button btn_borrow_book;
	private Label lb_genre;
	private Label lb_std_gmail;
	private Label lb_std_name;
	private TextBox tb_std_phone_number;
	private TextBox tb_std_gmail;
	private TextBox tb_std_name;
	private Label lb_book_list;
  }
}