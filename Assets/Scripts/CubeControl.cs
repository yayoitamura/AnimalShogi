using System.Collections;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class CubeControl : MonoBehaviour {

	Rigidbody rigidBody;
	public Vector3 force = new Vector3 (0, 10, 0);
	public ForceMode forceMode = ForceMode.VelocityChange;

	// Use this for initialization
	void Start () {
		rigidBody = gameObject.GetComponent<Rigidbody> ();

	}
	public void OnUserAction () {
		// rigidBody.AddForce (force, forceMode);

		Vector2 vec = new Vector2 (100, 200);
		transform.position = GodTouch.GetPosition ();

	}
}