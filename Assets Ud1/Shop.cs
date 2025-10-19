using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private int _potatoes;       // unidades iniciales de patatas
    [SerializeField] private int _brecol;         // unidades iniciales de brécol
    [SerializeField] private int _addPotatoes;    // cantidad de patatas a añadir
    [SerializeField] private int _addBrecol;      // cantidad de brécol a añadir
    [SerializeField] private int _removePotatoes; // cantidad de patatas a restar
    [SerializeField] private int _removeBrecol;   // cantidad de brécol a restar

    void Start()
    {
        // Llamamos a los métodos pasando los valores por parámetro
        AddProducts(_potatoes, _brecol, _addPotatoes, _addBrecol);
        RemoveProducts(_potatoes, _brecol, _removePotatoes, _removeBrecol);
    }

    // Método para añadir producto (paso por parámetro)
    private void AddProducts (int potatoes, int brecol, int addPotatoes, int addBrecol)
    {
        potatoes += addPotatoes;
        brecol += addBrecol;
        Debug.Log("Después de añadir: " + potatoes + " patatas y " + brecol + " brécoles.");
    }

    // Método para restar producto (paso por parámetro)
    private void RemoveProducts(int potatoes, int brecol, int removePotatoes, int removeBrecol)
    {
        potatoes -= removePotatoes;
        brecol -= removeBrecol;
        Debug.Log("Después de restar: " + potatoes + " patatas y " + brecol + " brécoles.");
    }
}