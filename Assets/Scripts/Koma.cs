using System.Collections;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class Koma : MonoBehaviour {

	Rigidbody rigidBody;
	public Vector3 force = new Vector3 (0, 10, 0);
	public ForceMode forceMode = ForceMode.VelocityChange;
	// private int movementRange;

	// Use this for initialization
	void Start () { }
	public void OnUserAction () {
		Vector2 pos = GetComponent<RectTransform> ().anchoredPosition;
		pos.y += -220;
		GetComponent<RectTransform> ().anchoredPosition = pos;

	}

	public void Search (string[, ] potision) {
		Debug.Log (potision);
	}
}