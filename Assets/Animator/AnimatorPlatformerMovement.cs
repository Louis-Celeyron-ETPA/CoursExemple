using UnityEngine;

public class AnimatorPlatformerMovement : PlayerMovementPlatformer
{
    public Animator myAnimator;
    public SpriteRenderer mySpriteRenderer;
    private void Update()
    {
        base.Update();

        myAnimator.SetFloat("YVelocity",rb.linearVelocityY);
        myAnimator.SetFloat("XVelocity",Mathf.Abs(rb.linearVelocityX));
        myAnimator.SetBool("IsGround", isGrounded);
        mySpriteRenderer.flipX = Mathf.Sign(rb.linearVelocityX) < 0;
    }
}
