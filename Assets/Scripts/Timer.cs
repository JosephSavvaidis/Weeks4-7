using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Slider griddySlide;
    float t;
    // Start is called before the first frame update
    void Start()
    {
        griddySlide = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        griddySlide.value = t % griddySlide.maxValue;
        //if (t == 1) {
         //   t = 0;
       // }
    }
}
