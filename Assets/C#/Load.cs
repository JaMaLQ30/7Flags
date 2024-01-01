using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Load : MonoBehaviour
{
    //creating the name of the folder "directry
    //
    public string fileName = "file name";
    //creating the nfile name
    public string folderName = "Folder name";
    HealthSystem healthsystem;
    public Gamehandler handler;
    //the class that contain the data O references B.
    //
   
    public void LoadData()
    {
        // the formatter will convert binary File to unity data
        BinaryFormatter formatter = new BinaryFormatter();
        //chosing the save file to open
        FileStream saveFile = File.Open(folderName + "/" + fileName + ".bin", FileMode.Open);
        //converting the file to the classdata to use in the game
        PlayerInfo playerInfo = (PlayerInfo)formatter.Deserialize(saveFile);
        healthsystem = (HealthSystem)formatter.Deserialize(saveFile);
        print(healthsystem.gethealth().ToString());
        //print the data
        print(playerInfo.Health);
        print(playerInfo.Score);
        print(playerInfo.Name);
        //end to the process
       
        saveFile.Close();
        handler.Loadiong();
    }
    public  HealthSystem gethealth()
    {   return healthsystem;  }
}
