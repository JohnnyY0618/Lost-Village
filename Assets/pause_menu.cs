using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_menu : MonoBehaviour
{
    public static bool isGamePasue = false;

    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { 
            if (isGamePasue)
            {
                Resume_Menu();
            }
            else {
                Pause_Menu();
            }
        }
           
    }

    // resume the game
    public void Resume_Menu() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f; // normal is 1
        isGamePasue = false;
    }

    // pasue the memnu
    void Pause_Menu() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePasue = true;
    }

    public void Load_Menu() {
        Debug.Log("Menu button been pressing and loading the Menu...");
        SceneManager.LoadScene("Main Menu");
    }
    public void Quit_Game() {
        Debug.Log("Quit button been pressing and Quiting the game....");
        Application.Quit();
    }
}
