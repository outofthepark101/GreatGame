using Language.Lua;
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
    public TextAsset prologueData;
    public List<CommonConfig> commonConfig;
    public List<Prologue> prologue;

    [System.Serializable]
    public class CommonConfig
    {
        public string Index;
        public float Value;
    }

    public class Prologue
    {
        public int CityID;
        public int EncounterType;
        public float SupplySpendAmount;
        public string CityName;
    }

    void Awake()
    {
        commonConfig = JsonConvert.DeserializeObject<List<CommonConfig>>(configData.text);
        prologue = JsonConvert.DeserializeObject<List<Prologue>>(prologueData.text);
    }

}


