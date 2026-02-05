
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;
using UnityEditor;
public class TitleScreenManager : MonoBehaviour
{
    public void QuitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        //To end a game you Build, comment the previous line
        //And uncomment the following line.
        Application.Quit();
    }
    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
