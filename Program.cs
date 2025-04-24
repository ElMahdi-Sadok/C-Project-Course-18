using ContactBusinessLayer;
using System;
using System.Data;


namespace ContactsConsolApp_PresentationLayer
{
    internal class Program

    {

        public static void TestFindContact(int ID)
        {

            clsContact Contact = clsContact.Find(ID);

            if(Contact != null) {

                Console.WriteLine(Contact.FirstName);
                Console.WriteLine(Contact.LastName);
                Console.WriteLine(Contact.Email);
                Console.WriteLine(Contact.Phone);
                Console.WriteLine(Contact.Address);
                Console.WriteLine(Contact.DateOfBirth);
                Console.WriteLine(Contact.CountryID);
                Console.WriteLine(Contact.ImagePath);

            }
            else
            {
                Console.WriteLine("Contact With [" + ID + "] Not Found !");
            }

        }

        public static void TestAddContact()
        {
            clsContact Contact = new clsContact();

            Contact.FirstName = "Moad";
            Contact.LastName = "Attak";
            Contact.Email = "Moad.aar04@gmail.Com";
            Contact.Phone = "020932092";
            Contact.Address = "brreshid.soualem.Omran";
            Contact.DateOfBirth = new DateTime(1982, 01, 3, 10, 2, 0);
            Contact.CountryID = 1;
            Contact.ImagePath = "";

            if (Contact.Save())
            {
                Console.WriteLine("Contact " + Contact.ID + " Added Seccussfely ");
            }
            else
            {
                Console.WriteLine("Contact Is Not Added ");
            }
        }
        public static void TestUpdateContact(int ID) {
        
            clsContact Contact = clsContact.Find(ID);

            if(Contact != null)
            {
                Contact.FirstName = "Mahdi";
                Contact.LastName = "SSSSS";
                Contact.Phone = "222222";
                Contact.Email = "www";
                Contact.Address = "ww Omrane";
                Contact.DateOfBirth =DateTime.Now;
                Contact.CountryID = 1;
                Contact.ImagePath = "";
            }

            if(Contact.Save()) {
                Console.WriteLine("Contact Updated");


                    }
            else
            {
                Console.WriteLine("contact Does't Updated");
            }
        }
        public static void TestDeleteContact(int ID)
        {

            if (clsContact.DeleteContact(ID))
            {
                Console.WriteLine("Contact Deleted Seccessfuly ");
            }
            else
            {
                Console.WriteLine("Contact Does not Deleted ");
            }

        }
        public static void TestContactList()
        {
            DataTable dataTable = clsContact.GetAllContacts();

            foreach(DataRow row in dataTable.Rows) {

                Console.WriteLine($"{row["ContactID"] } , {row["FirstName"]} , {row["LastName"]}" );

            }

        }

        public static void TestIfContactExsist(int ID)
        {
            if (clsContact.IsContactExsist(ID))
            {

                Console.WriteLine("Yes , Contact is There ");
            }
            else
            {
                Console.WriteLine("No , Contact Is Not There ");
            }

        }
        static void Main(string[] args)
        {
            TestIfContactExsist(100);
            //TestContactList();
            //TestDeleteContact(2);
            //TestUpdateContact(2);
            //TestFindContact(1);
            //TestAddContact();

            Console.ReadLine();
        }
    }
}
