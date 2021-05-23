namespace Weather
{
    public class City
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}