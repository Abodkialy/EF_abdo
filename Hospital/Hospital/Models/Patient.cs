namespace Domain.Models
{

    public class Patient : Person
    {
        public int Id { get; set; }


        // F Key
        public int AddressId { get; set; }

        public Address Address { get; set; }
        public List<Clinician> Clinicians { get; set; }
        



    }

}
