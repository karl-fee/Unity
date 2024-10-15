using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseGate : MonoBehaviour
{
    private bool gateOpen;
    private bool emergencyGateOpen;
    private bool swingGateOpen;
    public void OpenGate() {

        if(gateOpen == false) {
            GetComponent<Animator>().Play("CINEMA_4D_Main");
            gateOpen = true;
        } else {
            GetComponent<Animator>().Play("CINEMA_4D_Main_Reverse");
            gateOpen = false;
        }
    }

    public void OpenEmergencyGate() {
        if(emergencyGateOpen == false) {
            GetComponent<Animator>().Play("EmergencyGateOpen");
            emergencyGateOpen = true;
        } else {
            GetComponent<Animator>().Play("EmergencyGateClose");
            emergencyGateOpen = false;
        }
    }

    public void OpenSwingGate() {
        if(swingGateOpen == false) {
            GetComponent<Animator>().Play("SwingGateOpen");
            swingGateOpen = true;
        } else {
            GetComponent<Animator>().Play("SwingGateClose");
            swingGateOpen = false;
        }
    }
}
