using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetDrop : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject magnet;

    // public GameObject barrel;

    public bool isConnected = false;

    // public void OnTriggerEnter(Collider other){
    //     if (other.tag == "magnet button"){
    //         if (isConnected){
    //             magnet.gameObject.GetComponent<FixedJoint>().connectedBody = null;
    //         }
    //     }
    // }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkConnection();
    }

    public void checkConnection(){
        if (magnet.GetComponent<FixedJoint>().connectedBody != null) {
            isConnected = true;
        }

        else{
            isConnected=false;
        }
    }
}
