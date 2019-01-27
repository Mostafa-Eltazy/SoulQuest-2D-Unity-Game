using UnityEngine;
using System.Collections;

public class MovingObjects : MonoBehaviour {

    public GameObject ObjectToMove;
    public bool isFacingRight = true;
    public Transform startpoint;
    public Transform endpoint;
    public float movespeed;
    public Vector3 currenttarget;

    // Use this for initialization
    void Start()
    {

        currenttarget = endpoint.position;
    }

    // Update is called once per frame
    void Update()
    {


        ObjectToMove.transform.position = Vector3.MoveTowards(ObjectToMove.transform.position, currenttarget, movespeed * Time.deltaTime);

        if (ObjectToMove.transform.position == endpoint.position)
        {

            currenttarget = startpoint.position;
            flip();
        }

        if (ObjectToMove.transform.position == startpoint.position)
        {

            currenttarget = endpoint.position;
            flip();
        }
        

    }
    public void flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
}
