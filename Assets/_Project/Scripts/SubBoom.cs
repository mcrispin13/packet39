using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBoom : MonoBehaviour
{
    public GameObject subBoom;
    public float speed = 5f;
    private DialInteractable dialInteractable;
    void Start()
    {
        dialInteractable = GetComponent<DialInteractable>();
    }

    private void ExtendBoom()
    {
        float xpos = subBoom.gameObject.transform.position.x;
        if (xpos < -1)
        {
            xpos -= speed;
            xpos = (xpos <= -1) ? -1f : xpos;
            subBoom.gameObject.transform.position = new Vector3(xpos, 0, 0);
        }
    }

    private void RetractBoom()
    {
        float xpos = subBoom.gameObject.transform.position.x;
        if (xpos < 0)
        {
            xpos += speed;
            xpos = (xpos >= 0) ? 0f : xpos;
            subBoom.gameObject.transform.position = new Vector3(xpos, 0, 0);
        }
    }

    public void UpdateBoomPosition()
    {
        if (dialInteractable.CurrentAngle > 0)
        {
            ExtendBoom();
        }
        else if (dialInteractable.CurrentAngle < 0)
        {
            RetractBoom();
        }
    }
}
