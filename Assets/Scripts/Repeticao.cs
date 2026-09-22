using UnityEngine;

public class Repeticao : MonoBehaviour
{
    public int municao = 10;

    public void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                continue;
            }
            if (i == 12)
            {
                break;
            }
            print(i);

            
        }
    }
    
    
    
    
    //public void Shotgun()
    //{
        //for (int i = 0; i < municao; i++)
       // {
            //print ("pow! "+i);
        //}
    //}
}
