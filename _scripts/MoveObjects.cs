using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour {

	public GameObject items;
	public GameObject tempParent;
	public Transform guide;

	// Use this for initialization
	void Start () {
		items.GetComponent<Rigidbody> ().useGravity = true;
	}


	void OnMouseDown()
	{
	
		items.GetComponent<Rigidbody> ().useGravity = false;
		items.GetComponent<Rigidbody> ().isKinematic = true;
		items.transform.position = guide.transform.position;
		items.transform.rotation = guide.transform.rotation;
		items.transform.parent = tempParent.transform;
	}

	void OnMouseUp()
	{
		items.GetComponent<Rigidbody> ().useGravity = true;
		items.GetComponent<Rigidbody> ().isKinematic = false;
		items.transform.parent = null;
		items.transform.position = guide.transform.position;

	}
}
