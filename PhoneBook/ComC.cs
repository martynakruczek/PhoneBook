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
            ConnectDB();

            //GetContactList();
            
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
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\Programowanie IV\Programme\PhoneBook\PhoneBook\PhoneDB.mdf;Integrated Security=True";
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", con)) {
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader != null) {
                        while (reader.Read()) {
                            Person p = new Person();
                            p.Id = Convert.ToInt32(reader["Id"]);
                            p.FirstName = reader["FirstName"].ToString();
                            if(reader["LastName"] != null) {
                                p.LastName = reader["LastName"].ToString();
                            }
                            if (reader["PhoneNumber"] != null) {
                                p.PhoneNumber = reader["PhoneNumber"].ToString();
                            }
                            if (reader["Email"] != null)
                                p.Email = reader["Email"].ToString();
                            if (reader["BirthDate"] != "0001-01-01 00:00:00")
                                p.BirthDate = Convert.ToDateTime(reader["BirthDate"].ToString());
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

        public static string FuckingBD(DateTime fuck) {
            if(fuck.ToString() == "0001-01-01 00:00:00") {
                return "'0001-01-01 00:00:00'";
            }
            else {
                return "'"+fuck.ToString()+"'";
            }
        }
        public static void SaveToDB() {

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\Programowanie IV\Programme\PhoneBook\PhoneBook\PhoneDB.mdf;Integrated Security=True")) {
                con.Open();
                string deleteQuery = "DELETE FROM [Table]";
                using (SqlCommand command = new SqlCommand(deleteQuery, con)) {
                    command.ExecuteNonQuery();
                }
                foreach (var item in ComC.people) {

                    string query = "INSERT INTO [Table] (Id, FirstName, LastName, PhoneNumber, Email, BirthDate, Street, PostalCode, City, Avatar) VALUES("+item.Id+","+AddNull(item.FirstName)+","+ AddNull(item.LastName)+","+ AddNull(item.PhoneNumber)+","+ AddNull(item.Email)+","+FuckingBD(item.BirthDate)+","+ AddNull(item.Street)+","+ AddNull(item.PostalCode)+","+ AddNull(item.City)+","+ AddNull(item.Avatar)+")";
                    using (SqlCommand command = new SqlCommand(query, con)) {

                        //command.Parameters.Add("@Id", item.Id);
                        //command.Parameters.Add("@FirstName", item.FirstName);
                        //command.Parameters.Add("@LastName", item.LastName);
                        //command.Parameters.Add("@PhoneNumber", item.PhoneNumber);
                        //command.Parameters.Add("@Email", item.Email);
                        //command.Parameters.Add("@BirthDate", item.BirthDate);
                        //command.Parameters.Add("@Street", item.Street);
                        //command.Parameters.Add("@PostalCode", item.PostalCode);
                        //command.Parameters.Add("@City", item.City);
                        //command.Parameters.Add("@Avatar", item.Avatar);
                        command.ExecuteNonQuery();

                    }
                }
            }
        }

        public static void GetContactList() {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\Programowanie IV\Programme\PhoneBook\PhoneBook\PhoneDB.mdf;Integrated Security=True")) {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Table", con)) {
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader != null) {
                            while (reader.Read()) {
                                Person  p = new Person();
                                p.Id = Convert.ToInt32(reader["Id"]);
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


