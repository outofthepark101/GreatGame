using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonLoader : MonoBehaviour
{
    [System.Serializable]
    public class CommonConfig
    {
        public float INITIAL_SUPPLY_VALUE;
        public float INITIAL_MONEY_VALUE;
    }

    CommonConfig config = new CommonConfig();

    void Start()
    {
       //config = JsonUtility.FromJson<CommonConfig>()


    }
}
