﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLeap : MonoBehaviour
{

    public enum TimePlane { PRESENT, PAST };
    public SpriteMask mask;
    private int playerLayer;
    private int bgLayer1;
    private int bgLayer2;

    void Start()
    {
        mask = gameObject.GetComponent<SpriteMask>();
        playerLayer = LayerMask.NameToLayer("Player");
        bgLayer1 = LayerMask.NameToLayer("Background1");
        bgLayer2 = LayerMask.NameToLayer("Background2");

    }


    /** Leap to a specific plane of time
     *  Disables / enables the sprite mask & changes the collision matrix 
     *  in relation to the player to ignore the different level Layes
     *  
     * @Param tp - the timeplane we want to leap to
    */

    public void leapTime(TimePlane tp)
    {
        switch (tp)
        {
            case TimePlane.PAST:
                displayMask();
                Physics2D.IgnoreLayerCollision(bgLayer2, playerLayer, false);
                Physics2D.IgnoreLayerCollision(bgLayer1, playerLayer, true);
                break;
            case TimePlane.PRESENT:
                hideMask();
                Physics2D.IgnoreLayerCollision(bgLayer1, playerLayer, false);
                Physics2D.IgnoreLayerCollision(bgLayer2, playerLayer, true);
                break;
        }
    }
    public void displayMask()
    {
        mask.enabled = true;
    }

    public void hideMask()
    {
        mask.enabled = false;
    }


}
