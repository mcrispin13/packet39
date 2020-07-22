using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject magnetObject;

    public Transform subBoomBody;

    public Transform pulleyLever;

    public float speed = 0.015f;
    private bool topLimit = false;
    private bool lowLimit  =false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        extendStopToggle();
        float angle = pulleyLever.transform.eulerAngles.x;
        if (angle > 315 && angle < 350)
        {
            ExtendMagnet();  
            
        }
        else if (angle <45 && angle > 0)
        {
            RetractMagnet();

        }
        

        Debug.Log("magnet y position: " + magnetObject.transform.position.y);

        Debug.Log("subBoom y position: " + subBoomBody.position.y);

        Debug.Log("sweet spot" + (subBoomBody.position.y - 0.05));
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "floor")
        {
            lowLimit = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "floor")
        {
            lowLimit = false;
        }
    }


    private void ExtendMagnet()
    {
        
        float current_position = magnetObject.transform.position.y;
        if(!lowLimit) transform.Translate(Vector3.forward * Time.deltaTime);
    }

    private void RetractMagnet(){

        float current_position = magnetObject.transform.position.y;
        if(!topLimit) transform.Translate(Vector3.back * Time.deltaTime);
    }

    private void extendStopToggle(){
        float current_position = magnetObject.transform.position.y;
        if (current_position > subBoomBody.position.y - 0.08 || subBoomBody.position.y < 1.24){
           
            topLimit = true;
            
        }
        
        else {
            topLimit = false;
      
        }
    }


    // public void OnTriggerEnter(){

    // }
}
