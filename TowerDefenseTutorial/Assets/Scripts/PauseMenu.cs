using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject ui;
    public string mainMenu = "MainMenu";
    public SceneFader sceneFader;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)||Input.GetKeyDown(KeyCode.P))
        {
            Toggle();
        }

    }

    public void Toggle()
    {
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;

        }
        else
        {
            Time.timeScale = 1f;

        }

    }

    public void Countinue()
    {
        Toggle();
    }
    public void Retry()
    {

        Toggle();

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        Toggle();
        sceneFader.FadeTo(mainMenu);
    }



}
