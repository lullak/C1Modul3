namespace frmBookCourt.Classes
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PostalCode { get; set; }
        public string StreetAddress { get; set; }

        public Customer(string firstName, string surname, string phone, string email, string postalCode, string streetAddress)
        {
            FirstName = firstName;
            Surname = surname;
            Phone = phone;
            Email = email;
            PostalCode = postalCode;
            StreetAddress = streetAddress;
        }
    }


}
