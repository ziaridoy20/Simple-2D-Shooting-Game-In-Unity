using UnityEngine;
using System.Collections;

public class PlayerLookAt : MonoBehaviour {
	
	private Vector3 mousePosition;
	private float rotationAngle;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		
		Vector3 dir = mousePosition - transform.position;
		float angle = (((Mathf.Atan2(dir.y, dir.x)) * Mathf.Rad2Deg)-90);
		transform.rotation = Quaternion.AngleAxis(angle, transform.forward);
		
	}
	
}