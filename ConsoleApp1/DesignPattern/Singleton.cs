using javax.management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }



    ////Examle 2
    ///
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;

        // Private constructor to prevent external instantiation
        private DatabaseConnection() { }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                    Console.WriteLine($"Instance Initialized");
                    // Perform database connection initialization here
                }
                return instance;
            }
        }

        public void ExecuteQuery(string query)
        {
            // Execute the query on the database
            Console.WriteLine($"Executing query: {query}");
        }
    }

    public class ApplicationTest
    {
        public void Run()
        {
            // Get the singleton instance of DatabaseConnection
            DatabaseConnection dbConnection = DatabaseConnection.Instance;

            // Use the singleton instance to execute a query
            dbConnection.ExecuteQuery("SELECT * FROM Customers");
        }
    }


    public class ApplicationTest2
    {
        public void Run()
        {
            // Get the singleton instance of DatabaseConnection
            DatabaseConnection dbConnection = DatabaseConnection.Instance;

            // Use the singleton instance to execute a query
            dbConnection.ExecuteQuery("SELECT * FROM Order");
        }
    }


    public class ApplicationTest3
    {
        public void Run()
        {
            // Get the singleton instance of DatabaseConnection
            DatabaseConnection dbConnection = DatabaseConnection.Instance;

            // Use the singleton instance to execute a query
            dbConnection.ExecuteQuery("SELECT * FROM Delivery");
        }
    }

}
