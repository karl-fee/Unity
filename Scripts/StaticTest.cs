using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Bullets bullet1 = new Bullets();
        //bullet1.numberOfBullets = 10;
        Bullets bullet2 = new Bullets();
        //bullet2.numberOfBullets = 20;
        Bullets bullet3 = new Bullets();

        Debug.Log("Number of bullet instances is: " + Bullets.numberOfBullets);
        //Debug.Log(bullet2.numberOfBullets);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Bullets
{
    public static int numberOfBullets;

    public Bullets(){
        numberOfBullets++;
    }
}
