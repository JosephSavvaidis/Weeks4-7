using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewSlide : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; 
    public Slider colorSlider;
    private void Start()
    {
        
    }
     void Update()
    {
        Debug.Log(colorSlider.value);
        spriteRenderer.material.color = new Color(colorSlider.value * 2f, colorSlider.value * 2f, colorSlider.value * 2f, 1f);
    }
    
}
