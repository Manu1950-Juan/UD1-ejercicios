using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private int _potatoes;       // unidades iniciales de patatas
    [SerializeField] private int _brecol;         // unidades iniciales de br�col
    [SerializeField] private int _addPotatoes;    // cantidad de patatas a a�adir
    [SerializeField] private int _addBrecol;      // cantidad de br�col a a�adir
    [SerializeField] private int _removePotatoes; // cantidad de patatas a restar
    [SerializeField] private int _removeBrecol;   // cantidad de br�col a restar

    void Start()
    {
        // Llamamos a los m�todos pasando los valores por par�metro
        AddProducts(_potatoes, _brecol, _addPotatoes, _addBrecol);
        RemoveProducts(_potatoes, _brecol, _removePotatoes, _removeBrecol);
    }

    // M�todo para a�adir producto (paso por par�metro)
    private void AddProducts (int potatoes, int brecol, int addPotatoes, int addBrecol)
    {
        potatoes += addPotatoes;
        brecol += addBrecol;
        Debug.Log("Despu�s de a�adir: " + potatoes + " patatas y " + brecol + " br�coles.");
    }

    // M�todo para restar producto (paso por par�metro)
    private void RemoveProducts(int potatoes, int brecol, int removePotatoes, int removeBrecol)
    {
        potatoes -= removePotatoes;
        brecol -= removeBrecol;
        Debug.Log("Despu�s de restar: " + potatoes + " patatas y " + brecol + " br�coles.");
    }
}