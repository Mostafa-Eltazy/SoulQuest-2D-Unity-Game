using UnityEngine;
using System.Collections;

public class Collectibles : MonoBehaviour {

    private PlayerStats player;

	void Start () {
        
       player=FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            if (this.tag == "gem")
                player.gemsCollected++;
            else if (this.tag == "wood")
                player.woodCollected++;
            else if (this.tag == "light")
                player.lightCollected++;
            else if (this.tag == "potion")
            {
                if (player.health >= 75)
                {
                    player.health = 100;
                }
                else
                {
                    player.health += 25;
                }
            }
            Destroy(this.gameObject);
        }
    }
}
