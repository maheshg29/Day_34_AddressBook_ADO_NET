
namespace Day_34_AddressBook
{
     class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day 34 Address Book Problem");
            AddresBookRepo addresBookRepo = new AddresBookRepo();

            AddressBookModel model = new AddressBookModel();
            model.FirstName = "akshay";
            model.LastName = "b";
            model.Address = "12 nagar";
            model.City = "nashik";
            model.State = "maharashtra";
            model.Zip = 424007;
            model.PhoneNumber = "9812345678";
            model.Email = "gagagag@gmail.com";
               
            addresBookRepo.AddDetails(model);
            //addresBookRepo.GetDetails();
        }
    }
}

