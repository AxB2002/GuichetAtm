using ATM_App;
using MySql.Data.MySqlClient;

namespace ATM1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main()
		{
			string connectionString = "Server=localhost;User ID=root;Password=root;";
            UserContext.ConnectionStringWithoutDB = connectionString;
			UserContext.ConnectionStringWithDB = "Server=localhost;Database=atmdb;User ID=root;Password=root;";
			string dbName = "ATMDB";

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				connection.Open();
				/*using (MySqlCommand dropCmd = new MySqlCommand($"DROP DATABASE {dbName}", connection))
				{
					dropCmd.ExecuteNonQuery();
				}*/
				// Check if the database exists
				using (MySqlCommand cmd = new MySqlCommand($"SHOW DATABASES LIKE '{dbName}'", connection))
				{
					var result = cmd.ExecuteScalar();
                    Console.WriteLine(result);
                    if (result == null)
                    {
                        Console.WriteLine("MAking DB");
                        // Create the database and tables if they do not exist
                        CreateDatabaseAndTables(connection, dbName);
                    }

				}
			}

			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}

		private static void CreateDatabaseAndTables(MySqlConnection connection, string dbName)
		{
			string createDbQuery = $"CREATE DATABASE {dbName}; USE {dbName};";
			string createTablesQuery = @"
                /* == Table Client == */
                CREATE TABLE Clients (
                    ClientID INT PRIMARY KEY AUTO_INCREMENT,
                    LastName VARCHAR(50) NOT NULL,
                    FirstName VARCHAR(50) NOT NULL,
                    Phone VARCHAR(20) NOT NULL,
                    Email VARCHAR(100) NOT NULL,
                    PIN CHAR(4) NOT NULL,
                    Acess VARCHAR(100) NOT NULL
                );

                /* == Table TypeCompte == */
                CREATE TABLE AccountType (
                    TypeID INT PRIMARY KEY,
                    Label VARCHAR(50) NOT NULL
                );

                /* Insertion des types de compte */
                INSERT INTO AccountType (TypeID, Label)
                VALUES
                (1, 'Checking'),
                (2, 'Savings'),
                (3, 'Mortgage'),
                (4, 'Credit Line');

                /* == Accounts Table == */
                CREATE TABLE Accounts (
                    AccountNumber INT PRIMARY KEY AUTO_INCREMENT,
                    ClientID INT NOT NULL,
                    AccountType INT NOT NULL,
                    Balance DECIMAL(10,2) NOT NULL,
                    CONSTRAINT FK_Accounts_Clients FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
                    CONSTRAINT FK_Accounts_AccountType FOREIGN KEY (AccountType) REFERENCES AccountType(TypeID)
                );

                /* == Transactions Table == */
                CREATE TABLE Transactions (
                    TransactionNumber INT PRIMARY KEY AUTO_INCREMENT,
                    TransactionDate DATETIME NOT NULL,
                    ClientID INT NOT NULL,
                    DebitAccountNumber INT NULL,
                    CreditAccountNumber INT NULL,
                    Amount DECIMAL(10,2) NOT NULL,
                    TransactionType INT NOT NULL,
                    Description VARCHAR(255) NULL,
                    CONSTRAINT FK_Transactions_Clients FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
                    CONSTRAINT FK_Transactions_DebitAccount FOREIGN KEY (DebitAccountNumber) REFERENCES Accounts(AccountNumber),
                    CONSTRAINT FK_Transactions_CreditAccount FOREIGN KEY (CreditAccountNumber) REFERENCES Accounts(AccountNumber)
                );

                /* == ATM Table == */
                CREATE TABLE ATM (
                    ID INT PRIMARY KEY CHECK (ID = 1), -- Enforce ID to be 1 to guarantee a single row
                    CashAmount DECIMAL(10,2) NOT NULL CHECK (CashAmount >= 0 AND CashAmount <= 20000)
                );";

			using (MySqlCommand cmd = new MySqlCommand(createDbQuery, connection))
			{
				cmd.ExecuteNonQuery();
			}

			using (MySqlCommand cmd = new MySqlCommand(createTablesQuery, connection))
			{
				cmd.ExecuteNonQuery();
			}
		}

		
	}
	public enum TransactionType
	{
		Withdrawal = 1,
		Deposit = 2,
		Transfer = 3,
        Bill_Pay = 4
		// Add more transaction types as needed
	}
}