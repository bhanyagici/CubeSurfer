using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectController : MonoBehaviour
{
    GameObject mainCube;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        mainCube = GameObject.Find("MainCube");
       
        vertical = mainCube.transform.position.y+1;
        
    }

    // Update is called once per frame
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x,vertical+1,transform.position.z);
        this.transform.localPosition = new Vector3(0, -vertical, 0);
    }



    public void DecreaseVertical()
    {
        vertical--;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable" && other.gameObject.GetComponent<CollectableObject>().GetIsCollect() == false)
        {
            
            vertical += 1f;
            other.gameObject.GetComponent<CollectableObject>().DoCollect();
            other.gameObject.GetComponent<CollectableObject>().SetIndex(vertical);
            other.gameObject.transform.parent = mainCube.transform;
           
        }
    }

   


}
