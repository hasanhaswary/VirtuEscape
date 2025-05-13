using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadEscapeRoom()
    {
        SceneManager.LoadScene("EscapeRoom");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
