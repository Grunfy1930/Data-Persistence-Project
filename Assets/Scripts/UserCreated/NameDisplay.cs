using TMPro;
using UnityEngine;

public class NameDisplay : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public void Update()
    {
        userName.text = "Best Score: "+
        DataSaver.Instance.userName + " : " +
        DataSaver.Instance.highScore.ToString();
    }
    
}
