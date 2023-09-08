using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{

    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ShootAnim(string trigger)
    {
        animator.SetTrigger(trigger);
    }
}
