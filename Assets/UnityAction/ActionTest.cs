using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionTest : MonoBehaviour
{

    public List<MaStruct> maList;
    private string targetString, actionString;

    public TargetObject[] allTarget;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        allTarget = FindObjectsByType<TargetObject>(FindObjectsSortMode.None);
    }

    public void SetTs(string ts)
    {
        targetString = ts;
    }
    public void SetAs(string aS)
    {
        actionString = aS;
    }

    public void CallAction()
    {
        TargetObject target = default;
        foreach (var obj in allTarget)
        {
            if (obj.Name == targetString)
            {
                target = obj;
                break;
            }
        }

        MaStruct action = default;  
        foreach (var act in maList)
        {
            if (act.keyWord == actionString)
            {
                action= act;
                break;
            }
        }
        print($"{action}{target}");

        action.action.Invoke(target);
    }

    public void Shake(TargetObject target)
    {
        target.transform.position += Vector3.left;
    }

    public void Colorize(TargetObject target)
    {
        var targetRenderer = target.GetComponent<SpriteRenderer>();
        if(targetRenderer != null)
        {
            targetRenderer.color = Color.blue;
        }
        
    }

}

[System.Serializable]
public struct MaStruct
{
    public string keyWord;
    public UnityEvent<TargetObject> action;
}