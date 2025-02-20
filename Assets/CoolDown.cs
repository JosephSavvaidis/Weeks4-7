using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolDown : MonoBehaviour
{
    // This float "t" represents the current timer value
    public float t;

    // Reference to an Image UI component (e.g., a health or timer bar)
    public Image bar;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the bar to be fully filled at the start
        bar.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Decrease "t" by the time elapsed since last frame
        t -= Time.deltaTime;

        // Map "t" directly to the fill amount of the bar (0 = empty, 1 = full)
        bar.fillAmount = t;

        // If the left mouse button is clicked, reset "t" (and thus the bar) back to full
        if (Input.GetMouseButtonDown(0))
        {
            t = 1;
        }
    }
}
