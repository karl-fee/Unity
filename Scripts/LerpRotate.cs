using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpRotate : MonoBehaviour
{
    public int smoothing;
    private Vector3 newRotation;
    // Start is called before the first frame update
    void Awake()
    {
        newRotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        RotationChange();
    }

    void RotationChange() {
        Vector3 rotationA = new Vector3(0, 0, 0);
        Vector3 rotationB = new Vector3(0, 90, 0);

        if(Input.GetKeyDown(KeyCode.Q)) {
        newRotation = rotationA;
        }
        if(Input.GetKeyDown(KeyCode.W)) {
        newRotation = rotationB;
        }

        transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, newRotation, Time.deltaTime * smoothing));
    }
}
