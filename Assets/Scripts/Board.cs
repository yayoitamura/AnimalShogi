using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

	string[, ] board = new string[3, 4];

	// Use this for initialization
	void Start () {
		board[1, 2] = "hiyoko";
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnUserAction (CubeControl koma) {
		koma.OnUserAction ();
		// Vector2 pos = GetComponent<RectTransform> ().anchoredPosition;
		// pos.y += -220;
		// GetComponent<RectTransform> ().anchoredPosition = pos;

	}
}