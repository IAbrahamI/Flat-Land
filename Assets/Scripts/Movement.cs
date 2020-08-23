using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    
    public float speed = 5f;
    public float jumpForce = 5f;
    public bool isGrounded = false;
    private bool facingRight = true;
    private int extraJumps;
    public int extraJumpsValue = 2;
    

    void Start()
    {
        extraJumps = extraJumpsValue;
    }

    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f);
        transform.position += movement * Time.deltaTime * speed;
        if (facingRight == false && Input.GetAxisRaw("Horizontal") > 0)
        {
            Flip();
        } else if (facingRight == true && Input.GetAxisRaw("Horizontal") < 0)
        {
            Flip();
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("LevelMenu");
        }
    }

    void Jump()
    {
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }
        if (Input.GetButtonDown("Jump") && extraJumps > 0)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
            extraJumps--;
        } else if (Input.GetButtonDown("Jump") && isGrounded.Equals(true) && extraJumps == 0)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
        }


    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector2 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
