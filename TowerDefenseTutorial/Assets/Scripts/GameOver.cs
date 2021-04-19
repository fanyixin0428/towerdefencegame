using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text roundsText;

    public string mainMenu = "MainMenu";

    public SceneFader sceneFader;

    void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }

    public void Retry()
    {
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }


    public void Menu()
    {

        sceneFader.FadeTo(mainMenu);

    }



}
