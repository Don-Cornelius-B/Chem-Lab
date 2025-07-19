using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class animationScriptController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardpress = Input.GetKey("w"); 
        bool runpress = Input.GetKey("left shift");
        bool isWalking = animator.GetBool("isWalkingHash");
        bool isRunning = animator.GetBool("isRunningHash");

        if (!isWalking && forwardpress){
            animator.SetBool(isWalkingHash,true);
        }
        if (isWalking && !forwardpress){
            animator.SetBool(isWalkingHash,false);
        }
        if (!isRunning && forwardpress && runpress){
            animator.SetBool(isRunningHash,true);
        }
        if (isRunning && !forwardpress || !runpress){
            animator.SetBool(isRunningHash,false);
        }
    }
}
