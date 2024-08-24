using HospitalMangmentApp;

namespace MainApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Concet to Data base by Dbcontex
            using (MangmentAppDbContex con = new MangmentAppDbContex())
            {
                // create the data base 

                con.Database.EnsureCreated();

            }
        }
    }
}
