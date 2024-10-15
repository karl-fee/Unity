using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dragon dragon = new Dragon();
        dragon.Attack();

        Dragon dragon2 = new BlueDragon();
        dragon2.Attack();

        Dragon dragon3 = new RedDragon();
        dragon3.Attack();
    }

    public virtual void Attack(){
        Debug.Log("Dragon Attack!");
    } 
}

//End of Dragon class

public class BlueDragon : Dragon
{
    public override void Attack(){
        Debug.Log("Blue Dragon Attack!");
    }
}

public class RedDragon : Dragon
{
    public override void Attack(){
        Debug.Log("Red Dragon Attack!");
    }
}

