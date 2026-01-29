using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour
{
    //Ici on va tester les methodes de temps. La façon la plus simple c'est d'utiliser les coroutines
    
    public GameObject test;//Objet test a spawn

    void Start()
    {
        StartCoroutine(MaCoroutine()); //Une coroutine se lance TOUJOURS a un moment ponctuel (donc pas dans l'update)
    }

    private IEnumerator MaCoroutine()
    {
        for (int i = 0; i < 10; i++) //Je vais faire cette opération 10 fois
        {
            yield return new WaitForSeconds(2); //J'attends 2 secondes

            var objetSpawn = Instantiate(test);
            objetSpawn.transform.position = new Vector3(Random.Range(-5f,5f), Random.Range(-5f, 5f),0); //Je place mon objet a des coordonée aléatoire
        }
    }
}
