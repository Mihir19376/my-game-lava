using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float jumpForce;
    public float moveRightOrLeftForce;
    bool isOnGround = false;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * moveRightOrLeftForce);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * moveRightOrLeftForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Setting"))
        {
            //if (isOnGround == false)
            //{
            //    isOnGround = true;
            //}

            isOnGround = true;
        }
    }
}
