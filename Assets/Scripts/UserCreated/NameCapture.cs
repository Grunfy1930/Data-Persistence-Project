using UnityEngine;
using TMPro;

public class NameCapture : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public void Update()
    {
        DataSaver.Instance.userName = userName.text;
    }
    
}
