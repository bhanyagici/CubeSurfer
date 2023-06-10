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
    }

    // Update is called once per frame
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x,vertical,transform.position.z);
        this.transform.localPosition = new Vector3(0, -vertical, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect")
        {
            vertical += 0.6f;
            other.gameObject.GetComponent<CollectableObject>().DoCollect();
            other.gameObject.GetComponent<CollectableObject>().SetIndex(vertical);
            other.gameObject.transform.parent = mainCube.transform;

        }
    }
}
