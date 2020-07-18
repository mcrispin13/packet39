using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyIgnition : MonoBehaviour
{
    // Start is called before the first frame update
    private bool _active = false;
    public DialInteractable Lever1;
    public DialInteractable Lever2;
    public DialInteractable Lever3;
    public DialInteractable Lever4;

    public void Start()
    {
        SetGameObjects();
    }

    private void SetGameObjects()
    {
        Lever1.gameObject.SetActive(_active);
        Lever2.gameObject.SetActive(_active);
        Lever3.gameObject.SetActive(_active);
        Lever4.gameObject.SetActive(_active);
    }
    public void Toggle()
    {
        _active = !_active;
        SetGameObjects();
    }
}
