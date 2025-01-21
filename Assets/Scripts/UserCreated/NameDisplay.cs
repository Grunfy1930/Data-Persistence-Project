using TMPro;
using UnityEngine;

public class NameDisplay : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public void Start()
    {
        userName.text = "Best Score: "+
        DataSaver.Instance.userName + " : " +
        DataSaver.Instance.highScore.ToString();
    }
    
}
