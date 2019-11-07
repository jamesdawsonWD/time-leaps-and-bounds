using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionController : MonoBehaviour
{
    public TimeLeap    TL;
    private bool       AtPresentTime; 
    // Start is called before the first frame update
    void Start()
    {
        AtPresentTime = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (AtPresentTime)
            {
                TL.leapTime(TimeLeap.TimePlane.PAST);
            }
            else
            {
                TL.leapTime(TimeLeap.TimePlane.PRESENT);
            }
            AtPresentTime = !AtPresentTime;
        }
    }
}
