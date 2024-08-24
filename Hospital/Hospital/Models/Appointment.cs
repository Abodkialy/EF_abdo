namespace Domain.Models
{

    public enum Status
    {
        Canceled,
        Done,
        Awaiting
    }

    public class Appointment
    {
        /* موعد 
     */

        public Status State { get; set; }

        public DateTime DateTime { get; set; }

        // F Keys
        public int PatientId { get; set; }


        public int ClinicianId { get; set; }
        public int BillingId { get; set; }
        public Biling Biling { get; set; }
        



    }

}
