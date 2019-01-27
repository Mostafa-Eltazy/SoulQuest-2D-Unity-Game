using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {

    public Sprite lightinigoff;
    public Sprite lightinigon;
    private SpriteRenderer therenderer;
    // Use this for initialization
    void Start()
    {

        therenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {

            therenderer.sprite = lightinigon;
            FindObjectOfType<levelManager>().currentCheckPoint = this.gameObject;
        }
    }
    void Update()
    {


    }
}
