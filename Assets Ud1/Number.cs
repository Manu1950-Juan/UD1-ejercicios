using UnityEngine;

public class Number : MonoBehaviour
{

    //Variables locales
    [SerializeField]
    private int _number;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsNumber();

    }
    private void IsNumber()

    {
        int incremento = _number + 1;
        //incremento
      
        Debug.Log("Número incrementado: " + incremento);


    }
    private int Incrementar(int _number)  // llamamos al metodo con el incremento
    {
        _number++;           // sumamos 1
        return _number;      // devolvemos el resultado
    }

}
