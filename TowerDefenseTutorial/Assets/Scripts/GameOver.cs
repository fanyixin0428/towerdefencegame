using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string mainMenu = "MainMenu";

    public SceneFader sceneFader;


    public void Retry()
    {
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }


    public void Menu()
    {

        sceneFader.FadeTo(mainMenu);

    }



}
