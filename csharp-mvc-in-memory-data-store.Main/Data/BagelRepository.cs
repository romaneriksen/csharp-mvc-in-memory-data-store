namespace mvc_in_memory_data_store.Models
{
    public class BagelRepository
    {
        private int idCounter = 1;
        private List<Bagel> data = new List<Bagel>();

        public void create(String type, int price)
        {
            Bagel bagel = new Bagel(this.idCounter++, type, price);
            this.data.Add(bagel);
        }

        public List<Bagel> findAll()
        {
            return this.data;
        }

        public Bagel find(int id)
        {
            return this.data.First(bagel => bagel.getId() == id);
        }
    }
}
