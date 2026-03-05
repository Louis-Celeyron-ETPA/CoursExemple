using UnityEngine;

public class IsNextToPlayer : MonoBehaviour
{
    public bool isGlow;
    public SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mat = sr.material;

        mat.SetFloat("_isGlow", isGlow ? 0.5f : 0f);
    }
}
