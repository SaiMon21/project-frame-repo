using UnityEngine;
using System.Collections;

// SCRIPT SOURCE: http://wiki.unity3d.com/index.php?title=FramesPerSecond

// HOW TO USE:
// > Attach the script to any game object.
// > Does not require any GUI element to be placed in scene.

// NOTE ~ FPS DISPLAY FONT COLOR:
// Under the OnGui() Function, change the decial numbers based on RGB values
// [style.normal.textColor = new Color (red, green, blue, alpha);

public class FPSDisplay : MonoBehaviour
{
	float deltaTime = 0.0f;

	void Update()
	{
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
	}

	void OnGUI()
	{
		int w = Screen.width, h = Screen.height;

		GUIStyle style = new GUIStyle();

		Rect rect = new Rect(0, 0, w, h * 2 / 100);
		style.alignment = TextAnchor.UpperLeft;
		style.fontSize = h * 2 / 100;
		style.normal.textColor = new Color (255.0f, 255.0f, 255.0f, 1.0f);
		float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
		string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
		GUI.Label(rect, text, style);
	}
}