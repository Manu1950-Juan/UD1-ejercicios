using UnityEngine;


public class Change : MonoBehaviour

{

    // Array de 5 

    private int[] _numberArray = { 1, 1, 1, 1, 1 };


    void Start()

    {

        IsTrueOrFalse();

    }


    void IsTrueOrFalse()

    {

        // Muestra en consola cuántos elementos tiene el array

        Debug.Log("El número de elementos del array es: " + _numberArray.Length);


        // Cambiamos el primero y el ultimo elemento por 42

        _numberArray[0] = 42;

        _numberArray[_numberArray.Length - 1] = 42;


        // Muestra todos los valores del array en consola

        for (int i = 0; i < _numberArray.Length; i++)

        {
            Debug.Log("elementos " + i + ": " + _numberArray[i]);

        }

    }

}