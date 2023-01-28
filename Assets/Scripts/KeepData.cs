using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeepData : MonoBehaviour
{
    public static string PlayerName;
    public static float PlayerSpeed = 1000f;

    public InputField PlayerNameInput;
    public Slider mySlider;

    public Text showPlayerName;
    public Text myText;

    void Start()
    {
        mySlider.value = PlayerSpeed; 
        PlayerNameInput.text = PlayerName;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(PlayerName + "playing at " + PlayerSpeed + " Speed");
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        Debug.Log(PlayerName);
        showPlayerName.text = PlayerName;
    }

    public void SpeedSlider() 
    {
        myText.text = "Speed: " + mySlider.value;
        Debug.Log(mySlider.value);
        PlayerSpeed = mySlider.value;
    }
}
