using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JsonDisplayer : MonoBehaviour
{
    private TextMeshPro textMeshPro;
    public JsonLoader jsonLoader;

    void Start()
    {
        textMeshPro = gameObject.GetComponent<TextMeshPro>();
        jsonLoader = GetComponent<JsonLoader>();
        DisplayData();
    }

    public void DisplayData()
    {
        foreach (var data in jsonLoader.commonConfig.Index)
        {
            textMeshPro.text = data.ToString();
            if (data.ToString() == jsonLoader.commonConfig.Index)
            {
                textMeshPro.text = jsonLoader.commonConfig.Value.ToString();
            }
        }
    }
}
