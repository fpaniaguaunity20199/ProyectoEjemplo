using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocima : MonoBehaviour
{
    public string nombre;
    public virtual void HacerMagia()
    {
        print("HACIENDO MAGIA");
        Cubo.peso = 10;
    }
}
