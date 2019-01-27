using UnityEngine;
using System.Collections;

public class WalkingEnemy : EnemyController
{

	private Rigidbody2D Walking_Enemy;
	
	//public Transform L_Point;
	//public Transform R_Point;
	
	private bool CamMove;
	public GameObject item;
	public AudioSource enemyWalk;
	private float walkCounter = 0;
	
	// Use this for initialization
	void Start()
	{
		Walking_Enemy = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Health <= 0)
		{
			Destroy(Walking_Enemy.gameObject);
			Instantiate(item,Walking_Enemy.transform.position,Walking_Enemy.transform.rotation);
		}
	}
	
	void FixedUpdate()
	{
		if (CamMove)
		{
			if (this.isFacingRight == true)
			{
				Walking_Enemy.GetComponent<Rigidbody2D>().velocity = new Vector2(MaxSpeed, Walking_Enemy.GetComponent<Rigidbody2D>().velocity.y);
				if(walkCounter==20)
				{
					enemyWalk.Play();
					walkCounter = 0;
				}
				else
				{
					walkCounter++;
				}
			}
			else
			{
				Walking_Enemy.GetComponent<Rigidbody2D>().velocity = new Vector2(-MaxSpeed, Walking_Enemy.GetComponent<Rigidbody2D>().velocity.y);
				if(walkCounter==20)
				{
					enemyWalk.Play();
					walkCounter = 0;
				}
				else
				{
					walkCounter++;
				}
			}
		}
	//	if (isFacingRight == true && transform.position.x > R_Point.position.x)
	//	{
	//		isFacingRight = false;
	//	}
	//	if (isFacingRight == false && transform.position.x < L_Point.position.x)
	//	{
	//		isFacingRight = true;
	//	}
	}
	
	void OnBecameVisible()
	{
		CamMove = true;
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "player")
		{
			FindObjectOfType<PlayerStats>().takeDamage(Damage);
			flip();
		}
		if (other.tag == "TurningPoint")
			flip();
		if (other.tag == "Enemy")
			flip();
	}
}
