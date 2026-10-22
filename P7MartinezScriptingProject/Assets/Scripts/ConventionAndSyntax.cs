using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This line is here tp tell me the x posiution of the object in the scene 
        Debug.Log(transform.position.x);

    }

    // Update is called once per frame
    void Update()
    {
        //This line is here tp tell me the x posiution of the object in the scene 
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");

        }

    }
}