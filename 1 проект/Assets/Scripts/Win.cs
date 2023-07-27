using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Button buttonMenu;
    public Button buttonNextLevel;
    public Text text;

    private void Start()
    {
        buttonMenu.gameObject.SetActive(false);
        buttonNextLevel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.color = new Color(0.35f, 1f, 0f);
            text.text = "Победа, победа (но ты лишился обеда D: )";
            Time.timeScale = 0;
            buttonMenu.gameObject.SetActive(true);
            buttonNextLevel.gameObject.SetActive(true);
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void NextLevel(int level)
    {
        SceneManager.LoadScene(level);
        Time.timeScale = 1;
    }
}
