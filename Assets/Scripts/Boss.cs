using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
    {

	// Use this for initialization
	public bool bossActive;
	public float dropstimer;
	private float dropcount;
	public GameObject lord;

	
	public Transform leftpoint;
	public Transform rightpoint;
	public Transform drop;

    public GameObject item; 



	void Start () {

		dropcount = dropstimer;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (bossActive)
        {
            
            if (dropcount > 0)
            {
                dropcount -= Time.deltaTime;
            }
            else
            {
                drop.position = new Vector3(Random.Range(leftpoint.position.x, rightpoint.position.x), drop.position.y, 0f);
                Instantiate(item, drop.position, drop.rotation);
                dropcount = dropstimer;
            }
        }

    }

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "player") {
			bossActive = true;
		}
	}
}
