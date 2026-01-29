using UnityEngine;

public class ApparitionDisparition : MonoBehaviour
{

    //Ici nous allons voir comment faire apparaitre/disparaitre un objet

    public GameObject objetCible; //Objet a faire apparaitre disparaitre Toujours un objet différent sinon il ne peut pas se re activer une fois desactivé


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Quand on appuie sur Espace
        { 
            objetCible.SetActive(false);//On desactive l'objet
        }
        if (Input.GetKeyDown(KeyCode.LeftControl)) //Quand on appuie sur Ctrl
        {
            objetCible.SetActive(true);//On ative l'objet
        }

        // /!\ Tous les enfants d'un objets sont activé/desactivé avec lui /!\
    }
}
