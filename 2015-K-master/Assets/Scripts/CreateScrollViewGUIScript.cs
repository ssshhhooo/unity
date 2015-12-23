using UnityEngine;
using System.Collections;

public class CreateScrollViewGUIScript : MonoBehaviour {
	// GUIに使うSkin
	public GUISkin skin;
	
	// スクロールの現在位置
	public Vector2 scrollViewVector = Vector2.zero;
	// position : 表示位置
	public Rect scrollViewRect = new Rect(50, 50, 220, 200);
	// viewRect : スクロールビューの全体のRect範囲。position以上であれば、スクロールバーを操作して表示する 
	public Rect scrollViewAllRect = new Rect (40, 40, 100, 580);
	
	// GUIContent : text texture tooltip
	public GUIContent[] contents;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		// Skin代入
		GUI.skin=skin;
		
		// スクロールビューの開始位置を作成する
		scrollViewVector = GUI.BeginScrollView(scrollViewRect , scrollViewVector, scrollViewAllRect);
		
		// ボックスを作成
		GUI.Box (new Rect (50, 50, 200, 20), "Please select");
		
		// Button
		GUI.Button (new Rect (50,80,100,100), contents[0]);
		GUI.Button (new Rect (50,180,180,100), contents[1]);
		GUI.Button (new Rect (50,280,180,100), contents[2]);
		GUI.Button (new Rect (50,380,180,100), contents[3]);
		GUI.Button (new Rect (50,480,180,100), contents[4]);
		
		// スクロールビューの終了位置を作成する 
		GUI.EndScrollView();
	}
}