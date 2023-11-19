using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkAnimator : MonoBehaviour
{
    public Transform trackedObject1;
    private Animator anim1;
    // Start is called before the first frame update
    void Start()
    {
        anim1 = trackedObject1.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (anim1 != null)
                anim1.SetBool("isReacting", true);
        }
    }
}
