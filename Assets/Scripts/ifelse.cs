using UnityEngine;

public class ifelse : MonoBehaviour
{
    public float timer = 0;
    public bool ligado = true;

    public void Update()
    {
        
        if (ligado == true)
        {
            if (timer < 100)
        {
            timer += 0.0001f;
        }

        else
        {
            timer = 0;
        }
        } 
    }
}
