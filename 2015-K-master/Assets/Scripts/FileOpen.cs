using UnityEngine;
using System.Collections;
using System.IO; //System.IO.FileInfo, System.IO.StreamReader, System.IO.StreamWriter
using System; //Exception
using System.Text; //Encoding

public class FileOpen : MonoBehaviour { 

	private string guitxt = "";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			ReadFile ();
		}
	}
	void OnGUI()
	{
		GUI.TextArea (new Rect (  190,400,850,  200), guitxt);
	}
	void ReadFile(){
		// FileReadTest.txtファイルを読み込む
		FileInfo fi = new FileInfo(Application.dataPath +   "/" + "test.txt");
		try {
			// 一行毎読み込み
			using (StreamReader sr = new StreamReader(fi.OpenRead(), Encoding.UTF8)){
				guitxt = sr.ReadToEnd();
			}
		} catch (Exception e){
			// 改行コード
			guitxt += SetDefaultText();
		}
	}
	string SetDefaultText(){
		return "C#あ\n";
	}
}
