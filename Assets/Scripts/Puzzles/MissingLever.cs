using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingLever : MonoBehaviour
{
    public GameObject disabledLever;
    public GameObject lostLever;

    void Start()
    {
        //Disable the lever handle on the lever game object
        disabledLever.SetActive(false);
    }

    void OnTriggerEnter(Collider collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.tag == "Lost_Lever")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");

            //Destory the missing lever object, and activate the disabled game object
            Destroy(lostLever);
            disabledLever.SetActive(true);
        }
    }
}
