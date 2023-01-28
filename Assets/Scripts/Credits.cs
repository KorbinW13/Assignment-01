using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public Text showPlayerName;

    public void Start()
    {
        showPlayerName.text = KeepData.PlayerName;
        Debug.Log(KeepData.PlayerName); 
    }

    public void Quit()
    {
        Debug.Log("Quit");
        //Application.Quit(); since we dont build the game and it doesn't work with editor.
        UnityEditor.EditorApplication.isPlaying= false;
    }
}
