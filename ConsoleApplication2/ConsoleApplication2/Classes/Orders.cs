namespace Restaurant__namespace
{
    public class Orders
    {
        private int price { get; set; }
        private string Customer { get; set; }

        Orders(int price,string Customer)
        {
            this.price = price;
            this.Customer = Customer;
        }


    }
}