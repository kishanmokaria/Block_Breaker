using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name)
	{
	Debug.Log ("Level Load requested "+ name);
		Application.LoadLevel(name);
	}
	public void Quit (string exit)
	{
	Debug.Log ("The exit button is pressed" + exit);
	Application.Quit ();
	}
    public void LoadNextLevel() {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public void BrickDestroyed() {
        if (Brick.breakableCount <= 0) {
            LoadNextLevel();
        }
    }
}
