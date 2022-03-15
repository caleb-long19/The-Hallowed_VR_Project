﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGrapple : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }
    }
}
