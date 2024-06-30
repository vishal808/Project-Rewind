using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
	    private Camera mainCam;
		public Transform point;
		bool pickedup = false;
    // Start is called before the first frame update
    void Start()
    {
         mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
		if( Input.GetKeyDown("e"))
		{
			PickUpCube();
		}
		
		
    }
	void PickUpCube()
	{
		RaycastHit hit;

        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit)) {

            if(hit.transform.tag == "Cube")
			{
				float dis = Vector3.Distance(hit.transform.position,transform.position);
				if(dis <5f&&!pickedup)
				{
					pickedup = true;
					hit.transform.GetComponent<Rigidbody>().useGravity = false;
					hit.transform.GetComponent<Rigidbody>().isKinematic = true;
					
					hit.transform.parent = point;
					hit.transform.position = point.position;
;
					
					
				}
				else
				{
					pickedup = false;
					hit.transform.GetComponent<Rigidbody>().useGravity = true;
							hit.transform.GetComponent<Rigidbody>().isKinematic = false;
					hit.transform.parent = null;
					
				}
			}
        }
	}
}
