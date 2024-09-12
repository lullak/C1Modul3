namespace DemoOOPGym.Classes
{
    public class Member
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Membership Membership { get; set; }

        public Member(string name, string phone, string address, Membership membership)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Membership = membership;
        }
    }
}
