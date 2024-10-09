using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phys : MonoBehaviour
{
    Rigidbody rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //testzone();

    }

    // Update is called once per frame
    void Update()
    {

        //ClickTouch();
        testzone();
    }

    public void testzone()
    {
        /* //working, check if force is not in update methood, it will add contiues force.
        Vector3 abc = new Vector3(-1,0,0);
        float forcemagnitude = 2f; 
        rb.AddForce(abc*forcemagnitude, ForceMode.Impulse);
        */
        //no need to use damping force for now.
        //float dampingFactor = 0.01f;
        //rb.AddForce(-rb.velocity * dampingFactor);

        //aj dsk k kkdek l

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.gameObject.CompareTag("PEN"))
                {
                    Vector3 normal = hit.normal;
                    if (normal == Vector3.right || normal == Vector3.left || normal == Vector3.forward || normal == Vector3.back)
                    {
                        //Debug.Log("Hit the xyz side");
                        //Debug.Log(hit.point);
                        Vector3 abc = new Vector3(-1, 0, 0);
                        float forcemagnitude = 10f;
                        rb.AddForceAtPosition(abc * forcemagnitude,hit.point, ForceMode.Impulse);

                    }
                   // Debug.Log("Pen clicked!");
                }
            }

        }
    }

    public void ClickTouch()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.gameObject.CompareTag("PEN"))
                {            

                    Debug.Log("Pen clicked!");
                }
            }
        }
    }
}
