using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidplayer;
    private SpriteRenderer spriteplayer;
    private Animator anime;
    
    private float dirx = 0f;
    [SerializeField] private float movespeed = 7f;
    [SerializeField] private float jumpforce = 14f;
        
    private void Start()
    {
        rigidplayer = GetComponent<Rigidbody2D>();
        spriteplayer = GetComponent<SpriteRenderer>();
        anime = GetComponent<Animator>();
    }
    
    private void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        rigidplayer.velocity = new Vector2(dirx * movespeed,rigidplayer.velocity.y);
        
        if(Input.GetButtonDown("Jump"))
        {
            rigidplayer.velocity = new Vector3(rigidplayer.velocity.x,jumpforce);
        }

        animationupdate();
    }
    //This script for animation movements.
    private void animationupdate()
    {
        if (dirx > 0f)
        {
            anime.SetBool("running", true);
            spriteplayer.flipX = false;
        }

        else if (dirx < 0f)
        {
            anime.SetBool("running", true);
            spriteplayer.flipX = true;
        }

        else
        {
            anime.SetBool("running", false);
        }
    }
}
