using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//least i want 0.17 i want position x to move 
//most we want to move on x axis -0.79
public class SubBoomLever : MonoBehaviour
{
    public Transform lever;
    public Transform subBoomBody;
    public Transform boomBody;
    public float speed = 0.03f;
    private void ExtendBoom()
    {
        float current_position = subBoomBody.position.x;
        //current_position = (float)-0.79*3;
        //current_position = (current_position < -0.75) ? -0.75f : current_position;
        //subBoomBody.transform.position = new Vector3(current_position, boomBody.position.y,boomBody.position.z);
        if(current_position > (-2.2)) transform.Translate(Vector3.left * Time.deltaTime);
    }
    private void RetractBoom()
    {
        //float current_position = subBoomBody.position.x;
        //float subBoomBody_position_y = subBoomBody.position.y;
        //float subBoomBody_position_z = subBoomBody.position.z;
        //current_position += speed;
        //current_position = (current_position > 0) ? 0 : current_position;
        //subBoomBody.transform.position = new Vector3(current_position, boomBody.position.y, boomBody.position.z);

        float current_position = subBoomBody.position.x;
        //current_position = (float)-0.79*3;
        //current_position = (current_position < -0.75) ? -0.75f : current_position;
        //subBoomBody.transform.position = new Vector3(current_position, boomBody.position.y,boomBody.position.z);
        if (current_position < (.17)) transform.Translate(-Vector3.left * Time.deltaTime);
    }
    void Update()
    {
        float angle = lever.transform.eulerAngles.x;
        if (angle > 315 && angle < 350)
        {
           
            ExtendBoom();
            Debug.Log("Angle is: " + angle);
            Debug.Log("The subboom's x position is: " + subBoomBody.position.x);
            Debug.Log("The subboom's y position is: " + subBoomBody.position.y);
            Debug.Log("The subboom's z position is: " + subBoomBody.position.z);
            
        }
        else if (angle <45 && angle > 15)
        {
            RetractBoom();
            Debug.Log("Angle is: " + angle);

        }
    }
}
