using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyIgnition : MonoBehaviour
{
    // Start is called before the first frame update
    private bool _active = false;
    public GameObject Lever1;
    public GameObject Lever2;
    public GameObject Lever3;
    public GameObject Lever4;
    private bool isDone = false;

    public void Start()
    {
        SetGameObjects();
    }

    private void SetGameObjects()
    {
        Lever1.layer = (_active) ? 0 : 11;
        Lever2.layer = (_active) ? 0 : 11;
        Lever3.layer = (_active) ? 0 : 11;
        Lever4.layer = (_active) ? 0 : 11;
    }
    public void Toggle()
    {
        _active = !_active;
        if (_active && !isDone)
        {
            isDone = true;
            UIManager.Instance.IgnitionDone();
        }
        SetGameObjects();
    }
}
