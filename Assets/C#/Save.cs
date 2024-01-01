using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Save : MonoBehaviour
{

    public string fileName = "file name";
    public string folderName = "Folder name";
    public PlayerInfo playerInfo;
    public HealthSystem healthsystem = new HealthSystem(1);
   
    public void saveToFile(HealthSystem health)
    {
        if (!Directory.Exists(folderName))

            Directory.CreateDirectory(folderName);
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Create(folderName + "/" + fileName + ".bin");
        formatter.Serialize(saveFile, playerInfo);
        print(Directory.GetCurrentDirectory().ToString());
        saveFile.Close();
        
    }
    // Start is called before the first frame update

    // Update is called once per frame

}
