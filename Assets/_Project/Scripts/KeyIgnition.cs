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

    public void Start()
    {
        SetGameObjects();
    }

    private void SetGameObjects()
    {
        Lever1.SetActive(_active);
        Lever2.SetActive(_active);
        Lever3.SetActive(_active);
        Lever4.SetActive(_active);
    }
    public void Toggle()
    {
        _active = !_active;
        SetGameObjects();
    }
}
