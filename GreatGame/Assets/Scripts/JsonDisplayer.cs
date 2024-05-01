using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JsonDisplayer : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    public JsonLoader jsonLoader;

    void Start()
    {
        textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
        DisplayData();
    }

    public void DisplayData()
    {
        for (int i = 0; i < jsonLoader.commonConfig.Count; i++)
        {
            if (textMeshPro.text == jsonLoader.commonConfig[i].Index)
            {
                textMeshPro.text = jsonLoader.commonConfig[i].Value.ToString();
            }
        }
    }
}
