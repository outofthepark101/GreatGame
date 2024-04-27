using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using UnityEngine;


public class JsonLoader : MonoBehaviour
{
    public TextAsset configData;

    [System.Serializable]
    public class CommonConfig
    {
        public string Index;
        public float Value;
    }

    void Start()
    {
        var commonConfig = JsonConvert.DeserializeObject<List<CommonConfig>>(configData.text);
        Debug.Log(commonConfig[0].Index);
        Debug.Log(commonConfig[0].Value);
        Debug.Log(commonConfig[1].Index);
        Debug.Log(commonConfig[1].Value);
    }

}


