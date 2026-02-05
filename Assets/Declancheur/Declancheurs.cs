using UnityEngine;

public class Declancheurs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        print("Tu m'as cliqué dessus");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var urfhei = collision.GetComponent<SpriteRenderer>();
        if(urfhei != null)
        {
            urfhei.sprite = null;
        }
    }
}
