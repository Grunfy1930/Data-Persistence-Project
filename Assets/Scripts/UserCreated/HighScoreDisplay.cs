using TMPro;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class HighScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI highestScore;

    public void Start()
    {
    if (DataSaver.Instance.isThereAScore == true)
    {
        highestScore.text = "Current Highscore is: "
        + DataSaver.Instance.userName 
        + " : " 
        + DataSaver.Instance.highScore;
    }
    }

}
