using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentScriptA : MonoBehaviour
{
    private ComponentScriptB componentScriptB;
    private string foreignString;
    void Start()
    {
        componentScriptB = GameObject.Find("GameManager").GetComponent<ComponentScriptB>();
        foreignString = componentScriptB.foreignString;
        Debug.Log(foreignString);
    }
}
