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
            //Yatay da olan s�r�kleme i�lemi
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            //S�r�kleme b�rak�ld��� zaman horizontalValue'muz s�f�r olsun
            horizontalValue = 0;
        }
    }




}
