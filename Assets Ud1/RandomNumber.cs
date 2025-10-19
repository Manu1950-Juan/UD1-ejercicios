using UnityEngine;


public class RandomNumber : MonoBehaviour

{

    // Array con 5 mensajes inventados

    private string[] messages = {

"¿Sere un tester, un programador, o un modelador?",

"No te rindas aunque te cueste la materia. Pronto estaras haciendo juegos para Naugthy",

"La profesora es maja si me lees. Hola Monica :), apruebame. Espero aprobar",

"Odio el ejercicio de las patatas, pero seguro que mañana lo acabo",

"Deberia estar jugando a la play, pero mañana seguramente tenga que seguir aqui"

};
    


    void Start()

    {

        RandomMessage();

    }


    void RandomMessage()

    {

        // Genera un mensaje aleatorio entre 0 y 4

        int randomIndex = Random.Range(0, messages.Length);
        Debug.Log(messages[randomIndex]);

    }
}