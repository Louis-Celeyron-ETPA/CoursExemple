using UnityEngine;

public class Trap : Interactable
{
    public int dammage=3;
    [SerializeField]
    private DammageType type;
    public override void OnTrigger(GameObject objectTriggered)
    {
        var healthManager = objectTriggered.GetComponent<HealthManager>();

        healthManager.Dammage(dammage, type);
    }
}
