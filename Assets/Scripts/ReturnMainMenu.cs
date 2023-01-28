using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnMainMenu : MonoBehaviour
{ 
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LEVEL01()
    {
        SceneManager.LoadScene("Level01");
    }

    public void LEVEL02()
    {
        SceneManager.LoadScene("Level02");
    }

    public void LEVEL03()
    {
        SceneManager.LoadScene("Level03");
    }
}
