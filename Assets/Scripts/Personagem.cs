using UnityEditor.Rendering.BuiltIn.ShaderGraph;
using UnityEngine;
using UnityEngine.UI;

public class Personagem : MonoBehaviour
{
    public int vida = 100;
    public int forca = 70;
    public int defesa = 60;
    public int stamina = 100;
    public int magia = 100;
    public float experiencia = 6.5f;
    public string classe = "Lutador";
    public bool estaVivo = true;

    public int[] arrayExemplo = new int[5];

    void Start()
    {
        arrayExemplo[0] = 50;
        int tamanho = arrayExemplo.Length;
    }
}
