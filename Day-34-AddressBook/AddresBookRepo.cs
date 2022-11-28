using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day_34_AddressBook
{
    public class AddresBookRepo
    {


        public static string connectionstring = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook_Day34;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionstring);

        public bool AddDetails(AddressBookModel book)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SqlAddressBookDetails", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", book.FirstName);
                    command.Parameters.AddWithValue("@LastName", book.LastName);
                    command.Parameters.AddWithValue("@Address", book.Address);
                    command.Parameters.AddWithValue("@City ", book.City);
                    command.Parameters.AddWithValue("@State", book.State);
                    command.Parameters.AddWithValue("@Zip", book.Zip);
                    command.Parameters.AddWithValue("@PhoneNumber", book.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", book.Email);

                    this.connection.Open();

                    var result = command.ExecuteNonQuery();

                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
        //public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AddressBook_Day34;Integrated Security=True";
        //SqlConnection connection = new SqlConnection(connectionString);

        //public void GetDetails()
        //{
        //    try
        //    {
        //        AddressBookModel addressBookModel = new AddressBookModel();
        //        using (this.connection)
        //        {
        //            string query = @"select * from AddressBook_day34_table";
        //            SqlCommand command = new SqlCommand("SqlAddressBookDetails", this.connection);

        //            //Define Sql Command Object
        //            SqlCommand cmd = new SqlCommand(query, this.connection);

        //            this.connection.Open();

        //            SqlDataReader dr = cmd.ExecuteReader();

        //            //check if there are records

        //            if (dr.HasRows)
        //            {
        //                while (dr.Read())
        //                {
        //                    addressBookModel.FirstName = dr.GetString(0);
        //                    addressBookModel.LastName = dr.GetString(1);
        //                    addressBookModel.Address = dr.GetString(2);
        //                    addressBookModel.City = dr.GetString(3);
        //                    addressBookModel.State = dr.GetString(4);
        //                    addressBookModel.Zip = dr.GetInt32(5);
        //                    addressBookModel.PhoneNumber = dr.GetString(6);
        //                    addressBookModel.Email = dr.GetString(7);



        //                    //display retieved record

        //                    Console.WriteLine("FirstName : " + "{0}" + ", Last Name : " + "{1}" + ", Address : " + "{2}" + ", City : " + "{3}" + ", State" + "{4}" + ", Zip : " + "{5}" + ", PhoneNumber : " + "{6}" + ", Email : " + "{7}" + ", Relation Type : " + "{8}", addressBookModel.FirstName, addressBookModel.LastName, addressBookModel.Address, addressBookModel.City, addressBookModel.State, addressBookModel.Zip, addressBookModel.PhoneNumber, addressBookModel.Email);

        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("No Data Found");
        //            }
        //            //Close Data Reader
        //            dr.Close();
        //            this.connection.Close();

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //    finally
        //    {
        //        this.connection.Close();
        //    }
        //}
    }
}
