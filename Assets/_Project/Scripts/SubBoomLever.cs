using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBoomLever : MonoBehaviour
{
    public Transform lever;
    public Transform subBoomBody;
    public float speed = 0.05f;
    void Update()
    {
        float angle = lever.transform.eulerAngles.x;
        Debug.Log("angle");
        if (angle < 0)
        {
            subBoomBody.position = new Vector3(
                Mathf.Clamp(subBoomBody.position.x - speed, -0.95f, 0), 0, 0
            );
        }
        else if (angle > 0)
        {
            subBoomBody.position = new Vector3(
                Mathf.Clamp(subBoomBody.position.x + speed, -0.95f, 0), 0, 0
            );
        }
    }
}
