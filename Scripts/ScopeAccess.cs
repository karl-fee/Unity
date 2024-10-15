using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAccess : MonoBehaviour
{
    void Start()
    {
        AnotherClass classTester = new AnotherClass();
        classTester.FruitMachine(4, 5);
    }
}
