using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalValue;

    public float HorizontalValue
    {
        get { return horizontalValue; }
    }

    

    // Update is called once per frame
    void Update()
    {
        HandlePlayerHorizontalInput();
    }



    private void HandlePlayerHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            //Yatay da olan sürükleme iþlemi
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            //Sürükleme býrakýldýðý zaman horizontalValue'muz sýfýr olsun
            horizontalValue = 0;
        }
    }




}
