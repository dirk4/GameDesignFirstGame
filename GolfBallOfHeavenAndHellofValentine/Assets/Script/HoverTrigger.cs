using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTrigger : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Rigidbody>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0,15,0));
        }
    }
}
