using UnityEngine;
using System.Collections;

public class playerAttack : MonoBehaviour {

    public bool attacking = false; //boolean to know whether the character is already attacking or not
    private float attackTimer = 0;  //timer to time the attack
    private float attackCD = 0.1f;  //value of attack Cooling down time 

    public KeyCode enter; //the key that will trigger the attack

    public Collider2D attackTrigger; //the collider that will be triggered when the attack starts so it affects the enemy
    private Animator anim; //to call the attack animation

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>(); //to initialize the animator
        attackTrigger.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if attack key is pressed and the character is not already in attacking then 
        //say it started attack by setting boolean to true, initiate the collider to allow it to hit the enemy
        //and give the time the value of cooling down so it cannot attack again at same time
        if (Input.GetKeyDown(enter) && !attacking)
        {
            attacking = true;
            attackTimer = attackCD;
            attackTrigger.enabled = true;
			FindObjectOfType<Mainplayer>().attackSound.Play();
        }
        //if the character is attacking then check the timer (that already has value of Cooling down)
        //if it is still running then decrement the current time from it by calling deltaTime
        //if the timer is already done then end the attack by setting its boolean to false and hiding the collider
        if (attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                attackTrigger.enabled = false;
            }
        }
        anim.SetBool("Attacking", attacking);
    }
}
