using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KickTheMimi : MonoBehaviour
{
    // Reference to the Animator component so we can trigger animations
    private Animator animator;

    // Health bar UI Image (the filled portion)
    public Image healthBar;

    // Boolean to track if we should play the final smoke animation
    // (separate from the "death" animation to handle overlap)
    private bool playDeathSmoke;

    // A reference to the Mimi prefab (used to instantiate a new Mimi after death)
    public GameObject mimi;

    // Start is called before the first frame update
    void Start()
    {
        // Grab the Animator component from the same GameObject
        animator = GetComponent<Animator>();

        // Make sure Mimi starts at full health
        healthBar.fillAmount = 1;

        // Initially, we don't want to play the final smoke animation
        playDeathSmoke = false;

        // Default Attack state is set to 0 (usually "Idle")
        animator.SetInteger("Attack", 0);
    }

    // Update is called once per frame
    void Update()
    {
        // If Mimi's health hits zero, check which animation to play
        if (healthBar.fillAmount <= 0)
        {
            // If playDeathSmoke hasn't been triggered yet, use the standard death animation
            if (!playDeathSmoke)
            {
                // Attack value of 10 presumably corresponds to "Death" animation
                animator.SetInteger("Attack", 10);
                // Debug.Log("Death by mimi"); // left commented out, can enable for debugging
            }
            // If health is still 0 but we need to trigger the final smoke
            else if (playDeathSmoke)
            {
                // Attack value of 11 presumably corresponds to "Smoke" animation
                animator.SetInteger("Attack", 11);
            }
        }
    }

    // Called externally (e.g., when the player clicks or interacts) to make Mimi perform an Attack animation
    public void HitMimi()
    {
        // Attack value of 1 presumably corresponds to some kind of "Hit" or "Attack" animation
        animator.SetInteger("Attack", 1);
    }

    // Deals damage to Mimi by decreasing fillAmount
    public void DoDamage()
    {
        // Subtract 0.1f from the health bar
        healthBar.fillAmount -= 0.1f;
    }

    // Resets Mimi back to an idle state
    public void ResetMimi()
    {
        // Attack value of 0 presumably corresponds to "Idle"
        animator.SetInteger("Attack", 0);
    }

    // Another attack variant (maybe a shooting action?)
    public void ShootKill()
    {
        // Attack value of 2 presumably corresponds to "Shoot" animation
        animator.SetInteger("Attack", 2);
    }

    // Another attack variant (maybe a slashing action?)
    public void SlashMimi()
    {
        // Attack value of 3 presumably corresponds to "Slash" animation
        animator.SetInteger("Attack", 3);
    }

    // Triggers the final death smoke animation
    public void deathMimi()
    {
        // Flag that we should now start playing the smoke animation
        playDeathSmoke = true;
        // Trigger the smoke animation
        animator.SetInteger("Attack", 11);
    }

    // After the full death process finishes, destroy this Mimi
    // and create a brand new one (instantiating from the Mimi prefab)
    public void NewMimi()
    {
        // Spawn a fresh Mimi into the scene
        Instantiate(mimi);
    }

    // Another comedic or alternative attack variant
    public void bonkMimi()
    {
        // Attack value of 4 presumably corresponds to a "Bonk" animation
        animator.SetInteger("Attack", 4);
    }

    // Clean up the current Mimi when we’re done
    public void destoryMIMI()
    {
        // Destroy this Mimi GameObject
        // (once the animations or logic have fully completed)
        Destroy(this.gameObject);
    }
}
