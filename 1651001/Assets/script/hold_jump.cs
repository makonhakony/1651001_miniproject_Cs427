using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hold_jump : MonoBehaviour
{
    public float highspeed = 2.5f;
    public float lowspeed = 2f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (highspeed - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y >0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowspeed - 1) * Time.deltaTime;
        }
    }
}
