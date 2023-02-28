namespace BeeHive.Models.Domain
{
    public class Hive
    {
        public int id { get; set; }
        public string? Number { get; set; }
        public int clientid { get; set; }

        public DateTime StartedDate { get; set; }

        public bool FlowHive { get; set; }

        public int Supers { get; set; }
    }
}
