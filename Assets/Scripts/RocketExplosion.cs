using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketExplosion : MonoBehaviour
{
    public float blastRadius;
    public float explosionForce;
    public LayerMask explosionLayers;

    private Collider[] hitColliders;


    void OnCollisionEnter(Collision col)
    {
        //Debug.Log(col.contacts[0].point.ToString());
        DoExplosion(col.contacts[0].point);
        Destroy(gameObject);
    }


    void DoExplosion(Vector3 explosionPoint)
    {
        hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius, explosionLayers);

        foreach(Collider hitcol in hitColliders)
        {
            //Debug.Log(hitcol.gameObject.name);
            if(hitcol.GetComponent<Rigidbody>() != null)
            {
                hitcol.GetComponent<Rigidbody>().isKinematic = false;
                hitcol.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, explosionPoint, blastRadius, 0.5f, ForceMode.VelocityChange);
            }
        }
    }
}
 