using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisDebug : MonoBehaviour
{
    public float xAxis;
    public float yAxis;
    public float mouseValue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xAxis = ((float)Input.GetAxis("Mouse X"));
        if(xAxis > 0)
        {
            mouseValue += 1f;
        } else if (xAxis < 0)
        {
            mouseValue -= 1f;
        }
        transform.Rotate(Vector3.right, mouseValue * Time.deltaTime);
        yAxis = ((float)Input.GetAxis("Mouse Y"));
    }
}
