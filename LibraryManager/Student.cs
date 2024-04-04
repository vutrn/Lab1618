using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
  public partial class Student : Form
  {
	public Student()
	{
	  InitializeComponent();

	}

	SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0T3CC97;Initial Catalog=1618LibraryManager;Integrated Security=True;Trust Server Certificate=True");

	private void DisplayData()
	{
	  conn.Open();
	  SqlCommand cmd = conn.CreateCommand();
	  //cmd.CommandType = CommandType.Text;
	  cmd.CommandText = "SELECT " +
							"book_id AS [ID], " +
							"book_name AS [Title], " +
							"author_name AS [Author], " +
							"genre_name AS [Genre], " +
							"FORMAT(publication_date, 'dd/MM/yyyy') AS [Publish Date], " +
							"isBorrowed AS [Borrowed?] " +
						"FROM book ORDER BY book_id DESC";
	  cmd.ExecuteNonQuery();
	  DataTable dt = new DataTable();
	  SqlDataAdapter da = new SqlDataAdapter(cmd);
	  da.Fill(dt);
	  dgv_book_list.DataSource = dt;
	  conn.Close();
	}

	private void ClearData()
	{
	  tb_title.Text = "";
	  tb_author.Text = "";
	  tb_genre.Text = "";
	  tb_std_name.Text = "";
	  tb_std_gmail.Text = "";
	  tb_std_phone_number.Text = "";
	  dtp_date_filter.Value = DateTime.Now;
	  rb_borrowed.Checked = false;
	  rb_not_borrowed.Checked = false;
	  dgv_book_cart.Rows.Clear();
	  DisplayData();
	}


	private void dgv_book_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	  // Check if a valid row is double-clicked
	  if (e.RowIndex >= 0)
	  {
		// Get the selected row
		DataGridViewRow selectedRow = dgv_book_list.Rows[e.RowIndex];

		// Extract data from the selected row
		string bookId = selectedRow.Cells[0].Value.ToString();
		string title = selectedRow.Cells[1].Value.ToString();
		string author = selectedRow.Cells[2].Value.ToString();
		string genre = selectedRow.Cells[3].Value.ToString();
		string publishDate = selectedRow.Cells[4].Value.ToString();
		bool isBorrowed = (bool)selectedRow.Cells[5].Value;

		dgv_book_cart.Rows.Add(bookId, title, author, genre, publishDate, isBorrowed);
	  }
	}

	private void btn_borrow_book_Click(object sender, EventArgs e)
	{
	  // Check if student information is provided
	  if (string.IsNullOrWhiteSpace(tb_std_name.Text) || string.IsNullOrWhiteSpace(tb_std_gmail.Text) || string.IsNullOrWhiteSpace(tb_std_phone_number.Text))
	  {
		MessageBox.Show("Please provide student information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		return;
	  }
	  // Check if there are books to borrow
	  if (dgv_book_cart.Rows.Count == 0)
	  {
		MessageBox.Show("No books to borrow.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		return;
	  }

	  try
	  {
		foreach (DataGridViewRow row in dgv_book_cart.Rows)
		{
		  if (Convert.ToBoolean(row.Cells[5].Value) == true && row.Cells[5].Value != null)
		  {
			MessageBox.Show("Warning: One or more books in the cart are already borrowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return; // Stop further execution
		  }
		}
		conn.Open();
		// Insert student information into the database
		string insertQuery = "INSERT INTO Student (std_name, std_gmail, std_phone_number) " +
									$"VALUES ('{tb_std_name.Text}', '{tb_std_gmail.Text}', '{tb_std_phone_number.Text}');" +
									$"SELECT SCOPE_IDENTITY();"; // Retrieve the inserted student's ID";

		SqlCommand insertStudentCmd = new SqlCommand(insertQuery, conn);
		insertStudentCmd.ExecuteNonQuery();
		//conn.Close();

		// Get the student ID of the inserted student
		string getStudentIdQuery = "SELECT MAX(std_id) FROM Student;";
		SqlCommand getStudentIdCmd = new SqlCommand(getStudentIdQuery, conn);
		//conn.Open();
		int studentId = Convert.ToInt32(getStudentIdCmd.ExecuteScalar());
		conn.Close();
		// -1 to avoid reaching the bottom of the datagridview that occur error
		for (int i = 0; i < dgv_book_cart.Rows.Count - 1; i++)
		{
		  DataGridViewRow row = dgv_book_cart.Rows[i];
		  string bookId = row.Cells[0].Value.ToString();

		  string updateIsBorrowedQuery = "UPDATE book " +
									    $"SET isBorrowed = 1, std_id ={studentId}" +
									    $"WHERE book_id = {bookId};";
		  SqlCommand updateIsBorrowedCmd = new SqlCommand(updateIsBorrowedQuery, conn);
		  conn.Open();
		  updateIsBorrowedCmd.ExecuteNonQuery();
		  conn.Close();
		}

		MessageBox.Show("Books borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		ClearData();

	  }
	  catch (Exception ex)
	  {
		MessageBox.Show(ex.Message);
	  }
	}

	private void dgv_book_cart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	  // Check if a valid row is double-clicked
	  if (e.RowIndex >= 0)
	  {
		// Remove the selected row
		dgv_book_cart.Rows.RemoveAt(e.RowIndex);
	  }
	}

	//SEARCH FUNCTION ----------------------------------------------------------------- 
	
	private void btn_title_filter_Click(object sender, EventArgs e)
	{
	  conn.Open();
	  string query = "SELECT " +
							"book_id AS [ID], " +
							"book_name AS [Title], " +
							"author_name AS [Author], " +
							"genre_name AS [Genre], " +
							"FORMAT(publication_date, 'dd/MM/yyyy') AS [Publish Date], " +
							"isBorrowed AS [Borrowed?] " +
						"FROM Book " +
						$"WHERE book_name LIKE '%{tb_title.Text}%' " +
						"ORDER BY book_id DESC ";
	  SqlCommand cmd = new SqlCommand(query, conn);
	  DataTable dt = new DataTable();
	  SqlDataAdapter da = new SqlDataAdapter(cmd);
	  da.Fill(dt);
	  dgv_book_list.DataSource = dt;
	  conn.Close();
	}

	private void btn_author_filter_Click(object sender, EventArgs e)
	{
	  conn.Open();
	  string query = "SELECT " +
						  "book_id AS [ID], " +
						  "book_name AS [Title], " +
						  "author_name AS [Author], " +
						  "genre_name AS [Genre], " +
						  "FORMAT(publication_date, 'dd/MM/yyyy') AS [Publish Date], " +
						  "isBorrowed AS [Borrowed?] " +
					  "FROM Book " +
					  $"WHERE author_name LIKE '%{tb_author.Text}%' " +
					  "ORDER BY book_id DESC ";
	  SqlCommand cmd = new SqlCommand(query, conn);
	  DataTable dt = new DataTable();
	  SqlDataAdapter da = new SqlDataAdapter(cmd);
	  da.Fill(dt);
	  dgv_book_list.DataSource = dt;
	  conn.Close();
	}

	private void btn_genre_filter_Click(object sender, EventArgs e)
	{
	  conn.Open();
	  string query = "SELECT " +
						  "book_id AS [ID], " +
						  "book_name AS [Title], " +
						  "author_name AS [Author], " +
						  "genre_name AS [Genre], " +
						  "FORMAT(publication_date, 'dd/MM/yyyy') AS [Publish Date], " +
						  "isBorrowed AS [Borrowed?] " +
					  "FROM Book " +
					  $"WHERE genre_name LIKE '%{tb_genre.Text}%' " +
					  "ORDER BY book_id DESC ";
	  SqlCommand cmd = new SqlCommand(query, conn);
	  DataTable dt = new DataTable();
	  SqlDataAdapter da = new SqlDataAdapter(cmd);
	  da.Fill(dt);
	  dgv_book_list.DataSource = dt;
	  conn.Close();

	}

	private void btn_date_filter_Click(object sender, EventArgs e)
	{
	  conn.Open();
	  string query = "SELECT " +
						  "book_id AS [ID], " +
						  "book_name AS [Title], " +
						  "author_name AS [Author], " +
						  "genre_name AS [Genre], " +
						  "FORMAT(publication_date, 'dd/MM/yyyy') AS [Publish Date], " +
						  "isBorrowed AS [Borrowed?] " +
					  "FROM Book " +
					  $"WHERE publication_date = '{dtp_date_filter.Value.ToString("yyyy/MM/dd")}' " +
					  "ORDER BY book_id DESC ";
	  SqlCommand cmd = new SqlCommand(query, conn);
	  DataTable dt = new DataTable();
	  SqlDataAdapter da = new SqlDataAdapter(cmd);
	  da.Fill(dt);
	  dgv_book_list.DataSource = dt;
	  conn.Close();

	}

	private void rb_borrowed_CheckedChanged(object sender, EventArgs e)
	{
	  if (rb_borrowed.Checked)
	  {
		conn.Open();
		string query = "SELECT " +
							"book_id AS [ID], " +
							"book_name AS [Title], " +
							"author_name AS [Author], " +
							"genre_name AS [Genre], " +
							"FORMAT(publication_date, 'dd/MM/yyyy') AS [Publish Date], " +
							"isBorrowed AS [Borrowed?] " +
						"FROM Book " +
						"WHERE isBorrowed = 1 " +
						"ORDER BY book_id DESC ";
		SqlCommand cmd = new SqlCommand(query, conn);
		DataTable dt = new DataTable();
		SqlDataAdapter da = new SqlDataAdapter(cmd);
		da.Fill(dt);
		dgv_book_list.DataSource = dt;
		conn.Close();
	  }

	}

	private void rb_not_borrowed_CheckedChanged(object sender, EventArgs e)
	{
	  if (rb_not_borrowed.Checked)
	  {
		conn.Open();
		string query = "SELECT " +
							"book_id AS [ID], " +
							"book_name AS [Title], " +
							"author_name AS [Author], " +
							"genre_name AS [Genre], " +
							"FORMAT(publication_date, 'dd/MM/yyyy') AS [Publish Date], " +
							"isBorrowed AS [Borrowed?] " +
						"FROM Book " +
						"WHERE isBorrowed = 0 " +
						"ORDER BY book_id DESC ";
		SqlCommand cmd = new SqlCommand(query, conn);
		DataTable dt = new DataTable();
		SqlDataAdapter da = new SqlDataAdapter(cmd);
		da.Fill(dt);
		dgv_book_list.DataSource = dt;
		conn.Close();
	  }

	}
	private void Student_FormClosed(object sender, FormClosedEventArgs e)
	{
	  Login login = new Login();
	  login.Show();
	}

	private void Student_Load(object sender, EventArgs e)
	{
	  DisplayData();
	}

	private void btn_reset_Click(object sender, EventArgs e)
	{
	  ClearData();
	}
  }
}
