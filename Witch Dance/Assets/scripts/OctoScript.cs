using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OctoScript : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
    public Transform groundCheck;
    public LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        rb.velocity = new Vector2(speed, 0);
        bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, ground);
        if (!isGrounded)
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            speed *= -2;
        }
    }

    
}
