using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Move : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
	/// イベントタイプ
	public enum EventType { None, Pressed, Click, Drag }

	/// クリック・ドラッグ判定距離
	public float CheckDistance = 30;
	/// 長押し判定時間
	public float CheckTime = 0.3f;

	/// イベントタイプ
	EventType type;
	/// イベント実行中かどうか
	bool isRunning;
	/// 押された時の開始ポジション
	Vector3 startPos;
	/// 押された時の開始時間
	float startTime;

	/// イベント実行中かどうか
	public bool IsRunning { get { return isRunning; } }

	/// イベントタイプ設定
	/// <param name="type">イベントタイプ</param>
	void SetType (EventType type) {
		this.type = type;
	}

	/// 押された
	/// <param name="e">PointerEventData</param>
	public void OnPointerDown (PointerEventData e) {
		isRunning = true;
		SetType (EventType.Pressed);
		startPos = GodTouch.GetPosition ();
		startTime = Time.time;
	}

	/// 更新処理
	void Update () {
		if (type == EventType.Pressed) {
			// 押されてる
			var pos = GodTouch.GetPosition ();
			var dx = Mathf.Abs (pos.x - startPos.x);
			var dy = Mathf.Abs (pos.y - startPos.y);
			var dt = Time.time - startTime;
			if (dx > CheckDistance || dy > CheckDistance) {
				// 一定距離動いていたらドラッグ実行
				SetType (EventType.Drag);
			}
		} else if (type == EventType.Drag) {
			// ドラッグ中(動かす)
			transform.position = GodTouch.GetPosition ();
		}
	}

	/// 離された
	/// <param name="e">PointerEventData</param>
	public void OnPointerUp (PointerEventData e) {
		if (type == EventType.Pressed) {
			// 他のイベントが未入力ならクリック実行
			SetType (EventType.Click);
		} else {
			// イベント初期化
			SetType (EventType.None);
		}
		isRunning = false;
	}
}