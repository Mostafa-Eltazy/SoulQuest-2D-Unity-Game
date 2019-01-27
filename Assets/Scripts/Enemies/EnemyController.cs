using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public bool isFacingRight = true;
    public float MaxSpeed;
    public int Damage;
    public int Health;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
           FindObjectOfType<PlayerStats>().takeDamage(Damage);
        }

    }

    public void TakingDamage(int Damage)
    {
        Health -= Damage;
    }
}
