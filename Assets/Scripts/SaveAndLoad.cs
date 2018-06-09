using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour {

    public List<int> list1 = new List<int>();
    public Vector2 xy = new Vector2();

    private savedata data;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Save()
    {
        if(!Directory.Exists(Application.dataPath + "/saves"))
            Directory.CreateDirectory(Application.dataPath + "/saves");

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.dataPath + "/saves/SaveData.dat");

        CopySaveData();
        bf.Serialize(file,data);

        file.Close();
    }

    public void CopySaveData()
    {
        data.list1.Clear();

        foreach (int i in list1)
        {
            data.list1.Add(i);
        }

        data.position = Vector2ToSerVector2(xy); 
    }

    public void Load()
    {
        if (File.Exists(Application.dataPath+ "/saves/SaveData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.dataPath + "/saves/SaveData.dat", FileMode.Open);
            data = (savedata)bf.Deserialize(file);

            CopyLoadData();
            file.Close();
        }
    }

    public void CopyLoadData()
    {
        list1.Clear();
        foreach(int i in data.list1)
        {
            list1.Add(i);
            xy = SerVector2ToVector2(data.position);
        }
    }

    public static SerVector2 Vector2ToSerVector2(Vector2 v2)
    {
        SerVector2 sv2 = new SerVector2();
        sv2.x = v2.x;
        sv2.y = v2.y;
        return sv2;
    }

    public static Vector3 SerVector2ToVector2(SerVector2 sv2)
    {
        Vector2 v2 = new Vector2();

        v2.x = sv2.x;
        v2.y = sv2.y;

        return v2;
    }
}

[System.Serializable]
public class savedata
{
    public List<int> list1 = new List<int>();
    public SerVector2 position;
}

[System.Serializable]
public class SerVector2
{
    public float x;
    public float y;
}