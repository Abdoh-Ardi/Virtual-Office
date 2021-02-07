using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;

public class VirtualOffice
{
	private string LoginUserName;
	private string LoginPassword;
	private List<Desktop> DesktopList = new List<Desktop>();
	private string Status;
	//DB properties beign
	public string Server { get; set; }
	public string DatabaseName { get; set; }
	public string UserName { get; set; }
	public string Password { get; set; }
	//DB properties end

	public VirtualOffice(string userName, string userPassword)
	{

		Run();
	}
	public List<Desktop> DisplayDesktops()
    {
		return new List<Desktop>();
    }


	private void Run()
    {

    } 
}
