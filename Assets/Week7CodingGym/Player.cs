using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
    float jumpForce;
    public bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        jumpForce = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pos.y += 0.1f;
            
        }

        if (pos.y >= 0.1f)
        {
            grounded = false;
        }
        else
        {
            grounded = true;
            pos.y = 0;
        }

        if (!grounded)
        {
            pos.y += jumpForce * Time.deltaTime;
            jumpForce -= 20f * Time.deltaTime;
        }
        else
        {
            jumpForce = 10;
        }

        transform.position = pos;
    }


}
