using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasciaScript : MonoBehaviour
{
    public int smoothing;
    private Vector3 newPositionA;
    private Vector3 newPositionB;
    // Start is called before the first frame update
    void Awake()
    {
        newPositionA = transform.position;
        newPositionB = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PositionChange();
    }

    void PositionChange() {
        Vector3 posOneY = new Vector3(0, 1, 0);
        Vector3 posOneZ = new Vector3(0, 1, 1);
        Vector3 posTwoY = new Vector3(0, 0, 0);
        Vector3 posTwoZ = new Vector3(0, 1, 0);

        if(Input.GetKeyDown(KeyCode.Q)) {
        newPositionA = posOneY;
        newPositionB = posOneZ;
        }
        if(Input.GetKeyDown(KeyCode.W)) {
        newPositionA = posTwoY;
        newPositionB = posTwoZ;
        }
        StartCoroutine("LerpCoroutine");
        //transform.position = Vector3.Lerp(transform.position, newPositionA, Time.deltaTime * smoothing);
        //transform.position = Vector3.Lerp(transform.position, newPositionB, Time.deltaTime * smoothing);
    }
    IEnumerator LerpCoroutine() {
        Debug.Log("Coroutine Started!");
        transform.position = Vector3.Lerp(transform.position, newPositionA, Time.deltaTime * smoothing);
        yield return new WaitForSeconds(1f);
        transform.position = Vector3.Lerp(transform.position, newPositionB, Time.deltaTime * smoothing);
        yield return null;
    }

}