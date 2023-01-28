using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    public Text showPlayerSpeed;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void StartLevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void StartSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    void Start()
    {
        showPlayerSpeed.text = "Current Speed: " + KeepData.PlayerSpeed;
        Debug.Log(KeepData.PlayerSpeed);
    }
}
