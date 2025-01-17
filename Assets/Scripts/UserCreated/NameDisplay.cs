using TMPro;
using UnityEngine;

public class NameDisplay : MonoBehaviour
{
    public TextMeshProUGUI userName;

    public void Update()
    {
        DataSaver.Instance.userName = userName.text;
    }

}
