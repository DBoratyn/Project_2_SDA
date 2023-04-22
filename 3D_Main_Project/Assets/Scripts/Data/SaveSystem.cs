using UnityEngine;
using System;
using System.IO;


namespace Data
{
    [Serializable]
    public class PlayerData
    {
        public int lastScore;
        public int bestScore;

        public PlayerData()
        {
            lastScore = 0;
            bestScore = 30;
        }
    }

    public class SaveSystem
    {
        public const string SAVE_NAME = "data.json";
        public PlayerData PlayerData { get; set; }

        public void LoadData()
        {
            var savePath = Path.Combine(Application.persistentDataPath, SAVE_NAME);
            if(File.Exists(savePath))
            {
                var rawFile = File.ReadAllText(savePath); //tylko wczytane jako string
                PlayerData = JsonUtility.FromJson<PlayerData>(rawFile); //teraz juz Json
            }
            else
            {
                PlayerData = new PlayerData();
                SaveData();
            }
        }

        public void SaveData()
        {
            var savePath = Path.Combine(Application.persistentDataPath, SAVE_NAME);
            var rawFile = JsonUtility.ToJson(PlayerData, true);
            File.WriteAllText(savePath, rawFile);
        }
    }
}
