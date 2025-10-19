
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    //Variables locales
    public int a;
    public int b;
    public int c;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsFromLargestToSmallest();
    }

    private void IsFromLargestToSmallest()

    {
        // A siendo es el mayor
        if (a >= b && a >= c)
        {
            if (b >= c)
            {
                //sale por consola los ordenes de los diferentes números
                Debug.Log("primer numero: " + a);
                Debug.Log("segundo numero: " + b);
                Debug.Log("tercer numero:" + c);
            }
            else
            {
                Debug.Log("primer numero: " + a);
                Debug.Log("segundo numero:" + c);
                Debug.Log("terce numero: " + b);

            }
        }

        //  b es el mayor
        else if (b >= a && b >= c)

        {
            if (a >= c)
            {
                Debug.Log("primer numero: " + b);
                Debug.Log("segundo numero: " + a);
                Debug.Log("tercer numero:" + c);
            }
            else
            {
                Debug.Log("primer numero: " + b);
                Debug.Log("segundo numero:" + c);
                Debug.Log("tercer numero:" + a);
            }
        }
        // c es el mayor
        else
        {
            if (a >= b)
            {
                Debug.Log("primer numero:" + c);
                Debug.Log("segundo numero:" + a);
                Debug.Log("tercer numero: " + b);
            }
            else
            {
                Debug.Log("primer numero:" + c);
                Debug.Log("segundo numero: " + b);
                Debug.Log("tercer numero:" + a);

            }
        }
    }
}


