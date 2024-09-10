using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class playerController : MonoBehaviour
{
    public KeyCode left, right;
    public float speed;

    private Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            rb2D.AddForce(Vector2.left * speed);
        }
        if (Input.GetKey(right))
        {
            rb2D.AddForce(Vector2.right * speed);
        }
    }
}

