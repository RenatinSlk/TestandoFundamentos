using UnityEngine;

public enum Equipamento
    {
        EspadaFerro,
        EspadaCobre,
        EspadaMadeira,
        BastaoFerro,
        PocaoPiromancia 
    }

public class Loja : MonoBehaviour
{
    private Dictionary<Equipamento, decimal> catalogo;

    public Loja()
    {
        catalogo = new Dictionary<Equipamento, decimal>()
        {
            {Equipamento.EspadaFerro, 25.00m},
            {Equipamento.EspadaCobre, 20.00m},
            {Equipamento.EspadaMadeira, 10.00m},
            {Equipamento.BastaoFerro, 30.00m},
            {Equipamento.PocaoPiromancia, 40.00m}
        };
    }

    public void ExibirCatalogo()
    {
        Debug.Log("Itens da Loja")

        foreach (KeyValuePair<Equipamento, decimal> item in catalogo)
        {
            Debug.Log($"Produto: {item.Key} | Preço: R$ {item.Value:F2}");
        }
    }

    class Program
    {
        static void Main()
        {
            Loja minhaLoja = new Loja();
            minhaLoja.ExibirCatalogo();
        }
    }
}
