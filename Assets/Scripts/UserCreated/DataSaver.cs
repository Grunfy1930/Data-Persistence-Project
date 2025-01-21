using System;
using System.IO;
using UnityEngine;

public class DataSaver : MonoBehaviour
{
    public static DataSaver Instance;
    public String userName;
    public String currentUserName;
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
        LoadUserName();
    }

    [System.Serializable]
    class SaveData
    {
        public String userName;
        public int highScore;
    }

    public void SaveUserName()
    {
        SaveData data = new SaveData();
        data.userName = userName;
        data.highScore = highScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadUserName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            isThereAScore = true;
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            userName = data.userName;
            highScore = data.highScore;

            Debug.Log("Loaded");
        }
    }
    
}
