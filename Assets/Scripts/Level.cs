﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

    [SerializeField] float delayInSeconds = 2f;

    public void LoadStartMenu() {
        SceneManager.LoadScene(0);
    }

    public void LoadGameScene() {
        SceneManager.LoadScene(1);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOver() {
        StartCoroutine(WaitAndLoad(2));
    }

    private IEnumerator WaitAndLoad(int index) {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(index);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
