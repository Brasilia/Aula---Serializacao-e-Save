using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameSave : MonoBehaviour
{
    //public Player m_player;
    //public SerializationCallbackScript m_SerializableScript;

    public GameData gameData;


    private string m_gameDataFileName = "save.json";
    private string m_filePath;

    // Start is called before the first frame update
    void Start()
    {
        // Path.Combine combines strings into a file path
        // Application.StreamingAssets points to Assets/StreamingAssets in the Editor, and the StreamingAssets folder in a build
        m_filePath = Path.Combine(Application.streamingAssetsPath, m_gameDataFileName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SaveGame();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadGame();
        }
    }

    private void SaveGame()
    {
        //GameData gameData = new GameData();
        string dataAsJson = JsonUtility.ToJson(gameData);
        File.WriteAllText(m_filePath, dataAsJson);
    }

    private void LoadGame()
    {
        //if (File.Exists(m_filePath))
        //{
        //    // Read the json from the file into a string
        //    string dataAsJson = File.ReadAllText(m_filePath);
        //    // Pass the json to JsonUtility, and tell it to create a GameData object from it
        //    GameData loadedData = JsonUtility.FromJson<GameData>(dataAsJson);

        //    // Retrieve the allRoundData property of loadedData
        //    allRoundData = loadedData.allRoundData;
        //}
        //else
        //{
        //    Debug.LogError("Cannot load game data!");
        //}
    }
}
