using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBoomLever : MonoBehaviour
{
    public Transform lever;
    public Transform subBoomBody;
    public float speed = 0.01f;
    private void ExtendBoom()
    {
        float current_position = subBoomBody.position.x;
        float subBoomBody_position_y = subBoomBody.position.y;
        float subBoomBody_position_z = subBoomBody.position.z;
        current_position -= speed;
        current_position = (current_position < -0.75) ? -0.75f : current_position;
        subBoomBody.transform.position = new Vector3(current_position, subBoomBody.position.y,subBoomBody.position.z);
    }
    private void RetractBoom()
    {
        float current_position = subBoomBody.position.x;
        float subBoomBody_position_y = subBoomBody.position.y;
        float subBoomBody_position_z = subBoomBody.position.z;
        current_position += speed;
        current_position = (current_position > 0) ? 0 : current_position;
        subBoomBody.transform.position = new Vector3(current_position, subBoomBody.position.y, subBoomBody.position.z);
    }
    void Update()
    {
        float angle = lever.transform.eulerAngles.x;
        if (angle > 315 && angle < 360)
        {
           
            ExtendBoom();
            Debug.Log("Angle is: " + angle);
            Debug.Log("The subboom's x position is: " + subBoomBody.position.x);
            Debug.Log("The subboom's y position is: " + subBoomBody.position.y);
            Debug.Log("The subboom's z position is: " + subBoomBody.position.z);
            
        }
        else if (angle <45 && angle > 0)
        {
            RetractBoom();
            Debug.Log("Angle is: " + angle);

        }
    }
}
