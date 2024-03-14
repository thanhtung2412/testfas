using System.IO;
using UnityEngine;

public static class SaveSystem 
{
    public static readonly string SAVE_FOLDER = Application.persistentDataPath + "/saves/";
    public static readonly string FILE_EXT = ".json";

    public static void Initialize()
    {
        if (!Directory.Exists(SAVE_FOLDER))
        {
            Directory.CreateDirectory(SAVE_FOLDER);
        }
    }
    public static void Save(string filename, string data)
    {
        File.WriteAllText(SAVE_FOLDER + filename + FILE_EXT, data);
    }
    public static string Load(string filename)
    {
        string fileLocation = SAVE_FOLDER + filename + FILE_EXT;
        if(File.Exists(fileLocation))
        {
            string loadedData = File.ReadAllText(fileLocation);
            return loadedData;
        }
        else
        {
            return null;
        }
    }
}
[System.Serializable]
public class SaveData
{
    public int highscore;
    public SaveData(int _hs)
    {
        highscore = _hs;
    }
}
