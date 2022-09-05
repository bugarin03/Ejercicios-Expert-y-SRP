using System;


namespace Library;

public class Patient
{
    public string Name { get; set; }
    public string Years { get; set; }


    public Patient (string Name , string Years )
    {
        this.Name = Name;
        this.Years = Years;
    }
}

/*
Se creo esta clase con el proposito de que se pueda agregar los datos que sean deseados 
*/