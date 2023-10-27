using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;




namespace Case_Study
{

    public class App

    {

        static void Main(string[] args)

        {
            AppEngine appEngine = new AppEngine();
            UserInterface userInterface = new UserInterface(appEngine);
            userInterface.ShowFirstScreen();


        }
}