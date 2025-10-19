using UnityEngine;

public class Odd : MonoBehaviour
{
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()


    {
        IsOdd();
    }
    private void IsOdd()

    {
       //numeros impares
       for (int i = 0; i < 100; i++) 
        
        {
            if (i % 2 == 0) ;

            
            else
            {
                Debug.Log(i);
                //Seria impar
            }
        }

    }

}
