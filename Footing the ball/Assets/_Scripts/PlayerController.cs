using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float jumpForce = 10f;
    public float forwardForce = 2f;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            rb.AddForce(Vector2.right * forwardForce, ForceMode2D.Impulse);
        }
    }
}