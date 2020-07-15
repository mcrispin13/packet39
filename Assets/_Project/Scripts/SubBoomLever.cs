using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBoomLever : MonoBehaviour
{
    public Transform lever;
    public Transform subBoomBody;
    public float speed = 0.05f;
    private void ExtendBoom()
    {
        float current_position = subBoomBody.gameObject.transform.position.x;
        current_position -= speed;
        current_position = (current_position < -1) ? -1f : current_position;
    }
    private void RetractBoom()
    {
        float current_position = subBoomBody.gameObject.transform.position.x;
        current_position += speed;
        current_position = (current_position > 0) ? 0 : current_position;
    }
    void Update()
    {
        float angle = lever.transform.eulerAngles.x;
        if (angle < 0)
        {
            ExtendBoom();
        }
        if (angle > 0)
        {
            RetractBoom();
        }
    }
}
