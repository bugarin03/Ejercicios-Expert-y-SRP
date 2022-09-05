using System;
using System.Collections;

namespace SRP;

public class Location 
{
    public string Shelf { get; set; }
    public string Building { get; set; }
    public string Section { get; set; }

    public Location (string Section , string Shelf , string Building)
    {
        this.Shelf = Shelf;
        this.Building = Building;
        this.Section = Section;

    }
}

/*
Cree esta clase con el proposito de seguir los patrones y principios ya que de la forma que estaba antes habian varias razones para 
editar la clase Libro
*/