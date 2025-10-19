using UnityEngine;


public class Logic : MonoBehaviour

{
    //estructura del array
    private bool[] trueOrFalseArray = { false, false, false };


    void Start()

    {

        IsTrueOrFalse();

    }


    void IsTrueOrFalse()

    {

        //elementos del array
        trueOrFalseArray[0] = true;

        
        for (int i = 0; i < trueOrFalseArray.Length; i++)

        {
            //en consola
            Debug.Log(trueOrFalseArray[i]);

        }

    }

}