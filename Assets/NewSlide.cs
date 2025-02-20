using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewSlide : MonoBehaviour
{
    // This is the SpriteRenderer I want to recolo
    public SpriteRenderer spriteRenderer;

    // This is the UI Slider I’m reading thvalue from
    public Slider colorSlider;

    // In Update, I’ll read the slider’s value andapply it to the sprite’s color.
    private void Update()
    {
        // Logging the current slider value for reference.
        Debug.Log(colorSlider.value);

        // Multiplying the slider value by 2 to range from 0 (black) up to 2 (very bright white).
        spriteRenderer.material.color = new Color(
            colorSlider.value * 2f,
            colorSlider.value * 2f,
            colorSlider.value * 2f,
            1f
        );
    }

}
