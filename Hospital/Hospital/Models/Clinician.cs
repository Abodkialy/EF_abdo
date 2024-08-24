namespace Domain.Models
{

    public enum Specialaization
    {
        Surgeon,
        Hart,
        Bones
    }
    public enum Shifts
    {

        day,
        night
    }
    public class Clinician : Person
    {
        public int Id { get; set; }


        public Specialaization specialaization { get; set; }

        // calc the total time of wrok
        public Shifts WorkingShift;

        // F Key
        public int AddressId { get; set; }

        public Address Address { get; set; }
        public List<Patient> Patients { get; set; }


    }

}
