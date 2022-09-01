using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placement : MonoBehaviour
{
    Camera sideCamera;
    Vector2 firsPosition;
    GameObject[] boxArray;
   
    public Button jokerButton;

    //Level Control 

   Finish Finish;


    public void xyz()
    {
       foreach (GameObject box in boxArray)
        {
           
            if (box.name == gameObject.name)
            {
               
                transform.position = box.transform.position;
              
            }
           
        }
       
    }
   
    private void OnMouseDrag()
    {
        Vector3 pozisyon = sideCamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;


    }



    void Start()
    {
        sideCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        firsPosition = transform.position;
        boxArray = GameObject.FindGameObjectsWithTag("Box");
        Finish = GameObject.Find("GameManager").GetComponent<Finish>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject Box in boxArray)
            {
                if (Box.name == gameObject.name)
                {
                    float mesafe = Vector3.Distance(Box.transform.position, transform.position);
                    {
                        if (mesafe <= 1)
                        {
                            transform.position = Box.transform.position;

                            this.enabled = false;
                            Destroy(this);
                            Finish.LevelTurkeyFinish();

                        }
                        else
                        {
                            transform.position = firsPosition;
                        }
                    }
                }
            }
        }
    }
}
