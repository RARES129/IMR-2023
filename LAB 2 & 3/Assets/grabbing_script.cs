using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabbing_script : MonoBehaviour
{
    private Animator HandAnimator;
    // Start is called before the first frame update
    void Start()
    {
        HandAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("g"))
        {
            HandAnimator.SetBool("grabbed", true);
        }
        else
            HandAnimator.SetBool("grabbed", false);
    }
}
