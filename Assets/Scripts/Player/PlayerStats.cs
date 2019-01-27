using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {
	
	public Slider healthBar;
	public Text livesNo;
	
	public int health = 100;
	public int lives = 3;
	public int attackPower = 20;
	
	public float flickerDuration = 0.1f;
	public float flickerTime = 0f;
	private SpriteRenderer spriteRenderer;
	
	public bool isImmune = false;
	public float immunityDuration = 1.5f;
	public float immunityTime = 0f;
	
	public int gemsCollected = 0;
	public int woodCollected = 0;
	public int lightCollected = 0;
	

	//public int[] colors;
	public int red;
	public int white;
	public int yellow;
	public int blue;
	
	// Use this for initialization
	void Start () {
		spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
		if(PlayerPrefs.HasKey("redpoints"))
		{
			red=PlayerPrefs.GetInt("redpoints");
		}else
		{
			red=0;
		}
		if(PlayerPrefs.HasKey("bluepoints"))
		{
			blue=PlayerPrefs.GetInt("bluepoints");
		}
		else
		{
			blue=0;
		}
		if(PlayerPrefs.HasKey("whitepoints"))
		{
			white=PlayerPrefs.GetInt("whitepoints");;
		}
		else
		{
			white=0;
		}
		if(PlayerPrefs.HasKey("yellowpoints"))
		{
			yellow=PlayerPrefs.GetInt("yellowpoints");;
		}
		else
		{
			yellow=0;
		}
		if(PlayerPrefs.HasKey("healthpoints"))
		{
			health=PlayerPrefs.GetInt("healthpoints");;
		}
		else
		{
			health=100;
		}
	
		if(PlayerPrefs.HasKey("lives"))
		{
			lives=PlayerPrefs.GetInt("lives");;
		}
		else
		{
			lives=3;
		}

}


	
	// Update is called once per frame
	void Update () {
		
		healthBar.value = health;
		livesNo.text = "" + lives;
		
		if (this.isImmune)
		{
			spriteFlicker();
			immunityTime += Time.deltaTime;
			if (immunityTime >= immunityDuration)
			{
				this.isImmune = false;
				this.spriteRenderer.enabled = true;
			}
		}
	}
	
	void spriteFlicker()
	{
		if (flickerTime < flickerDuration)
		{
			flickerTime += Time.deltaTime;
		}
		else if (flickerTime >= flickerDuration)
		{
			spriteRenderer.enabled = !(spriteRenderer.enabled);
			flickerTime = 0;
		}
	}
	
	public void takeDamage(int damage)
	{
		if (!this.isImmune)
		{
			this.health -= damage;
			this.isImmune = true;
			this.immunityTime = 0f;
		}
		if (this.health <= 0 && this.lives > 0)
		{
			FindObjectOfType<levelManager>().RespawnPlayer();
			this.health = 100;
			this.lives--;
		}
		else if (this.health <= 0 && this.lives == 0)
		{
			Destroy(this.gameObject);
		}
		FindObjectOfType<Mainplayer>().hitSound.Play();
	}
	
	public string FindMax()
	{
		int Max = -1;
		string color = "";
		if (red > Max) {
			Max = red;
			color="red";
		}
		if (yellow > Max) {
			Max = yellow;
			color="yellow";
		}
		if (blue > Max) {
			Max = blue;
			color="blue";
		}
		if (white > Max) {
			Max = white;
			color="white";
		}
		return color;
	}

}
