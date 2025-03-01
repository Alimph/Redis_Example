namespace _Shared
{
    public class Customer
    {
        public Customer()
        {
                
        }
        public Customer(string name, string age)
        {
            Name = name;
            Age = age;
            CreationDate = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
