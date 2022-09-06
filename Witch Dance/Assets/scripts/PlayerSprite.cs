using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    SpriteRenderer sprite;
    bool faceRight = true;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        FlipSprite();
        PlayerAnimations();
    }

    void FlipSprite()
    {
        if (Input.GetKeyDown(KeyCode.D) && faceRight == false)
        {
            sprite.flipX = false;
            faceRight = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && faceRight == true)
        {
            sprite.flipX = true;
            faceRight = false;
        }
    }

    void PlayerAnimations()
    {
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));


        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jump");
        }
    }
}
