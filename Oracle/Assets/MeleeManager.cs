using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeManager : MonoBehaviour {

    public float range;
    public LayerMask myLayerMask;
    



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
		
	}

    void Attack()
    {
        RaycastHit hit;
       
        if(Physics.Raycast(transform.position, transform.forward, out hit, range, myLayerMask))
        {
          //  Target target = hit.transform.gameObject.GetComponent<Target>)();
            Debug.Log(hit.transform.name);
            
        }
        
    }
}
