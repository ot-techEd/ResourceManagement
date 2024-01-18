using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public Color teamColor;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadColor();
    }

    public void SaveColor()
    {
        SaveData saveData = new SaveData();
        saveData.teamColor = teamColor;

        string jsonToSave = JsonUtility.ToJson(saveData);
        Debug.Log(jsonToSave);

        File.WriteAllText(Application.persistentDataPath + "/saveFile.json", jsonToSave);
    }

    public void LoadColor()
    {
        string path = Application.persistentDataPath + "/saveFile.json";

        if (File.Exists(path))
        {
            string jsonToLoad = File.ReadAllText(path);

            SaveData loadData = JsonUtility.FromJson<SaveData>(jsonToLoad);

            teamColor = loadData.teamColor;

            Debug.Log("Loaded Color" + teamColor.ToString());

        }
    }
}

[System.Serializable]
class SaveData
{
    public Color teamColor;
}
