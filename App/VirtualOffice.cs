using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using Virtual_Office;

public class VirtualOffice
{
    //private string loginUserName;
    //private string loginPassword;
    private Login manageLogin;
    private List<Desktop> desktopList = new List<Desktop>();

    public bool loginStatus { get; set; }//true = logged in
    //DB properties beign
    public string Server { get; set; }
    public string databaseName { get; set; }
    public string DBUserName { get; set; }
    public string DBPassword { get; set; }
    private MySqlConnection Connection { get; set; }
    private static VirtualOffice _instance = null;

    //DB properties end
    public VirtualOffice()
    {
        

    }
    /// <summary>
    /// This Constructor Handles DB Connection
    /// </summary>
    /// <param name="Server">serverIP default localhost</param>
    /// <param name="DatabaseName">database name</param>
    /// <param name="DBuserName">database username of the db</param>
    /// <param name="DBpassword">database password of the db</param>
    public VirtualOffice(string Server,string DatabaseName, string DBuserName, string DBpassword)
    {
        _instance = instance();
        this.Server = Server;
        this.databaseName =DatabaseName;
        this.DBUserName = DBuserName;
        this.DBPassword= DBpassword;
        Run();
    }
    public void Login(string loginUserName,string loginPassWord)
    {
        try
        {

        
        if(String.IsNullOrEmpty(loginUserName.Trim()))
        {
            if (String.IsNullOrEmpty(loginPassWord.Trim()))
            {
                manageLogin = new Login(Connection,loginUserName, loginPassWord);
                loginStatus = manageLogin.LoginStatus;
                return;
            }
                throw new ArgumentNullException("Password Can't Be Null. Exception");
        }
        throw new ArgumentNullException("Username Can't Be Null. Exception");
        }
        catch(Exception exception)
        {
            //TODO GUI implementation of this exception
            Console.Error.WriteLine("Error Occured Details: "+ exception);
            //this Exception Shouldn't Crash the program
        }
    }
    //returns a list of avaliable desktops to certain user
    private List<Desktop> DisplayDesktops()
    {
        return new List<Desktop>();
    }


    private void Run()
    {
        if (!IsConnect())
        {
            throw new Exception("DB connection failed");
        }
    }
    public void Close()
    {

        if (Connection!=null&&manageLogin!=null)
        {
            Connection.Close();//close all connections
            manageLogin.logout();

        }
        else//for test unit
        {
            Connection.Close();//close all connections
        }
        
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
                
            if (String.IsNullOrEmpty(databaseName))
                {
                    return false;
                }
            string connectionString = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, databaseName, DBUserName, DBPassword);
            Connection = new MySqlConnection(connectionString);
           //testing connection here 
            try
            {
                Connection.Open();//test connection
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Database Connection Failed Error: " + e);
            };
            
            Connection.Close();
            //end test
            
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
