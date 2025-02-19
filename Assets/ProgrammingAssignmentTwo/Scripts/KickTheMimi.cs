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

    //checks when to play the finakl smoke animnation becaus etehre is some overlap with  the deathanimation
    bool playDeathSmoke;

    public GameObject mimi;
    
    void Start()
    {
        //setting playdeathsmoke to false at the beggining of the game
        healthBar.fillAmount = 1;
        playDeathSmoke = false;
        animator.SetInteger("Attack", 0);
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
            else if (healthBar.fillAmount <= 0 && playDeathSmoke == true) {
                animator.SetInteger("Attack", 11);
            }
        }
    }
    //this piece of code sets the mimi's animation to attack 1 if he gets clicked by the player
    public void HitMimi() {
        animator.SetInteger("Attack", 1);
        
        
    }
    public void DoDamage() {
        healthBar.fillAmount -= 0.1f;
    }
    //this peice of code resets the mimi's attack animation so that he goes back to idle
    public void ResetMimi()
    {
        animator.SetInteger("Attack", 0);
    }
    public void ShootKill()
    {
        animator.SetInteger("Attack", 2);

    }
    public void SlashMimi() {
        animator.SetInteger("Attack", 3);
    }

    //plays death smoke animation
    
    public void deathMimi() {
        playDeathSmoke = true;
        animator.SetInteger("Attack", 11);
    }
    //destroys the mimi when whole death process is complete
    //creates new mimi whne the old one dies(instantiated from a prefab
    public void NewMimi() { 
    Instantiate(mimi);
    }

    public void bonkMimi() {
        animator.SetInteger("Attack", 4);
    }
    public void destoryMIMI() {
        
        //animator.SetInteger("Attack", 0);
        Destroy(this.gameObject);
    }
}
