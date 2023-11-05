using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollower : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Start()
    {
        offset = player.position - transform.position;
    }
    void FixedUpdate()
    {
        transform.position = player.position - offset;
    }
}
