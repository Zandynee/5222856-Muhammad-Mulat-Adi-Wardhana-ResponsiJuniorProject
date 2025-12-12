using System;
using System.Data;
using System.Security.Cryptography;
using Npgsql;
internal class Devtrack : Developer
{
	private const string conn = "Host=localhost;Usernam=postgres;Password=12945624159761423571465;Database=devtrack";
	private static NpgsqlConnection connection;
	private static NpgsqlCommand command;
	private static DataTable dt;

	private DataGridView dgvData;
	public DataGridViewRow { set { row  = value ; } }
	public Devtrack(DataGridView dgvData)
	{
	dgvData = _dgvData;

		}

	public void Load()
	{ 
	 connection = new NpgsqlConnection(conn);
		try
		{
			connection.Open();
			dt = dgvData.DataSource = null;
			dt = new DataTable();
			string sql = "SELEVT * FROM dev_select()";
			command = new NpgsqlCommand(sql, connection);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			connection.Close();

		}
		finally { connection.Close(); }	
	}
	public void Insert ()


}
