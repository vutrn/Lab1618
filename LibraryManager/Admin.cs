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
  public partial class Admin : Form
  {
	public Admin()
	{
	  InitializeComponent();
	}

	SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0T3CC97;Initial Catalog=1618LibraryManager;Integrated Security=True;Trust Server Certificate=True");

	private void DisplayAllData()
	{
	  conn.Open();
	  SqlCommand cmd = conn.CreateCommand();
	  cmd.CommandType = CommandType.Text;
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

	private void DisplayBorrowedBook()
	{
	  conn.Open();
	  SqlCommand cmd = conn.CreateCommand();
	  cmd.CommandType = CommandType.Text;
	  cmd.CommandText = "SELECT " +
							"book_id AS [Book ID], " +
							"book_name AS [Title], " +
							"author_name AS [Author], " +
							"genre_name AS [Genre], " +
							"FORMAT(publication_date, 'dd/MM/yyyy') AS [Publish Date], " +
							"Student.std_id AS [Student ID], " +
							"Student.std_name AS [Student Name] " +
						"FROM Book JOIN	Student	ON Book.std_id = Student.std_id " +
						"WHERE Book.isBorrowed = 1 " +
						"ORDER BY book_id DESC ";
	  cmd.ExecuteNonQuery();
	  DataTable dt = new DataTable();
	  SqlDataAdapter da = new SqlDataAdapter(cmd);
	  da.Fill(dt);
	  dgv_borrowed_book.DataSource = dt;
	  conn.Close();
	}

	private void DisplayStudent()
	{
	  conn.Open();
	  SqlCommand cmd = conn.CreateCommand();
	  cmd.CommandType = CommandType.Text;
	  cmd.CommandText = "SELECT " +
							"std_id AS [Student ID], " +
							"std_name AS [Name], " +
					  		"std_gmail AS [Gmail], " +
							"std_phone_number AS [Phone Number] " +
						"FROM Student " +
						"ORDER BY std_id DESC";
	  cmd.ExecuteNonQuery();
	  DataTable dt = new DataTable();
	  SqlDataAdapter da = new SqlDataAdapter(cmd);
	  da.Fill(dt);
	  dgv_std_list.DataSource = dt;
	  conn.Close();
	}

	private void ClearData()
	{
	  tb_book_id.Text = "";
	  tb_book_name.Text = "";
	  tb_author_name.Text = "";
	  tb_genre_name.Text = "";
	  cb_isBorrowed.Checked = false;
	}

	private void Admin_Load(object sender, EventArgs e)
	{
	  DisplayAllData();
	  DisplayBorrowedBook();
	  DisplayStudent();
	}

	//----------------------------------- BOOK LIST -----------------------------------
	private void btn_create_book_Click(object sender, EventArgs e)
	{
	  if (tb_book_name.Text == "" || tb_author_name.Text == "" || tb_genre_name.Text == "")
	  {
		MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	  }
	  else
	  {
		try
		{
		  string currentDate = DateTime.Now.ToString("yyyy/MM/dd"); // Get current date and time

		  string query = $"INSERT INTO book (book_name, author_name, genre_name, isBorrowed, publication_date) " +
						 $"VALUES('{tb_book_name.Text}', '{tb_author_name.Text}', '{tb_genre_name.Text}', '{cb_isBorrowed.Checked}', '{currentDate}')";

		  if (conn.State != ConnectionState.Closed)
		  {
			conn.Close();
		  }
		  SqlCommand cmd = new SqlCommand(query, conn);
		  conn.Open();
		  cmd.ExecuteNonQuery();
		  MessageBox.Show("Added successfully");
		  conn.Close();
		  ClearData();
		  DisplayAllData();

		}
		catch (Exception ex)
		{
		  MessageBox.Show(ex.Message);
		}
	  }
	}

	private void btn_update_book_Click(object sender, EventArgs e)
	{
	  if (tb_book_id.Text != "")
	  {
		try
		{
		  string query = $"UPDATE Book " +
						 $"SET book_name = '{tb_book_name.Text}', author_name = '{tb_author_name.Text}', genre_name = '{tb_genre_name.Text}', " +
						 $"isBorrowed = {(cb_isBorrowed.Checked ? 1 : 0)}, " + // isBorrowed = 1 if checked = true (checkbox is marked)
						 $"std_id = {(cb_isBorrowed.Checked ? "std_id" : "NULL")} " + // Set 1 if checked, 0 otherwise
						 $"WHERE book_id = '{tb_book_id.Text}'";
		  if (conn.State != ConnectionState.Closed)
		  {
			conn.Close();
		  }
		  if (string.IsNullOrWhiteSpace(tb_book_name.Text) || string.IsNullOrWhiteSpace(tb_author_name.Text) || string.IsNullOrWhiteSpace(tb_genre_name.Text))
		  {
			MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		  }
		  SqlCommand cmd = new SqlCommand(query, conn);
		  conn.Open();
		  cmd.ExecuteNonQuery();
		  MessageBox.Show($"Update successfully");
		  conn.Close();
		  ClearData();
		  DisplayAllData();

		}
		catch (Exception ex)
		{
		  MessageBox.Show(ex.Message);
		}
	  }
	  else
	  {
		MessageBox.Show("Please choose a row to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	  }
	}

	private void btn_delete_book_Click(object sender, EventArgs e)
	{
	  if (tb_book_id.Text != "")
	  {
		try
		{
		  if (conn.State != ConnectionState.Closed)
		  {
			conn.Close();
		  }

		  DialogResult dr = MessageBox.Show("Do you want to delete this item?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

		  if (dr == DialogResult.OK)
		  {
			string query = $"DELETE FROM book WHERE book_id = '{tb_book_id.Text}'";
			SqlCommand cmd = new SqlCommand(query, conn);
			conn.Open();
			cmd.ExecuteNonQuery();
			conn.Close();
			ClearData();
			DisplayAllData();
		  }
		  else if (dr == DialogResult.Cancel)
		  {
			return;
		  }
		}
		catch (Exception ex)
		{
		  MessageBox.Show(ex.Message);
		}
	  }
	  else
	  {
		MessageBox.Show("Please choose a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	  }
	}

	private void dgv_book_list_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	  // Check if a row is clicked (avoiding header clicks)
	  if (e.RowIndex >= 0)
	  {
		// Get the selected row data
		DataGridViewRow selectedRow = dgv_book_list.Rows[e.RowIndex];

		string bookId = selectedRow.Cells[0].Value.ToString();
		string bookName = selectedRow.Cells[1].Value.ToString();
		string authorName = selectedRow.Cells[2].Value.ToString();
		string genreName = selectedRow.Cells[3].Value.ToString();
		//Cell[4] Is publication_date
		bool isBorrowed = (bool)selectedRow.Cells[5].Value;

		tb_book_id.Text = bookId;
		tb_book_name.Text = bookName;
		tb_author_name.Text = authorName;
		tb_genre_name.Text = genreName;
		cb_isBorrowed.Checked = isBorrowed;

	  }
	}

	//----------------------------------- BORROWED BOOK LIST / STUDENT LIST -------------------------------
	private void btn_remove_std_Click(object sender, EventArgs e)
	{
	  if (tb_std_id.Text != "")
	  {
		try
		{
		  if (conn.State != ConnectionState.Closed)
		  {
			conn.Close();
		  }

		  DialogResult dr = MessageBox.Show($"Do you want to delete Student ID [{tb_std_id.Text}]?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

		  if (dr == DialogResult.OK)
		  {
			string query = $"DELETE FROM Student WHERE std_id = '{tb_std_id.Text}'";
			SqlCommand cmd = new SqlCommand(query, conn);
			conn.Open();
			cmd.ExecuteNonQuery();
			conn.Close();
			ClearData();
			DisplayStudent();
		  }
		  else if (dr == DialogResult.Cancel)
		  {
			return;
		  }
		}
		catch (Exception ex)
		{
		  MessageBox.Show(ex.Message);
		}
	  }
	  else
	  {
		MessageBox.Show("Please choose a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	  }
	}

	private void dgv_std_list_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	  if (e.RowIndex >= 0)
	  {
		// Get the selected row data
		DataGridViewRow row = dgv_std_list.Rows[e.RowIndex];
		string StdId = row.Cells[0].Value.ToString();
		tb_std_id.Text = StdId;
	  }
	}

	//-----------------------------------------------------------------------------------------------
	private void Admin_FormClosed(object sender, FormClosedEventArgs e)
	{
	  Login login = new Login();
	  login.Show();
	}

	private void btn_reset_Click(object sender, EventArgs e)
	{
	  ClearData();
	}

	private void btn_refresh_Click(object sender, EventArgs e)
	{
	  DisplayBorrowedBook();
	  DisplayStudent();
	}
  }
}
