using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvebentionAnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //I want the x position of my game object to appear on the connsole
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //I want know what my y location is at  all time
        //Debug.Log(transform.position.y);

        //I want the console to say someting if my objact is below 5
        if (transform.position.y <= 5f)
        {
            Debug.Log("I am about to hit the ground");
        }
    }
}
