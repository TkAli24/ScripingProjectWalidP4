using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int cupsInTheShink = 4;
    // Start is called before the first frame update
    void Start()
    {
        while(cupsInTheShink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheShink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
