using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public string type;
    public GameObject spawnerObj;
    
    private float nextActionTime = 0.0f;
    public float period = 2.0f;

    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime = Time.time + period;

            Instantiate(spawnerObj,
                new Vector3(gameObject.GetComponent<Transform>().position.x + 1.0f, 1.0f,
                    gameObject.GetComponent<Transform>().position.z), Quaternion.identity);
            Instantiate(spawnerObj,
                new Vector3(gameObject.GetComponent<Transform>().position.x - 1.0f, 1.0f,
                    gameObject.GetComponent<Transform>().position.z), Quaternion.identity);
            Instantiate(spawnerObj,
                new Vector3(gameObject.GetComponent<Transform>().position.x, 1.0f,
                    gameObject.GetComponent<Transform>().position.z + 1.0f), Quaternion.identity);
            Instantiate(spawnerObj,
                new Vector3(gameObject.GetComponent<Transform>().position.x, 1.0f,
                    gameObject.GetComponent<Transform>().position.z - 1.0f), Quaternion.identity);
        }
    }
}
