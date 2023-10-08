using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private string filePath;

    private void Start()
    {
        filePath = Application.persistentDataPath + "/save game";
    }

    public void SaveGame()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(filePath, FileMode.Create);

        DataSave.Save save = new DataSave.Save();
        bf.Serialize(fs, save);
        fs.Close();
    }

    public void loadGameData()
    {
        if (!File.Exists(filePath)) return;

        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(filePath, FileMode.Open);
        DataSave.Save save = (DataSave.Save)bf.Deserialize(fs);

        FindObjectOfType<MenuController>().LoadData();

        fs.Close();
    }
}