using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 offset;
    private Vector3 newPosition;
    [SerializeField] private float lerpValue;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow() 
    {

        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, playerTransform.position.y, playerTransform.position.z) + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;

    }

    
        

}
