using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAnimationScript : MonoBehaviour
{
    Animator m_animator;
    public float fireDelay = 0.8f;

    private float m_lastFiredTime;


    void Start()
    {
         m_animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if (!(m_lastFiredTime + fireDelay < Time.time)) return;
            m_lastFiredTime = Time.time;
            m_animator.SetTrigger("Shoot");
        }
    }
}
