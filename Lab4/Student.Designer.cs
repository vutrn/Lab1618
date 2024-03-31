namespace Lab4
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
	  tb_search = new TextBox();
	  btn_search = new Button();
	  dataGridView1 = new DataGridView();
	  ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
	  SuspendLayout();
	  // 
	  // tb_search
	  // 
	  tb_search.Location = new Point(93, 13);
	  tb_search.Name = "tb_search";
	  tb_search.Size = new Size(100, 23);
	  tb_search.TabIndex = 1;
	  // 
	  // btn_search
	  // 
	  btn_search.Location = new Point(12, 12);
	  btn_search.Name = "btn_search";
	  btn_search.Size = new Size(75, 23);
	  btn_search.TabIndex = 2;
	  btn_search.Text = "Search";
	  btn_search.UseVisualStyleBackColor = true;
	  // 
	  // dataGridView1
	  // 
	  dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  dataGridView1.Location = new Point(296, 13);
	  dataGridView1.Name = "dataGridView1";
	  dataGridView1.Size = new Size(492, 255);
	  dataGridView1.TabIndex = 3;
	  // 
	  // Student
	  // 
	  AutoScaleDimensions = new SizeF(7F, 15F);
	  AutoScaleMode = AutoScaleMode.Font;
	  ClientSize = new Size(800, 450);
	  Controls.Add(dataGridView1);
	  Controls.Add(btn_search);
	  Controls.Add(tb_search);
	  Name = "Student";
	  Text = "Student";
	  Load += Student_Load;
	  ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
	  ResumeLayout(false);
	  PerformLayout();
	}

	#endregion
	private TextBox tb_search;
	private Button btn_search;
	private DataGridView dataGridView1;
  }
}