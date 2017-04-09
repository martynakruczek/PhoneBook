using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhoneBook
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Avatar { get; set; }

    }
    public static class ComC {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public static List<Person> people { get; set; }
        static ComC(){
            people = new List<Person>();
            Condition = "";
            //ConnectDB();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (!Directory.Exists(path + "\\Address Book"))
                Directory.CreateDirectory(path + "\\Address Book");
            if (!File.Exists(path + "\\Address Book\\settings.xml"))
                File.Create(path + "\\Address Book\\settings.xml");
        }

        public static bool IsFiltered { get; set; }
        
        public static int ContactIndex { get; set; }

        public static string Condition { get; set; }

        public static void ConnectDB() {

            SqlConnection con;
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;
                          AttachDbFilename=I:\Programowanie IV\Programme\PhoneBook\PhoneBookDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            con.Open();
            MessageBox.Show("Connection opened");
            con.Close();
            MessageBox.Show("Connection closed");

        }

        public static void SaveToDB() {

            using (SqlConnection con = new SqlConnection("Data Source=LAPEK;Initial Catalog=KDSdb;Integrated Security=True")) {
                con.Open();
                String query = "INSERT INTO dbo.Contact (FirstName, LastName, PhoneNumber, Email, BirthDate, Street, PostalCode, City, Avatar) VALUES(@FirstName, @LastName, @PhoneNumber, @Email, @BirthDate, @Street, @PostalCode, @City, @Avatar)";

                foreach (var item in ComC.people) {
                    using (SqlCommand command = new SqlCommand(query, con)) {

                        command.Parameters.Add("@FirstName",item.FirstName);
                        //TO DO.........










                        command.ExecuteNonQuery();

                    }
                }
            }
        }

        public static void GetContactList() {
            using (SqlConnection con = new SqlConnection("Data Source=LAPEK;Initial Catalog=KDSdb;Integrated Security=True")) {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Contact", con)) {
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader != null) {
                            while (reader.Read()) {
                                Person  p = new Person();
                                p.FirstName = reader["FirstName"].ToString();
                                p.LastName = reader["LastName"].ToString();
                                p.PhoneNumber = reader["PhoneNumber"].ToString();
                                p.Email = reader["Email"].ToString();
                                p.BirthDate = Convert.ToDateTime(reader["BirthDate"]);
                                p.City = reader["City"].ToString();
                                p.PostalCode = reader["PostalCode"].ToString();
                                p.Street = reader["Street"].ToString();
                                p.Avatar = reader["Avatar"].ToString();
                                people.Add(p);
                            }
                        }
                    }
                }
            }
        }
    }
}


