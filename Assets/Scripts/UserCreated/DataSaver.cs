using System;
using Unity.Mathematics;
using UnityEngine;

public class DataSaver : MonoBehaviour
{
    public static DataSaver Instance;
    public String userName;
    public int highScore;
    public bool isThereAScore = false;

    

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
}
