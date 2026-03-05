using UnityEngine;

public class LoadChekpointOnDeath : HpModifier
{
    public Transform checkPoint;

    public override void OnDie()
    {
        if (checkPoint != null)
        {
            transform.position = checkPoint.position;
        }
    }
}
