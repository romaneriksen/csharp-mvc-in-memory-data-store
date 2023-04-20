namespace mvc_in_memory_data_store.Models
{
    public class Bagel
    {
        private int id;
        private String type;
        private int price;

        public Bagel(int id, String type, int price)
        {
            this.id = id;
            this.type = type;
            this.price = price;
        }

        public int getId()
        {
            return this.id;
        }

        public String getType()
        {
            return this.type;
        }

        public int getPrice()
        {
            return this.price;
        }
    }
}
