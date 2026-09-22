using UnityEngine;

public class ForeachTeste : MonoBehaviour
{
    public string[] inventario;

    void Start()
    {
        foreach (string item in inventario)
        {
            print(item);
        }    
    }

   
}
