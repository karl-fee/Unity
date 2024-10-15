using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeTest : MonoBehaviour
{

    [SerializeField]
    private int speed;

    [HideInInspector]
    public int speedHidden;

    [Range(0,20)]
    public int speedRange;

}
