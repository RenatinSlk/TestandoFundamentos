using UnityEngine;

public class Inventario : MonoBehaviour
{
    public string{} armas = new string[] {"espada", "escudo", "armadura", "adaga", "molotov", "bomba", "medkit", "água", "lanterna", "alabarda"}

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ExibirArmas();
        }
    }

    void ExibirArmas()
    {
        Debug.Log("espada", "escudo", "armadura", "adaga", "molotov", "bomba", "medkit", "água", "lanterna", "alabarda");
        
        foreach (string arma in armas)
        {
            Debug.Log(arma);
        }
    }
}
