using UnityEngine;

public class SpawnObjectExample : MonoBehaviour
{
    //Dans ce script on montre les differentes maniere de spawner un objet


    void Start()
    {
        MethodeSimple();
        MethodeComplexe();
        MethodeComplete();
    }

    public GameObject objetASpawner;
    public void MethodeSimple()
    {
        //En utilisant Instantiate sans rien avant ou aprés on crée une copie EXACTE de l'objet a spawner (meme coordonée, meme script ataché etc...)
        Instantiate(objetASpawner);
    }

    public Rigidbody2D objetASpawnerRigidbody;
    public void MethodeComplexe()
    {
        //Meme chose que la méthode simple mais ici on s'assure que l'objet a spawner sera FORCEMENT un rigidbody, marche avec tout les script MonoBehaviour
        Instantiate(objetASpawnerRigidbody);
    }
    public void MethodeComplete()
    {
        //Meme chose que la complexe mais on peut stocker l'objet crée dans une variable locale en tant que rigidbody et lui faire des trucs
        var monObjetSpawné = Instantiate(objetASpawnerRigidbody);

        //Par exemple je met la gravité à 0 et je l'envoie sur la droite
        monObjetSpawné.transform.position = Vector2.zero;
        monObjetSpawné.gravityScale = 0;
        monObjetSpawné.linearVelocityX = 1;
    }

}
