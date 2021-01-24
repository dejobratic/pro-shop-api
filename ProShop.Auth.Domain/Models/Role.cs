namespace ProShop.Auth.Domain.Models
{
    public class Role
    {
        public static Role Admin = new Role("Admin");
        public static Role Customer = new Role("Customer");

        public string Name { get; }

        public Role(string name)
        {
            Name = name;
        }
    }
}
