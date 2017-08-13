using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public Sprite[] hitSprites;
    public AudioClip crack;
    public static int breakableCount = 0;
    private bool isBreakable;
    private LevelManager levelManager;
    
    private int timesHit;
	void Start () {
        isBreakable = (this.tag == "Breakable");
        //keep track of bricks
        if (isBreakable) {
            breakableCount++;
        }
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

    void OnCollisionExit2D(Collision2D col) {
        AudioSource.PlayClipAtPoint(crack, transform.position);
        if (isBreakable) {
            HandleHits();
        }
    }


    void HandleHits() {
        timesHit++;
        int maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
        {
            breakableCount--;
            Destroy(gameObject);
            levelManager.BrickDestroyed();
        }
        else
        {
            LoadSprites();
        }
    }
    void SimulateWin() {
        levelManager.LoadNextLevel();
    }
    void LoadSprites()
    {

        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];

        }
    }
}
