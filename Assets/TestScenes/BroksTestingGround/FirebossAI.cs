using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirebossAI : MonoBehaviour
{

    private int rand;

     public void OnStateEnter(Animator animator, AnimatorStateInfo stateinfo, int layerIndex)
    {
        rand = Random.Range(0, 4);

        if (rand == 0)
        {
            animator.SetTrigger("idle");
        }
        else
        {
            animator.SetTrigger("jump");
        }
    }

     public void OnStateUpdate(Animator animator, AnimatorStateInfo stateinfo, int layerIndex)
    {

    }

     public void OnstateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
