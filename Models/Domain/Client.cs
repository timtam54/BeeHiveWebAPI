namespace BeeHive.Models.Domain
{
    public class Client
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? Address { get; set; }

        public DateTime StartedDate { get; set; }

        public string? PhoneNumber { get; set; }

        public string? EmailAddress { get; set; }
    }

   
}
