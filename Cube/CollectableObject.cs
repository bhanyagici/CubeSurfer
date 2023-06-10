using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    bool isCollect;
    float index;
    // Start is called before the first frame update
    void Start()
    {
        isCollect = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetIsCollect()
    {
        return isCollect; ;
    }

    public void DoCollect()
    {
        isCollect = true;
    }

    public void SetIndex(float index)
    {
        this.index = index; 
    }


}
