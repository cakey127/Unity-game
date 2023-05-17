using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRocket : MonoBehaviour
{
    public GameObject RocketPrefab;
    public float propulsionForce;
    public float fireDelay = 0.8f;

    private float m_lastFiredTime;
    private Transform myTransform;


    void Start()
    {
        SetInitialReferences();
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if (!(m_lastFiredTime + fireDelay < Time.time)) return;
            m_lastFiredTime = Time.time;
            SpawnRocket();
        }
    }

    void SpawnRocket()
    {
        GameObject Rocket = (GameObject) Instantiate(RocketPrefab, myTransform.transform.TransformPoint(0, -0.6f, 0f), myTransform.rotation);
        Rocket.GetComponent<Rigidbody>().AddForce(myTransform.forward * propulsionForce, ForceMode.Impulse);
        Destroy(Rocket, 20);
    }

    void SetInitialReferences()
    {
        myTransform = transform;
    }
}
