using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoid
{
    public virtual void Yell()
    {
        Debug.Log ("Humanoid version of the Yell() method");
    }
}

public class Enemy : Humanoid
{
    public override void Yell()
    {
        Debug.Log ("Enemy version of the Yell() method");
    }
}
public class Orc : Enemy
{
    //This hides the Enemy version.
    public override void Yell()
    {
        Debug.Log ("Orc version of the Yell() method");
    }
}
public class MemberHiding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();

        //Notice how each Humanoid variable contains
        //a reference to a different class in the
        //inheritance hierarchy, yet each of them
        //calls the Humanoid Yell() method.
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
