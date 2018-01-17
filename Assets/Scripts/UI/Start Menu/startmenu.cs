using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour {

    public GameObject startButton;
    public GameObject optionsButton;
    public GameObject exitButton;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //This function will listen for a click on the play button and then load the first gameplay scene.
 
    public void playOnClick()
    {
       // SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
    }

    /// <summary>
    /// This function will listen for a click on the options button and then hide everything except the background, it will then make all the options page visible without loading a new scene.
    /// This will save some file space, help the cpu out and make the game seem more smoother when navigating through settings.
    /// </summary>

    public void optionsOnClick()
    {

    }


    //This function will listen for a click on the exit button and then will close application.
    public void exitOnClick()
    {
        Application.Quit();
    }
}
