using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    bool isCollect;
    float index;
    public CollectController collecter;
    // Start is called before the first frame update
    void Start()
    {
        isCollect = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollect == true )
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
          
            collecter.DecreaseVertical();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

            
        }
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
