using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    //Variables locales
    public int a;
    public int b;
    public int c;
        
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsIncreasingOrder();

    }
    private void IsIncreasingOrder()
    {
        if (a < b &&  b<c)
    
    {
    Debug.Log ("Los n�meros est�n en orden creciente.");
        }



        else
            {
            Debug.Log ("Los n�meros no est�n en orden creciente.");
        }
    }

}
