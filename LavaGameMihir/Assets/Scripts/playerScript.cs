using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float jumpForce;
    public float moveRightOrLeftForce;
    bool isOnGround = false;
    public int speed = 20;

    private int maxHealth = 1000;
    public int currentHealth;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isOnGround == true)
            {
                rb.AddForce(Vector2.up * jumpForce);
                isOnGround = false;
            }
        }

        else if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * moveRightOrLeftForce);
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * moveRightOrLeftForce);
        }


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            //if (isOnGround == false)
            //{
            //    isOnGround = true;
            //}

            isOnGround = true;
        }

        else if (collision.gameObject.CompareTag("obstacle"))
        {
            TakeDamage(1);
            isOnGround = true;
        }
    }


    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

}
