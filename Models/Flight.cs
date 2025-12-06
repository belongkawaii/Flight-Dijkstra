namespace Flight_Dijkstra
{

    public class Flight
    {
        public int Id { get; set; }
        public int SourceCityId { get; set; }
        public int DestCityId { get; set; }
        public float Price { get; set; }
        public int Duration { get; set; } // minutes
        public string Airline { get; set; }
    }
}