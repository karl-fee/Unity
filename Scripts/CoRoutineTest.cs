using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutineTest : MonoBehaviour
{
    //public GameObject cube;
    public float smoothing;
    private Vector3 origPos;
    private Vector3 newPos;
    Vector3 posA = new Vector3(0, 2, 0);
    Vector3 posB = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void awake()
    {
        origPos = transform.position;
    }
    void Start()
    {
        //StartCoroutine("Test3", 12);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)) {
            newPos = posA;
            transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * smoothing);
            StartCoroutine("Test");
        }
        if(Input.GetKeyDown(KeyCode.W)) {
            newPos = posB;
            StartCoroutine("Test");
        }
    }

    IEnumerator Test() {
        print("Start Coroutine!");
        GetComponent<Renderer>().material.color = Color.black;
        
        yield return new WaitForSeconds(2f);
        //transform.position = posA;
        //transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * smoothing);
        GetComponent<Renderer>().material.color = Color.cyan;

        print("Mid-Coroutine!");
        
        yield return new WaitForSeconds(2f);
        GetComponent<Renderer>().material.color = Color.magenta;
        print("End Coroutine!");
    }

    void PositionChange() {
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * smoothing);
    }
}
