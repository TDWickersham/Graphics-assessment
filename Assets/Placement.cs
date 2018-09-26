using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour {

    public GameObject placer;
    public Camera myCam;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update ()
    {
        float mouseRatioX = Input.mousePosition.x / Screen.width;
        float mouseRatioY = Input.mousePosition.y / Screen.height;

        Ray ray = myCam.ViewportPointToRay(new Vector3(mouseRatioX, mouseRatioY));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 targetDir = hit.point - transform.position;
            if (Input.GetMouseButtonDown(1))
            {
                SpawnObject(hit.point);
            }
        }

	}

    void SpawnObject(Vector3 pos)
    {
        GameObject Placed = Instantiate(placer);
        Placed.transform.position = pos;
    }
}
