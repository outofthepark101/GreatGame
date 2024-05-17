using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JsonDisplayer : MonoBehaviour
{
    public TextMeshProUGUI[] textMeshPro;
    public Traveler[] traveler;

    private JsonLoader jsonLoader;

    void Start()
    {
        jsonLoader = GetComponent<JsonLoader>();
        DisplayData();
    }

    public void DisplayData()
    {
        for (int i = 0; i < jsonLoader.commonConfig.Count; i++)
        {
            if (textMeshPro[i].text == jsonLoader.commonConfig[i].Index)
            {
                textMeshPro[i].text = jsonLoader.commonConfig[i].Value.ToString();
            }
        }
    }

    public void DisplayUpdatedData()
    {
        for (int i = 0; i < traveler.Length; i++)
        {
            if (traveler[i].supplySpendAmount > 0)
            {
                textMeshPro[0].text = traveler[i].newSupplyAmount.ToString();
            }
            else if (traveler[i].moneySpendAmount > 0)
            {
                textMeshPro[1].text = traveler[i].newMoneyAmount.ToString();
            }
        }
        // need to find out how to display updated data on UI
    }
}
