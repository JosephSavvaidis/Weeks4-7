using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KickTheMimi : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    //get the gameobject for the healthbar
    public Image healthBar;

    bool playDeathSmoke;
    
    void Start()
    {
        playDeathSmoke = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (healthBar.fillAmount <= 0) {
            if (playDeathSmoke == false)
            {
                animator.SetInteger("Attack", 10);
                //Debug.Log("Death by mimi");
            }
            else if (playDeathSmoke == true) {
                animator.SetInteger("Attack", 11);
            }
        }
    }
    //this piece of code sets the mimi's animation to attack 1 if he gets clicked by the player
    public void HitMimi() {
        animator.SetInteger("Attack", 1);
        healthBar.fillAmount -= 0.1f;
        
    }
    //this peice of code resets the mimi's attack animation so that he goes back to idle
    public void ResetMimi()
    {
        animator.SetInteger("Attack", 0);
    }
    public void deathMimi() {
        playDeathSmoke = true;
        animator.SetInteger("Attack", 11);
    }
    public void destoryMIMI() { 
    Destroy(this.gameObject);
    }
}
