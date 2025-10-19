using Unity.XR.GoogleVr;
using UnityEngine;

public class Week : MonoBehaviour
{

    //variables locales
    public int DayWeek;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsDayWeek();
    }
    private void IsDayWeek()
    
    {
        switch (DayWeek)
    { 
        case 1:
                Debug.Log ("Enero");
                break; 
                case 2:
                Debug.Log ("Febrero");
                break; 
                case 3:
                Debug.Log("Marzo");
                break;
                case 4:
                Debug.Log("Abril");
                break;
                case 5:
                Debug.Log("Mayo");
                break; 
                case 6:
                Debug.Log("Junio");
                    break;
                case 7:
                Debug.Log("Julio");
                break;
            default:
                Debug.Log("El número introducido no corresponde con algun mes requerido del año");
                    break;
        }

    }
}
