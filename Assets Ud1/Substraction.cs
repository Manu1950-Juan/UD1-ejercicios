using UnityEngine;

public class Substraction : MonoBehaviour
{
    public int Number;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()


    {
        IsSubstraction();
    }
    private void IsSubstraction()

    {
        //Cuenta regresiva
        for (int i = Number; i>= 1; i--) 

        {
            


            //Mostrar numero
            
                Debug.Log("Los numeros son"+ i);
                
            
        }

    }

}
