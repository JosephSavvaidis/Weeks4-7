using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        transform.position = pos;

        if (transform.position.x > 5
            )
        {
            Debug.Log("gridystick");
            image.enabled = true;
        }
        else if (transform.position.x < 5) {
            image.enabled = false;
        }
    }
}
