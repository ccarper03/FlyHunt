using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(int i)
    {
        SceneManager.LoadScene(i);
    }
    private void Update()
    {
        // 1. QUIT

        // If player presses ESCAPE, game quits. Does not work in editor.
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
    }
}
 