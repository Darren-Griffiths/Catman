using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainController : MonoBehaviour {

    public GameObject boltCutter;
    public GameObject inventory;
    int spawnNum = 1;

    void spawn()
    {
        for (int i = 0; i < spawnNum; i++)
        {
            Vector3 boltCutterPos = new Vector3(this.transform.position.x + Random.Range(-1.0f, 1.0f),
                                                this.transform.position.y + Random.Range(1.0f, 2.0f),
                                                this.transform.position.z + Random.Range(-1.0f, 1.0f));
            Instantiate(boltCutter, boltCutterPos, Quaternion.identity);
        }
    }

	// Use this for initialization
	void Start () {
        spawn();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.I))
        {

        }
	}
}
