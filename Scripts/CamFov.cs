using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFov : MonoBehaviour
{
    public float myFov;
    public float moveSpeed = 1000f;
    public float zoomSpeed = 500f;


    // Start is called before the first frame update
    void Start()
    {
        myFov = GetComponent<Camera>().fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        //Zoom Camera
        float yAxis = Input.GetAxis("Mouse Y");
        myFov += (yAxis * Time.deltaTime * zoomSpeed);
        GetComponent<Camera>().fieldOfView = Mathf.Clamp(myFov, 4f, 10f);

        //Move Camera
        float xAxis = Input.GetAxis("Mouse X");
        transform.Rotate(0, xAxis * moveSpeed * Time.deltaTime, -40, 0);
    }
}
