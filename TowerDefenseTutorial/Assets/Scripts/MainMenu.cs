using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string levelToload = "MainLevel";

    public SceneFader sceneFader;

    public void Play()

    {

        sceneFader.FadeTo(levelToload);
        //FindObjectOfType<sceneFader>().FadeTo(levelToload);

        //SceneManager.LoadScene(levelToload);
    }

    public void Exit()
    {

        Debug.Log("Exitng...");
        Application.Quit();

    }




}
