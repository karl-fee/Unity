using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDebug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)) {
            GetComponent<Animator>().Play("FasciaOpen");
        }
        if(Input.GetKeyDown(KeyCode.W)) {
            GetComponent<Animator>().Play("FasciaClose");
        }
    }
}