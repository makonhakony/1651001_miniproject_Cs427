using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_jump : MonoBehaviour
{
    public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
            GetComponent<Animator>().SetTrigger("jump");
        }
    }
    //[SerializeField]

    //public static Rigidbody2D rb;
    //float holdTime;

    //// Use this for initialization
    //void Start()
    //{

    //    rb = GetComponent<Rigidbody2D>();
    //}

    //public void OnPointerDown()
    //{

    //    StartCoroutine("StartCounting");
    //}

    //public void OnPointerUp()
    //{
    //    StopCoroutine("StartCounting");

    //    if (holdTime < 0.3f)
    //        DoJump(300f);
    //    else
    //        DoJump(holdTime * 1000f);


    //}

    //IEnumerator StartCounting()
    //{
    //    for (holdTime = 0f; holdTime <= 1f; holdTime += Time.deltaTime)
    //    {

    //        yield return new WaitForSeconds(Time.deltaTime);
    //    }
    //    holdTime = 1f;

    //}
    //public static void DoJump(float jumpForce)
    //{
    //    rb.AddForce(Vector2.up * jumpForce);
    //}
}
