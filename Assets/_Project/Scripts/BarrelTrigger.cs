using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelTrigger : MonoBehaviour
{
    public GameObject barrel;



    public bool isConnected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "magnet")
        {
           barrel.GetComponent<FixedJoint>().connectedBody = other.GetComponent<Rigidbody>();;
        }
    }
}
