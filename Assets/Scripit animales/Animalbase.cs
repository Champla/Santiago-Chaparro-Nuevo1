using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animalbase: MonoBehaviour
{
    public string color;
    public int patas;


    public Animalbase(string newcolor, int newpatas)
    {
        color = newcolor;
        patas = newpatas;
    }

    public string Habilidadparasalir(string newhabilidad)
    {
        return newhabilidad;


    }
}
