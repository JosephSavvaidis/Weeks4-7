using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{

    public SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (getHit(pos))
        {
            SceneManager.LoadScene(0);
        }
    }

    bool getHit(Vector2 pos)
    {
        return rend.bounds.Contains(pos);
    }
}
