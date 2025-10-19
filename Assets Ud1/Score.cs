using UnityEngine;

public class Score : MonoBehaviour
{
    //variable local
    [SerializeField] private int _points;

    void Start()
    {
        // Llamamos al método 
        PointsNecessary (_points);
    }

    // Método con paso por parámetro
    private void PointsNecessary(int _points)
    {
        if (_points >= 45)
        {
            Debug.Log("¡Has llegado a 45 puntos o más!");
        }
        else
        {
            Debug.Log("no has llegado a 45 puntos.");
        }
    }
}
