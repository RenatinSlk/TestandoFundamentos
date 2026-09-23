using UnityEngine;
using System.Collections.Generic;

public class ListTest : MonoBehaviour
{
   public List<string> nomes;

   public void Start()
   {
        nomes.Add("Renato");
        nomes.Add("Sophia");
        nomes.Add("Joaquim");
        nomes.Remove("Beatriz");
   }
}
