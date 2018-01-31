using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour {

    public GameObject inventoryPanel;
    public GameObject[] inventoryIcons;
    public GameObject boltCutters;
    public int tcount;

    //Collision between player and game object
    void OnCollisionStay(Collision collision)
    {
        {
            if (Input.GetMouseButtonDown(0))
            {
                //look through children for exisiting icon
                foreach (Transform child in inventoryPanel.transform)
                {
                    //Check if item already in inventory is the same as item player is collide with
                    if (child.gameObject.tag == collision.gameObject.tag)
                    {
                        //locate the text located with the object
                        string c = child.Find("Text").GetComponent<Text>().text;
                        //convert text to int and add 1
                        tcount = System.Int32.Parse(c) + 1;
                        //return the int back into text to display
                        child.Find("Text").GetComponent<Text>().text = "" + tcount;
                        return;
                    }
                }

                //If the object doesnt exist instansiate the object on collision into the inventory
                
                if (collision.gameObject.tag == "Bolt Cutter")
                {
                    boltCutters = Instantiate(inventoryIcons[0]);
                    boltCutters.transform.SetParent(inventoryPanel.transform);
                }

                else if (collision.gameObject.tag == "ANother object")
                {
                    //i = Instantiate(inventoryIcons[1]);
                   // i.transform.SetParent(inventoryPanel.transform);
                }
            }
        }
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

    }
}
