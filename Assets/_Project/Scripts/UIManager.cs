using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    // Start is called before the first frame update
    public GameObject ignition;
    public GameObject rotateCrane;
    public GameObject rotateBoom;
    public GameObject extendPulley;
    public GameObject extendBoom;
    public GameObject pickUp;
    public GameObject dropBoom;

    public void IgnitionDone()
    {
        ignition.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void RotateCraneDone()
    {
        rotateCrane.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void RotateBoomDone()
    {
        rotateBoom.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void ExtendPulleyDone()
    {
        extendPulley.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void ExtendBoomDone()
    {
        extendBoom.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void PickUpDone()
    {
        pickUp.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void DropBoomDone()
    {
        dropBoom.transform.GetChild(0).gameObject.SetActive(true);
    }

}
