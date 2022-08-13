namespace construtorFundamental
{
    public class Customer
    {
        public int Id;
        public string Name;


        public Customer() //empty constructor
        {
        }

        public Customer(int id, string name) //constructor with parameter
        {
            this.Id = id;
            this.Name = name;
        }
        public void Displaydata()
        {

            Console.WriteLine("without parameter "+Id + Name);
        }
        public void Displaydata(bool value)
        {

            Console.WriteLine("with parameter " +Id + " " + Name +" " + value);
        }




    }
}