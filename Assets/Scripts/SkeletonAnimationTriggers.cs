using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAnimationTriggers : MonoBehaviour
{
    private EnemySkeleton enemy;

    private void Start()
    {
        enemy = GetComponentInParent<EnemySkeleton>();
    }

    private void AnimationTrigger()
    {
        enemy.AnimationFinishTrigger();
    }
}
