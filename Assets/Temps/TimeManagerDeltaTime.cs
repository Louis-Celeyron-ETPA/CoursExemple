using NUnit.Framework.Internal;
using UnityEngine;

public class TimeManagerDeltaTime : MonoBehaviour
{
    //Ici on va utiliser l'Update et deltaTime

    private float timer; //Dans cette variable on va stocker le temps qui s'écoule 
    public GameObject test;
    private int index;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0f;
        index = 0;
    }

    void Update()
    {
        timer += Time.deltaTime; //A chaque frame on ajoute le temps écoulé en secondes depuis la derniere frame
         
        if(timer >= 2) //ceci à lieu uniquement si 2 secondes se sont écoulé
        {
            if(index <10) //On verifie qu'on a fait notre action - de 10 fois
            {
                index++; //On incremente l'index
                timer = 0;//On reinitialise le timer
                
                
                //puis on fait ce qu'on veut
                var objetSpawn = Instantiate(test);
                objetSpawn.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0); //Je place mon objet a des coordonée aléatoire
            }
        }
    }
}
