using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    Rigidbody2D rigid;
    bool portalUse1 = false;
    bool portalUse2 = false;
    bool portalUse3 = false;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {     
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(portalUse1)
            {
                transform.position = new Vector3(20.17f,  -3.3f, transform.position.z);
            }
            if(portalUse2)
            {
                transform.position = new Vector3(47.3f,  -2.6f, transform.position.z);
            }
            if(portalUse3)
            {
                transform.position = new Vector3(79.94f,  transform.position.y, transform.position.z);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Portal1")
        {
            portalUse1 = true;
        }

        if(other.gameObject.tag == "Portal2")
        {
            portalUse2 = true;
        }

        if(other.gameObject.tag == "Portal3")
        {
            portalUse3 = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Portal1")
            portalUse1 = false;            
        if(other.gameObject.tag == "Portal2")
            portalUse2 = false;
        if(other.gameObject.tag == "Portal3")
            portalUse3 = false;
    }
}
