using UnityEngine;
using System.Collections;

public class levelManager : MonoBehaviour {
    
    public GameObject currentCheckPoint;
    public Transform Enemy;
    public Transform Enemy_Respawn;

	// Use this for initialization
	void Start () {
        currentCheckPoint.transform.position = FindObjectOfType<Mainplayer>().transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void RespawnPlayer()
    {
        FindObjectOfType<Mainplayer>().transform.position = currentCheckPoint.transform.position;
    }
    public void RespawnEnemy()
    {
        Instantiate(Enemy_Respawn, transform.position, transform.rotation);
    }
}
