using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor;

public class Buttons : MonoBehaviour
{

    public TextMeshProUGUI userName;
    
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        DataSaver.Instance.userName = userName.text;

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit(); // original code to quit Unity player
    #endif
    }
}
