namespace FirstDemo.Web.Models
{
    public class IndexModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public IndexModel()
        {
            FullName = "Anirban Anu";
            Email = "anirban@gmail.com";
            City = "Dhaka";
            Country = "Bangladesh";
        }
    }
}
