using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZukoAnimations : MonoBehaviour
{

    // Animation
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Animation
        if (Input.GetKey(KeyCode.W))
        {
            //animator.SetFloat("Speed", 1);
            animator.SetTrigger("Walk");
        } else
        {
            //animator.SetFloat("Speed", 0);
            animator.SetTrigger("Idle");
        }
    }
}
