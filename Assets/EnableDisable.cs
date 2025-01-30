using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public SpriteRenderer sr;
    public EnableDisable script;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            //sr.enabled = false;
            //script.enabled = false;
            go.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            //sr.enabled = true;
            //script.enabled = true;
            go.SetActive(false);
        }
    }
}
