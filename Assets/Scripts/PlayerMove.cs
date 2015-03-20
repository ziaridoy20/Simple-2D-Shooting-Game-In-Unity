using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	public float moveSpeed = 5;
	private Vector3 moveVector;
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		moveVector = new Vector3(Input.GetAxisRaw ("Horizontal"),Input.GetAxisRaw("Vertical"),0);
		moveVector.Normalize();
		
		transform.Translate(moveVector*Time.deltaTime*moveSpeed,Space.World);
		
	}
	
}