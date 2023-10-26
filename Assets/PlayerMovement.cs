using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidplayer;
    
    private void Start()
    {
        rigidplayer = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        float dirx = Input.GetAxisRaw("Horizontal");
        rigidplayer.velocity = new Vector2(dirx * 7f,rigidplayer.velocity.y);
        
        if(Input.GetButtonDown("Jump"))
        {
            rigidplayer.velocity = new Vector3(rigidplayer.velocity.x,14f);
        }
    }
}
