using UnityEngine;

public class Score : MonoBehaviour
{
    //variable local
    [SerializeField] private int _points;

    void Start()
    {
        // Llamamos al m�todo 
        PointsNecessary (_points);
    }

    // M�todo con paso por par�metro
    private void PointsNecessary(int _points)
    {
        if (_points >= 45)
        {
            Debug.Log("�Has llegado a 45 puntos o m�s!");
        }
        else
        {
            Debug.Log("no has llegado a 45 puntos.");
        }
    }
}
