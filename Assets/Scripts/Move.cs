using UnityEngine;

public class Move : MonoBehaviour {

	public float speed = 2;
	Vector2 vec;

	Vector3 startPos;

	void Start () { }

	void Update () {

		// タッチを検出して動かす
		var phase = GodTouch.GetPhase ();
		if (phase == GodPhase.Began) {
			Debug.Log ("tap");
			// startPos = GodTouch.GetPosition ();
			// vec = Camera.main.ScreenToWorldPoint (startPos);
			//Debug.Log("x="+vec.x+" y="+vec.y); 
		}

		// transform.position = Vector2.MoveTowards (transform.position, new Vector2 (vec.x, vec.y), speed * Time.deltaTime);

	}
}