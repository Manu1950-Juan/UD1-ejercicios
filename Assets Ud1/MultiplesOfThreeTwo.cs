using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()


    {
        IsMultiplesOfThreeTwo();
    }
    private void IsMultiplesOfThreeTwo()

    {
        //multiplo de 2 y 3
        for (int i = 0; i <= 100; i++)

        {
            if (i % 2 == 0 && i % 3==0)



            {
                Debug.Log(i);
                //Seria multiplo de 2 y 3
            }
        }

    }

}
