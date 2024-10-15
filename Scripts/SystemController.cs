using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemController : MonoBehaviour
{
    public bool buttonOne = false;
    public bool buttonTwo = false;
    public bool buttonThree = false;
    public bool buttonFour = false;

    public void Update() {
        if(buttonOne == true){
            ActivateSystem90();
            SelectContentOne();
        } else if(buttonTwo == true) {
            ActivateSystem96();
            SelectContentTwo();
        } else if(buttonThree == true) {
            ActivateSystem105();
            SelectContentThree();
        } else if(buttonFour == true) {
            ActivateSystem120();
            SelectContentOne();
        }
    }

    //Systems
    [Header("Systems")]
    [SerializeField]
    private GameObject system90;
    [SerializeField]
    private GameObject system96;
    [SerializeField]
    private GameObject system105;
    [SerializeField]
    private GameObject system120;

    //Content One
    [Header("Content One")]
    [SerializeField]
    private GameObject contentOne90;
    [SerializeField]
    private GameObject contentOne96;
    [SerializeField]
    private GameObject contentOne105;
    [SerializeField]
    private GameObject contentOne120;

    //Content Two
    [Header("Content Two")]
    [SerializeField]
    private GameObject contentTwo90;
    [SerializeField]
    private GameObject contentTwo96;
    [SerializeField]
    private GameObject contentTwo105;
    [SerializeField]
    private GameObject contentTwo120;

    //Content Three
    [Header("Content Three")]
    [SerializeField]
    private GameObject contentThree90;
    [SerializeField]
    private GameObject contentThree96;
    [SerializeField]
    private GameObject contentThree105;
    [SerializeField]
    private GameObject contentThree120;

    public void ActivateSystem90() {
        system90.SetActive(true);
        system96.SetActive(false);
        system105.SetActive(false);
        system120.SetActive(false);
    }

    public void ActivateSystem96() {
        system90.SetActive(false);
        system96.SetActive(true);
        system105.SetActive(false);
        system120.SetActive(false);
    }

    public void ActivateSystem105() {
        system90.SetActive(false);
        system96.SetActive(false);
        system105.SetActive(true);
        system120.SetActive(false);
    }

    public void ActivateSystem120() {
        system90.SetActive(false);
        system96.SetActive(false);
        system105.SetActive(false);
        system120.SetActive(true);
    }

    public void SelectContentOne()
    {
        if(system90.activeInHierarchy == true) {
            contentOne90.SetActive(true);
            contentTwo90.SetActive(false);
            contentThree90.SetActive(false);
        } else if(system96.activeInHierarchy == true) {
            contentOne96.SetActive(true);
            contentTwo96.SetActive(false);
            contentThree96.SetActive(false);
        } else if(system105.activeInHierarchy == true) {
            contentOne105.SetActive(true);
            contentTwo105.SetActive(false);
            contentThree105.SetActive(false);
        } else if(system120.activeInHierarchy == true) {
            contentOne120.SetActive(true);
            contentTwo120.SetActive(false);
            contentThree120.SetActive(false);
        } else {
            Debug.Log("No system is a active. Please activate a system in the hierarchy.");
        }
    }

    public void SelectContentTwo()
    {
        if(system90.activeInHierarchy == true) {
            contentOne90.SetActive(false);
            contentTwo90.SetActive(true);
            contentThree90.SetActive(false);
        } else if(system96.activeInHierarchy == true) {
            contentOne96.SetActive(false);
            contentTwo96.SetActive(true);
            contentThree96.SetActive(false);
        } else if(system105.activeInHierarchy == true) {
            contentOne105.SetActive(false);
            contentTwo105.SetActive(true);
            contentThree105.SetActive(false);
        } else if(system120.activeInHierarchy == true) {
            contentOne120.SetActive(false);
            contentTwo120.SetActive(true);
            contentThree120.SetActive(false);
        } else {
            Debug.Log("No system is a active. Please activate a system in the hierarchy.");
        }
    }

    public void SelectContentThree()
    {
        if(system90.activeInHierarchy == true) {
            contentOne90.SetActive(false);
            contentTwo90.SetActive(false);
            contentThree90.SetActive(true);
        } else if(system96.activeInHierarchy == true) {
            contentOne96.SetActive(false);
            contentTwo96.SetActive(false);
            contentThree96.SetActive(true);
        } else if(system105.activeInHierarchy == true) {
            contentOne105.SetActive(false);
            contentTwo105.SetActive(false);
            contentThree105.SetActive(true);
        } else if(system120.activeInHierarchy == true) {
            contentOne120.SetActive(false);
            contentTwo120.SetActive(false);
            contentThree120.SetActive(true);
        } else {
            Debug.Log("No system is a active. Please activate a system in the hierarchy.");
        }
    }
}
