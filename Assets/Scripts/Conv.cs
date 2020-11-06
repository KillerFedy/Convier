using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conv : MonoBehaviour
{
    void OnCollisionStay(Collision collision)
    {
        collision.gameObject.transform.position += transform.forward * Time.deltaTime;
    }
}
