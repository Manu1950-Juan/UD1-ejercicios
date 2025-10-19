using UnityEngine;

public class Even : MonoBehaviour
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()


    {
        IsEven();
    }
    private void IsEven()

    {
        //numeros pares
        for (int i = 0;  i <= 100; i++)

        {
            //el resto debe ser igual a 0 para ser par
            if (i % 2 == 0) 



            { 
                Debug.Log(i);
                //Seria par
            }
        }

    }

}
