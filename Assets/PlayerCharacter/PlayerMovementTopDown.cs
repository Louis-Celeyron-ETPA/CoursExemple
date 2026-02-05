using UnityEngine;

public class PlayerMovementTopDown : MonoBehaviour
{
    public Rigidbody2D rb; //Ne pas oublier de mettre le gravity scale du rigidbody à 0 et d'ajouter un collider
    public float speed = 1;

    void Update()
    {
        var direction = new Vector2(0,0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += new Vector2(0, 1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += new Vector2(0, -1);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            direction += new Vector2(-1, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            direction += new Vector2(1, 0);
        }
        rb.linearVelocity = direction.normalized *speed;
    }
}
