using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Player;
    [SerializeField] private float JumpForce;
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Player.velocity = new Vector2(Player.velocity.x, JumpForce);
        }
    }
}
