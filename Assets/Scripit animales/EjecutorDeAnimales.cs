using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejecutordeanimales : MonoBehaviour
{

    void start()
    {
        Animalbase cerdo = new Animalbase("Rosado", 4);
        Animalbase Gallina = new Animalbase("Blanco", 2);
        Animalbase Perro = new Animalbase("Cafe", 4);
        Animalbase Cuervo = new Animalbase("Negro", 2);
        Animalbase Vaca = new Animalbase("Blanco y negro", 4);

        string habilidadCerdo = cerdo.Habilidadparasalir("Soldado");
        string habilidadGallina = Gallina.Habilidadparasalir("cura");
        string habilidadPerro = Perro.Habilidadparasalir("daulista");
        string habilidadCuervo = Cuervo.Habilidadparasalir("sniper");
        string habilidadVaca = Vaca.Habilidadparasalir("Tanque");


        Debug.Log("la habilidad del cerdo es" + habilidadCerdo + "y su color es" + cerdo);
        Debug.Log("la habilidad del gallina es" + habilidadGallina + "y su color es" + Gallina);
        Debug.Log("la habilidad del perro es" + habilidadPerro + "y su color es" + Perro);
        Debug.Log("la habilidad del cuervo es" + habilidadCuervo + "y su color es" + Cuervo);
        Debug.Log("la habilidad del vaca" + habilidadVaca + "y su color es" + Vaca);

    }
}

