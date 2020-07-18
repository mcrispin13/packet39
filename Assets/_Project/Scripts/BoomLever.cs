using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomLever : MonoBehaviour
{
    public Transform lever;
    public Transform boomBody;
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle = lever.transform.eulerAngles.x;
        //if (angle < -9) angle = -9;
        //Debug.Log("Angle=" + angle);
        Change();







    }

    void Change()
    {
        Vector3 newRot = new Vector3(boomBody.transform.eulerAngles.x, boomBody.eulerAngles.y, angle);
        boomBody.rotation = Quaternion.Euler(newRot);
    }
}
