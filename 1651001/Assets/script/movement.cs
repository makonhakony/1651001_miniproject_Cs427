using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 20.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (!Input.GetButton("Jump"))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Animator>().SetTrigger("walk");
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
                GetComponent<SpriteRenderer>().flipX = true;
                
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Animator>().SetTrigger("walk");
                GetComponent<Rigidbody2D>().AddForce(new Vector2(+speed, 0));
                GetComponent<SpriteRenderer>().flipX = false;
                
            }
             
        }
        
    }
}
