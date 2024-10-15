using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    //Public Variables
    public GameObject panNull;
    public GameObject tiltNull;
    public int panSpeed;
    public float panRange;
    public int tiltSpeed;
    public float tiltRange;
    public int zoomSpeed;
    public float zoomLower;
    public float zoomUpper;
    //Input Floats
    public float xAxis;
    public float yAxis;
    //Private Variables
    private float camFov;
    private Quaternion panRotation;
    private Quaternion tiltRotation;
    private float panAngle;
    private float tiltAngle;

    void Start()
    {
        GetComponent<Camera>().fieldOfView = camFov;
    }

    void Update()
    {
        xAxis = Input.GetAxis("Mouse X");
        yAxis = Input.GetAxis("Mouse Y");
        CamPan(xAxis);
        CamTilt(yAxis);
        //CamZoom(80f);
        GetComponent<Camera>().fieldOfView = 60f;
    }

    public void CamZoom(float yFloat)
    {
        if(camFov < zoomLower)
        {
            camFov = zoomLower;
        } else if(camFov > zoomUpper)
        {
            camFov = zoomUpper;
        } else
        {
            camFov += (yFloat * Time.deltaTime * zoomSpeed);
        }
        GetComponent<Camera>().fieldOfView = camFov;    
    }
    public void CamPan(float xFloat)
    {   
        if(panAngle < -panRange)
        {
            panAngle = -panRange;
        } else if(panAngle > panRange)
        {
            panAngle = panRange;
        } else
        {
            panAngle += xFloat * Time.deltaTime * panSpeed;
        }
        panRotation = Quaternion.Euler(0, panAngle, 0);
        panNull.transform.rotation = panRotation;
    }

        public void CamTilt(float yFloat)
    {   
        float x = tiltNull.transform.eulerAngles.x;
        float y = tiltNull.transform.eulerAngles.y;
        float z = tiltNull.transform.eulerAngles.z;
        if(tiltAngle < -tiltRange)
        {
            tiltAngle = -tiltRange;
        } else if(tiltAngle > tiltRange)
        {
            tiltAngle = tiltRange;
        } else
        {
            tiltAngle += yFloat * Time.deltaTime * tiltSpeed;
        }
        tiltRotation = Quaternion.Euler(tiltAngle, y, z);
        tiltNull.transform.rotation = tiltRotation;
    }
}
 