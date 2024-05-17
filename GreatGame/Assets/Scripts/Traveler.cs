using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traveler : MonoBehaviour
{
    public JsonLoader jsonLoader;
    public int cityID;

    [HideInInspector]
    //private int encounterType;
    public float newSupplyAmount, supplySpendAmount, newMoneyAmount, moneySpendAmount;
    [HideInInspector]
    public string cityName;

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
    }

    public void SubtractResources()
    {
        if (supplySpendAmount > 0)
        {
            newSupplyAmount = jsonLoader.commonConfig[0].Value;
            newSupplyAmount -= supplySpendAmount;
        }
        else if (moneySpendAmount > 0)
        {
            newMoneyAmount = jsonLoader.commonConfig[1].Value;
            newMoneyAmount -= moneySpendAmount;
        }
    }
}
