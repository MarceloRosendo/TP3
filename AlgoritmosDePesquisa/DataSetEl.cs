using System;

namespace AlgoritmosDePesquisa
{
    public class DataSetEl
    {
        public long room_id { get; set; }
        public long host_id { get; set; }
        public String room_type { get; set; }
        public String country { get; set; }
        public String city { get; set; }
        public String neighborhood { get; set; }
        public String reviews { get; set; }
        public String overall_satisfaction { get; set; }
        public String accommodates { get; set; }
        public String bedrooms { get; set; }
        public String price { get; set; }
        public String property_type { get; set; }
        
        public static void printroom(DataSetEl quarto)
        {
            if (quarto == null)
            {
                Console.WriteLine("Quarto não localizado.");
            }
            else
            {
                Console.WriteLine("Room ID: " + quarto.room_id);
                Console.WriteLine("Host ID: " + quarto.host_id);
                Console.WriteLine("Room Type: " + quarto.room_type);
                Console.WriteLine("Country: " + quarto.country);
                Console.WriteLine("City: " + quarto.city);
                Console.WriteLine("Neighborhood: " + quarto.neighborhood);
                Console.WriteLine("Reviews: " + quarto.reviews);
                Console.WriteLine("Overall Satisfaction: " + quarto.overall_satisfaction);
                Console.WriteLine("Accommodates: " + quarto.accommodates);
                Console.WriteLine("Bedrooms: " + quarto.bedrooms);
                Console.WriteLine("Price: " + quarto.price);
                Console.WriteLine("Property Type: " + quarto.property_type);
            }
        }
    }
}