using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()


    {
        IsMultiplesOfThree();
    }
    private void IsMultiplesOfThree()

    {
        //multiplo de 3
        for (int i = 0; i < 100; i++)

        {
            if (i % 3 == 0) 


           
            {
                Debug.Log(i);
                //Seria multiplo de 3
            }
        }

    }

}
