﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirebossIdleBehavior : MonoBehaviour
{
    public float timer;
    public float minTime;
    public float maxTime;

     public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        timer = Random.Range(minTime, maxTime);
    }

     public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        if (timer <= 0)
        {
            animator.SetTrigger("jump");
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

     public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

    }
}
