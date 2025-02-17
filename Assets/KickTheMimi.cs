using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickTheMimi : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this piece of code sets the mimi's animation to attack 1 if he gets clicked by the player
    public void HitMimi() {
        animator.SetInteger("Attack", 1);
    }
    //this peice of code resets the mimi's attack animation so that he goes back to idle
    public void ResetMimi()
    {
        animator.SetInteger("Attack", 0);
    }
}
