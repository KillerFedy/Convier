using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock : MonoBehaviour
{
    void OnCollisionStay(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}

