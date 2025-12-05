namespace Flight_Dijkstra
{

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string AirportCode { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public string GetInfo()
        {
            return $"{Name} ({AirportCode}), {Country}";
        }
    }
}
