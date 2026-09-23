using UnityEngine;
using System.Collections.Generic;


public enum Ataque
{
    Soco,
    Chute,
    Voadora,
    Banda,
    Cabeçada
}

public class Combo : MonoBehaviour
{
   public List<Ataque> SequenciaGolpes = new List<Ataque>();

   void Start()
   {
        foreach (Ataque golpe in SequenciaGolpes)
        {
            Debug.Log("Golpe do combo: " + golpe);
        }
   }
}
