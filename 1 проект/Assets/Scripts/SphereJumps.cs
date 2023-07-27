using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereJumps : MonoBehaviour
{
    public Rigidbody SphereRb;
    public float SphereJumpForse = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            SphereRb.AddForce(0, SphereJumpForse, 0);
        }
    }

}
