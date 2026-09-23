using UnityEngine;

public class Inventario : MonoBehaviour
{
    public string[] armas = {"espada", "escudo", "armadura", "adaga", "molotov", "bomba", "medkit", "água", "lanterna", "alabarda"};

    
    
    void Start()
    {
       armas = new string[] {"espada", "escudo", "armadura", "adaga", "molotov", "bomba", "medkit", "água", "lanterna", "alabarda"}; 
    }   
    
    
    
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            for (int i = 0; i < armas.Length; i++)
            {
                print(armas[i]);
            }
        }
    }
}
