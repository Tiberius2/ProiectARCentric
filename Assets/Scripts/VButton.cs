using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VButton : MonoBehaviour
{
    public GameObject cube;
    public VirtualButtonBehaviour Vb;

   void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        cube.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
    }
}
