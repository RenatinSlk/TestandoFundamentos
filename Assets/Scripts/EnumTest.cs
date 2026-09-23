using UnityEngine;


public enum TipoInimigo
{
    Zumbi,
    Esqueleto,
    Slime,
    Aranha,
    Morcego
}

public class EnumTest : MonoBehaviour
{
    public TipoInimigo tipo;
    public TipoInimigo tipo2;

    void Start()
    {
        print(tipo);
    }
}
