using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traveler : MonoBehaviour
{
    public JsonLoader jsonLoader;
    public int cityID;

    //private int encounterType;
    private float supplySpendAmount;
    private string cityName;

 
    public void ReadCityData()
    {
        for (int i = 0; i < jsonLoader.prologue.Count; i++)
        {
            if (cityID == jsonLoader.prologue[i].CityID)
            {
                //encounterType = jsonLoader.prologue[i].EncounterType;
                supplySpendAmount = jsonLoader.prologue[i].SupplySpendAmount;
                cityName = jsonLoader.prologue[i].CityName;
            }
        }
        Debug.Log(supplySpendAmount);
        Debug.Log(cityName);
    }

    //need to work on this
    public void SubtractResources()
    {
        jsonLoader.commonConfig[0].Value =- supplySpendAmount;
        Debug.Log(jsonLoader.commonConfig[0].Value);
    }
}
