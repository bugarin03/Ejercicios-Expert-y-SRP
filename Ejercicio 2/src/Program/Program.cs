using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient paciente = new Patient("Bruno", "18");
            Doctor doctor= new Doctor ("Jonh", "General");

            AppointmentService appointmentResult =  new AppointmentService ("Bruno", "986782342", "5555-555-555", DateTime.Now, "Wall Street", paciente, doctor);
            appointmentResult.ValidationResult("Bruno", "986782342", "5555-555-555", DateTime.Now, "Wall Street", paciente, doctor);



            // string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            // Console.WriteLine(appointmentResult2);
        }
    }
}
