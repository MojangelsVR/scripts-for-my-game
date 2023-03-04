using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableVisualMouse : MonoBehaviour
{
public GameObject Mouse;
    // Start is called before the first frame update
    void Start()
    {
        Mouse.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
