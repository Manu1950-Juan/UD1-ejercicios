using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    //Variables locales
    public int a;
    public int b;
    public int c;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsDescendingOrder();

    }
    private void IsDescendingOrder()
    {
       //Hacemos comparativas
        
        if (a > b && b > c)

        {
            Debug.Log("Los n�meros est�n en orden decreciente.");
        }



        else //en caso que no se cumpla
        {
            Debug.Log("Los n�meros no est�n en orden decreciente.");
        }
    }
}