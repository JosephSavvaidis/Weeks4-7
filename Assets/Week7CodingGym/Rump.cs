using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rump : MonoBehaviour
{

    bool playerUnderneath;
    public float speed;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        playerUnderneath = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (getHit(pos))
        {
            SceneManager.LoadScene(0);
        }

        if (player.transform.position.x >= pos.x - 2 && player.transform.position.x <= pos.x + 2)
        {
            playerUnderneath = true;
        }
        else
        {
            playerUnderneath = false;
        }

        if (playerUnderneath)
        {
            pos.y -= speed * Time.deltaTime;
        }
        else
        {
            pos.y += speed * Time.deltaTime;
        }

        if (pos.y <= -0.5)
        {
            pos.y = -0.5f;
        }
        
        if (pos.y >= 5)
        {
            pos.y = 5;
        }

        transform.position = pos;


    }

    bool getHit(Vector2 pos)
    {
        return player.GetComponent<SpriteRenderer>().bounds.Contains(pos);
    }
}
