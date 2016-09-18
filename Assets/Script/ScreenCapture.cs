using UnityEngine;
using System.Collections;
using System;

public class ScreenCapture : MonoBehaviour {

	// 保存先
	public string mPath		= "ScreenCapture/";
	// 解像度の縦横で大きい方のサイズ
	public int mMaxRes		= 1024;
	// ファイル名、ない場合は日付で撮影
	public string mFileName	= null;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.S)){
			string filePath		= null;
			if (!string.IsNullOrEmpty(mFileName)) {
				filePath		= mPath + mFileName + ".png";
			}
			else {
				DateTime dtNow 	= DateTime.Now;
				filePath 		= mPath + dtNow.ToString("yyyy-MM-dd-HHmmss") + ".png";
			}

			float max = Mathf.Max(Screen.width, Screen.height);
			int scale = Mathf.RoundToInt( mMaxRes / max);

			Application.CaptureScreenshot(filePath, scale);

			Debug.Log("captured: " + filePath);
		}
	}
}

