namespace Domain.Models
{

    public enum StatusOfPaying
    {

        payed,
        NotPaid,
    }
    public enum Method
    {

        Card,
        cash
    }
    public class Biling
    {
        public int Id { get; set; }
        public double Amount { get; set; }

        public DateTime DateTime { get; set; }

        public StatusOfPaying status { get; set; }

        public Method Method { get; set; }
        




    }


}
