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
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
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
            ConnectDB();
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
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Programowanie IV\Programme\PhoneBook\PhoneBook\PhoneDB.mdf;Integrated Security=True";
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", con)) {
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader != null) {
                        while (reader.Read()) {
                            Person p = new Person();
                            p.Id = Convert.ToInt32(reader["Id"]);
                            p.FirstName = reader["FirstName"].ToString();
                            if (reader["LastName"] != null)
                                p.LastName = reader["LastName"].ToString();
                            if (reader["PhoneNumber"] != null)
                                p.PhoneNumber = reader["PhoneNumber"].ToString();
                            if (reader["Email"] != null)
                                p.Email = reader["Email"].ToString();
                            if (reader["BirthDate"] != null)
                                p.BirthDate = reader["BirthDate"].ToString();
                            if (reader["City"] != null)
                                p.City = reader["City"].ToString();
                            if (reader["PostalCode"] != null)
                                p.PostalCode = reader["PostalCode"].ToString();
                            if (reader["Street"] != null)
                                p.Street = reader["Street"].ToString();
                            if (reader["Avatar"] != null)
                                p.Avatar = reader["Avatar"].ToString();
                            people.Add(p);
                        }
                    }
                }
            }
            con.Close();
        }
        public static string AddNull(string s) {
            if(s == null) {
                return "NULL";
            }
            else {
                return "'"+s+"'";
            }
        }

        public static string AddDT(DateTime dt) {
            if(dt.ToString() == "0001-01-01 00:00:00") {
                return "'0001-01-01 00:00:00'";
            }
            else {
                return "'"+dt.ToString()+"'";
            }
        }
        public static void SaveToDB() {

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Programowanie IV\Programme\PhoneBook\PhoneBook\PhoneDB.mdf;Integrated Security=True")) {
                con.Open();
                string deleteQuery = "DELETE FROM [Table]";
                using (SqlCommand command = new SqlCommand(deleteQuery, con)) {
                    command.ExecuteNonQuery();
                }
                foreach (var item in ComC.people) {

<<<<<<< HEAD
                    string query = "INSERT INTO [Table] (Id, FirstName, LastName, PhoneNumber, Email, BirthDate, Street, PostalCode, City, Avatar) VALUES("+item.Id+","+AddNull(item.FirstName)+","+ AddNull(item.LastName)+","+ AddNull(item.PhoneNumber)+","+ AddNull(item.Email)+","+AddNull(item.BirthDate)+","+ AddNull(item.Street)+","+ AddNull(item.PostalCode)+","+ AddNull(item.City)+","+ AddNull(item.Avatar)+")";
                    using (SqlCommand command = new SqlCommand(query, con)) {
=======
                    string query = "INSERT INTO [Table] (Id, FirstName, LastName, PhoneNumber, Email, BirthDate, Street, PostalCode, City, Avatar) VALUES("+item.Id+","+AddNull(item.FirstName)+","+ AddNull(item.LastName)+","+ AddNull(item.PhoneNumber)+","+ AddNull(item.Email)+","+AddDT(item.BirthDate)+","+ AddNull(item.Street)+","+ AddNull(item.PostalCode)+","+ AddNull(item.City)+","+ AddNull(item.Avatar)+")";
                    using (SqlCommand command = new SqlCommand(query, con)) {

>>>>>>> a8ee02e6a2ab1392381b5806c6838ec023fadcb9
                        command.ExecuteNonQuery();

                    }
                }
            }
        }
    }
}


