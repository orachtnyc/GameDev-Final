using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public GameObject quitPanel;

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
