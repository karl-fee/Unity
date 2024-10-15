using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    // Variables
    private bool gateOpen;
    private bool coroutineRunning = false;

    //Functions
    public void OpenEmergency() {
        if(coroutineRunning == false) {
            StartCoroutine("EmergencyCoroutine");
        }
    }

    public void OpenSwing() {
        if(coroutineRunning == false) {
            StartCoroutine("SwingCoroutine");
        }
    }

    public void OpenFascia() {
        if(coroutineRunning == false) {
            StartCoroutine("FasciaCoroutine");
        }
    }

    //Coroutines
    IEnumerator EmergencyCoroutine() {
        coroutineRunning = true;
        Debug.Log("Coroutine Started!");
        coroutineRunning = true;
        if(gateOpen == false) {
            GetComponent<Animator>().Play("CINEMA_4D_Main");
        } else {
            GetComponent<Animator>().Play("CINEMA_4D_Main_Reverse");
        }
        yield return new WaitForSeconds(3f);
        Debug.Log("3 Seconds Passed!");
        if(gateOpen == false) {
            gateOpen = true;
        } else {
            gateOpen = false;
        }
        coroutineRunning = false;
    }

    IEnumerator SwingCoroutine() {
        coroutineRunning = true;
        Debug.Log("Coroutine Started!");
        coroutineRunning = true;
        if(gateOpen == false) {
            GetComponent<Animator>().Play("CINEMA_4D_Main");
        } else {
            GetComponent<Animator>().Play("CINEMA_4D_Main_Reverse");
        }
        yield return new WaitForSeconds(3f);
        Debug.Log("3 Seconds Passed!");
        if(gateOpen == false) {
            gateOpen = true;
        } else {
            gateOpen = false;
        }
        coroutineRunning = false;
    }

    IEnumerator FasciaCoroutine() {
        coroutineRunning = true;
        Debug.Log("Coroutine Started!");
        coroutineRunning = true;
        if(gateOpen == false) {
            GetComponent<Animator>().Play("CINEMA_4D_Main");
        } else {
            GetComponent<Animator>().Play("CINEMA_4D_Main_Reverse");
        }
        yield return new WaitForSeconds(3f);
        Debug.Log("3 Seconds Passed!");
        if(gateOpen == false) {
            gateOpen = true;
        } else {
            gateOpen = false;
        }
        coroutineRunning = false;
    }
}
