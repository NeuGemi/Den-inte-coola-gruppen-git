using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Vector2 jumpHeight;
    private Rigidbody2D rb;
    public bool hasJumped;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Kallar hit spelaren
    }

    void Update()
    {
        //Får Spelaren att röra på sig
        float Horz = Input.GetAxis("Horizontal");

        //Fixar hastigheten 
        rb.velocity = new Vector2(Horz * 1000 * Time.deltaTime, rb.velocity.y);

        //Får Spelaren att hoppa
        if (Input.GetKeyDown(KeyCode.Space) && hasJumped == false)
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
            hasJumped = true;
        }
    }

    //Checkar om man är på marken igen efter att ha hoppat. Ändrar då hasJumped till false igen
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasJumped == true)
        {
            hasJumped = false;
        }
    }
}
