using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Player;
    [SerializeField] private float JumpForce;

    private float moveInput;
    [SerializeField] private float Speed;


    void Start()
    {
        Player = GetComponent<Rigidbody2D>();    
    }
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        Player.velocity = new Vector2(moveInput * Speed, Player.velocity.y);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Player.velocity = new Vector2(Player.velocity.x, JumpForce);
           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        { Time.timeScale = 0.9f; }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Time.timeScale = 1f;
    }
}
