using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab3Zadanie
{
    class Bank
    {
        //pola klasy
        public List<Customer> customers { get;  }
        public string name { get; }
        public string loginAdmin { get; set; }
        public string passwordAdmin { get; set; }
        public SqlConnection connection { get; set; }


        /// <summary>
        /// konstruktor klasy, odpowiada za zainicjalizowanie obiektu
        /// </summary>
        /// <param name="_name"></param>
        public Bank(string _name, SqlConnection _connection)
        {
            this.name = _name;
            this.customers = new List<Customer>();
            loginAdmin = "admin";
            passwordAdmin = "admin";
            connection = _connection;
            LoadData();
        }



        private void LoadData()
        {
            SqlDataReader dataReader;
            String sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection.Open();
            sql = "SELECT * FROM Bank.dbo.Customer";
           SqlCommand command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                this.AddCustomerFromDatabase(dataReader.GetValue(0).ToString(),dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString(), dataReader.GetValue(3).ToString(), long.Parse(dataReader.GetValue(4).ToString()), long.Parse(dataReader.GetValue(5).ToString()));

            }
            dataReader.Close();
        }


        public bool HasCustomer(long number)
        {
            String query = "SELECT COUNT(*) FROM Bank.dbo.Customer WHERE accountsNumber = @account;";
            SqlCommand command = new SqlCommand(query, this.connection);
            command.Parameters.Add("@account", number.ToString());
            int trueValue = (int)command.ExecuteScalar();
            bool isTrue = false;
            if(trueValue >= 1) isTrue = true;
            return isTrue;

        }


        /// <summary>
        /// metoda zwracająca informacje czy człowiek o podanych parametrach jest w bazie banku
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool isSuccessfulSignIn(string login, string password)
        {          
            String query = "SELECT  Count(*) FROM Bank.dbo.Customer  WHERE login = @login AND pin = @pin;";
            SqlCommand command = new SqlCommand(query, this.connection);
            command.Parameters.Add("@login", login);
            command.Parameters.Add("@pin", password);
            
         
            bool isTrue = false;
            int valueResault;
            valueResault = (int) command.ExecuteScalar();

            if (valueResault >= 1)
            {
                isTrue = true;
            }

            return isTrue;
        }

        /// <summary>
        /// metoda sprawdzająca czy dane administratora są poprawne
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool AmIAdministrator(string login, string password)
        {
            return this.loginAdmin.Equals(login) && this.passwordAdmin.Equals(password);     
        }

        /// <summary>
        /// metoda dodająca do bazy banku nowego klienta o podanych parametrach  
        /// </summary>
        /// <param name="name"></param>
        /// <param name="subname"></param>
        /// <param name="login"></param>
        /// <param name="pin"></param>
        public void AddNewCustomer(string name, string subname, string login, string pin)
        {
            //stworzenie obiektu klienta, wygenerowanie mu numeru konta i dodanie do list banku 
            Customer myNewCustomer = new Customer(name,  subname,  login,  pin);
            myNewCustomer.accountsNumber = GenerateAccountNumber();
            this.customers.Add(myNewCustomer);

            //Zapis do bazy danych 
            String query = "INSERT INTO dbo.Customer VALUES(@name, @surname, @login, @pin, @accountBalance, @accoutnNumber)";
            SqlCommand command = new SqlCommand(query, this.connection);
            command.Parameters.Add("@name", name);
            command.Parameters.Add("@surname", subname);
            command.Parameters.Add("@login", login);
            command.Parameters.Add("@pin", pin);
            command.Parameters.Add("@accountBalance", Int32.Parse("0"));
            command.Parameters.Add("@accoutnNumber", GenerateAccountNumber());
            command.ExecuteNonQuery();


        }

        /// <summary>
        /// dodawanie klientów z bazy 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="subname"></param>
        /// <param name="login"></param>
        /// <param name="pin"></param>
        /// <param name="accontBalance"></param>
        /// <param name="accountNumber"></param>
        public void AddCustomerFromDatabase(string name, string subname, string login, string pin, long accontBalance, long accountNumber)
        {
            Customer myNewCustomer = new Customer(name, subname, login, pin, accontBalance, accountNumber);
            customers.Add(myNewCustomer);
        }


        /// <summary>
        /// metoda zwracająca index pod którym figuruje klient w liście, lub -1 w razie jego braku na podstaie loginu i pinu
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pin"></param>
        /// <returns></returns>
        public int FindIndexCustometr(string login, string pin)
        {
            //przejście po liście 
            for (int i = 0; i < this.customers.Count; i++)
            {
                //sprawdzenie czy login klienta pod indexem i jest zgodny z parametrem przekazanym 
                if (customers[i].login == login)
                {
                    //sprawdzenie czy pin klienta pod indexem i jest zgodny z parametrem przekazanym 
                    if (customers[i].pin == pin)
                        return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// etoda zwracająca index pod którym figuruje klient w liście, lub -1 w razie jego braku na podstaie numeru konta 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int FindIndexCustometr(long number)
        {
            for(int i=0; i<customers.Count; i++)
            {
                //sprawdzenie czy numer konta klienta pod indexem i jest zgodny z parametrem przekazanym 
                if (customers[i].accountsNumber == number)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// metoda generująca numer konta 
        /// </summary>
        /// <returns></returns>
        private long GenerateAccountNumber()
        {
            //stworzenie obiektu do losowania liczb i wylosowanie liczby naturalnej 
            Random generator = new Random();
            int id = generator.Next();
            //stworzenie numeru o początku 94, końcówce wylosowanej i reszcie wypełnionej do dziesięciu zerami
            string accountNumber = string.Format("94{0:D10}", id);
            //sprawdzenie czy takiego numeru już nie ma w bazie, jeśli jest rekurencyjne wywołane tej samej metody
            if(!IsOnlyOneNumber(long.Parse(accountNumber)))
            {
                GenerateAccountNumber();
            }
            //zwrócenie numeru
            return long.Parse(accountNumber);
        }


        /// <summary>
        /// metoda sprwdająca czy podany numer jest jedyny na licie banku
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool IsOnlyOneNumber(long number)
        {
            //przejście po liście i porównanie numerów , w razie równoście przerwanie poszukiwań i zwrócenie fals
            for(int i=0; i<customers.Count; i++)
            {
                if(customers[i].accountsNumber == number)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
