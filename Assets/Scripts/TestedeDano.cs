using UnityEngine;

public class TestedeDano : MonoBehaviour
{
    [SerializeField] private int vida = 100;

    public void AplicarDano(int dano)
    {
        vida -= dano;

         if (vida < 0)
         {
            vida = 0
         }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (vida > 0)
            {
                int danoAleatorio = Random.Range(1,5)
                AplicarDano(danoAleatorio);
                Debug.Log($"Dano recebido: {danoAleatorio} | Vida restantes: {vida}");

                if (vida == 0)
                {
                    Debug.Log("O inimigo foi destruído!");
                }    
            }
        }
        else 
        {
            Debug.Log("O inimigo já está derrotado");    
        }
    }
}
