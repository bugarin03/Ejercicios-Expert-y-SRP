using System;


namespace Library;

public class Doctor 
{
    public string Name { get; set; }
    public string Specialty { get; set; }


    public Doctor (string Name , string Specialty )
    {
        this.Name = Name;
        this.Specialty = Specialty;
    }
}

/*
Se creo esta clase con el proposito de que se pueda agregar los datos que sean deseados 
*/