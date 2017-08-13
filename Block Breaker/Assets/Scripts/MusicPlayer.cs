using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;
    private void Awake()
    { if (instance != null)
        {
            Debug.Log("ID: " + GetInstanceID());
            Destroy(gameObject);
            print("Duplicate Player Destroyed");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);

        }
        
    }
    void Start()
    {
       
    }
	void Update () {
		
	}
}
