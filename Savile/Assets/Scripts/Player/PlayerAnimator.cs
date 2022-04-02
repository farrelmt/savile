using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;

    int hashIsWalk;
    int hashIsRun;
    int hashIsInteract;


    void Start()
    {
        animator = GetComponent<Animator>();

        hashIsWalk = Animator.StringToHash("isWalking");
        hashIsRun = Animator.StringToHash("isRunning");
        hashIsInteract = Animator.StringToHash("isInteracting");
    }



    public void SetWalkAnimation(bool state)
    {
        animator.SetBool(hashIsWalk, state);
    }

    public void SetRunAnimation(bool state)
    {
        animator.SetBool(hashIsRun, state);
    }

    public void SetInteractAnimation(bool state)
    {
        animator.SetBool(hashIsInteract, state);
    }
}
