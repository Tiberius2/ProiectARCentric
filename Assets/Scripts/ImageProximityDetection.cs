using System;
using UnityEngine;
using UnityEngine.Events;

public class ImageProximityDetection : MonoBehaviour
{
    public Transform trackedObject1; 
    public Transform trackedObject2; 

    public float proximityThreshold = 1f; 

    private Animator anim1; 
    private Animator anim2; 

    public event Action animationStart;
    public event Action animationEnd;

    public CanvasManager canvasManager;

    void Start()
    {
        anim1 = trackedObject1.GetComponent<Animator>();
        anim2 = trackedObject2.GetComponent<Animator>();
        canvasManager.Init(this);
    }

    void Update()
    {
            float distance = Vector3.Distance(trackedObject1.position, trackedObject2.position);
            /*Debug.Log(distance);*/

        if (distance < proximityThreshold)
        {
            if (anim1 != null && anim2 != null)
            {
                anim1.SetBool("isIdle", false);
                anim2.SetBool("isIdle", false);
                animationStart.Invoke();
            }

        }
        else
        {
            if (anim1 != null && anim2 != null)
            {
                anim1.SetBool("isIdle", true);
                anim2.SetBool("isIdle", true);
                animationEnd.Invoke();
            }
        }
    }
}
