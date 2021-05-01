using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelManager : MonoBehaviour {
    public PlayerController michelle;
    public GameObject goPanel;
    public timer timelim;
    public musicalNotes note;
    public Quit exit;


    
	void Start () {
     
        goPanel.gameObject.SetActive(false);
        StartCoroutine(gameOver());
        
	}
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
      //      Debug.Log("exited game");
            exit.quitGame();
        }
    }

    IEnumerator gameOver()
    {
        yield return new WaitForSeconds(90);
        goPanel.gameObject.SetActive(true);
        Destroy(michelle);
        note.notesnumber = 0;
        
        
    }

    
}
