using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using Virtual_Office;

public class VirtualOffice
{
    private string loginUserName;
    private string loginPassword;
    private List<Desktop> desktopList = new List<Desktop>();
    private string status;
    //DB properties beign
    public string Server { get; set; }
    public string databaseName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    private MySqlConnection Connection { get; set; }
    private static VirtualOffice _instance = null;

    //DB properties end
    public VirtualOffice()
    {

    }
    public VirtualOffice(string Server,string DatabaseName, string userName, string password)
    {
        this.Server = Server;
        this.databaseName =DatabaseName;
        this.UserName = userName;
        this.Password=password;
        Run();
    }
    private List<Desktop> DisplayDesktops()
    {
        return new List<Desktop>();
    }


    private void Run()
    {
        if (IsConnect())
        {
            throw new Exception("DB connection failed");
        }
    }
    private void Close()
    {

        Connection.Close();
    }

    //DB methods
    public static VirtualOffice instance()
    {
        if (_instance == null)
        {
            _instance = new VirtualOffice();

        }
        return _instance;
    }

    public bool IsConnect()
    {
        if (Connection == null)
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                {
                    return false;
                }
                string connectionString = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, databaseName, UserName, Password);
                Connection = new MySqlConnection(connectionString);
                Connection.Open();
            }
        }
        return true;
    }

/**example implementation
*var dbCon = DBConnection.Instance();
*dbCon.Server = "YourServer";
*dbCon.DatabaseName = "YourDatabase";
*dbCon.UserName = "YourUsername";
*dbCon.Password = "YourPassword";
*if (dbCon.IsConnect())
*{
*    //suppose col0 and col1 are defined as VARCHAR in the DB
*   string query = "SELECT col0,col1 FROM YourTable";
*   var cmd = new MySqlCommand(query, dbCon.Connection);
*   var reader = cmd.ExecuteReader();
*    while(reader.Read())
*    {
*        string someStringFromColumnZero = reader.GetString(0);
*        string someStringFromColumnOne = reader.GetString(1);
*        Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
*    }
*    dbCon.Close();
*}
	 */
}
