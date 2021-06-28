using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public GameObject Panel;
    private bool _isPanelOpen;
    // Start is called before the first frame update
    void Start()
    {
        _isPanelOpen = false;
        ClosePanel();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_isPanelOpen)
            {
                Panel.gameObject.SetActive(true);
                _isPanelOpen = !_isPanelOpen;
                PauseGame();
            }
            else
            {
                Panel.gameObject.SetActive(false);
                _isPanelOpen = !_isPanelOpen;
                ResumeGame();
            }
        }   
    }
    public void OpenPanel()
    {
        Panel.gameObject.SetActive(true);
        PauseGame();
    }
    public void ClosePanel()
    {
        Panel.gameObject.SetActive(false);
        ResumeGame();
    }
    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
    }

}
