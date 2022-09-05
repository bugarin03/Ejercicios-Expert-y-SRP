using System;
using System.Text;

namespace Library
{
    public class AppointmentService

    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string ID { get; set; }
        public DateTime DateTime { get; set; }
        public string Pleace { get; set; }
        public object Patient { get; set; }
        public object Doctor { get; set; }

        public bool Appoinment { get; set; } // Es la variable en donde se guarda un valor booleano para saber si se crea la consulta o no 

        public AppointmentService(string Name, string Number, string ID, DateTime DateTime, string Pleace, object Patient, object Doctor)
        {
            this.Name = Name;
            this.Number = Number;
            this.ID = ID;
            this.DateTime = DateTime;
            this.Pleace = Pleace;
            this.Patient = Patient;
            this.Doctor = Doctor;


        }

        public void ValidationResult(string Name, string Number, string ID, DateTime DateTime, string Pleace, object Patient, object Doctor)
        {
            this.Appoinment = ValidationAppointmentService.ValidateAppointment(Name, Number, ID, DateTime, Pleace, Patient,Doctor);
    
        }
    }
    public class ValidationAppointmentService
    {
        public static bool ValidateAppointment(string Name, string ID, string Number, DateTime DateTime, string Place,object Patient, object doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(ID))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(Number))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(Place))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (doctorName is null)
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }
            Console.WriteLine(stringBuilder.ToString());
            return isValid;
        }

    }
}

/*
Se separo en dos la validacion de la consulta y la creacion de la misma ya que 
el programa tiene el proposito de validar los datos de la consulta 
*/