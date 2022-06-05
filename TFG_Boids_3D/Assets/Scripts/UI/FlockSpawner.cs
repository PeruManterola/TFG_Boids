using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class FlockSpawner : MonoBehaviour
{
    public int id;
    [Space(10)]
    [SerializeField]
    private Flock flockFiltered;
    [SerializeField]
    private Flock flockUnFiltered;
  

    public FlockAgent fishAgent_1;
    public FlockAgent fishAgent_2;
    public FlockAgent fishAgent_3;

    private void Update()
    {
   
    }

    public FlockData LoadFlockDataFromJson(int id)
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/FlockDataFile" + id + ".json");

        FlockData data = JsonUtility.FromJson<FlockData>(json);

        return data;
    }

    private void Start()
    {
        SpawnFlock();
    }

    public void SpawnFlock()
    {
        FlockData loadedData = LoadFlockDataFromJson(id);
        if (loadedData.sameFlockOnly)
        {
            flockFiltered.maxSpeed = loadedData.speed;
            flockFiltered.neighbourRadious = loadedData.neighbourRadius;
            flockFiltered.avoidanceRadiousMultiplier = loadedData.avoidanceRadiusMultiplayer;
            switch (loadedData.fishId)
            {
                case 0:
                    flockFiltered.agentPrefab = fishAgent_1;
                    break;
                case 1:
                    flockFiltered.agentPrefab = fishAgent_2;
                    break;
                case 2:
                    flockFiltered.agentPrefab = fishAgent_3;
                    break;
                default:
                    flockFiltered.agentPrefab = fishAgent_1;
                    break;
            }

            flockFiltered.startingCount = PlayerPrefs.GetInt("flock" + id + "Amount",100);
            flockFiltered.gameObject.SetActive(true);
        }
        else
        {
            flockUnFiltered.maxSpeed = loadedData.speed;
            flockUnFiltered.neighbourRadious = loadedData.neighbourRadius;
            flockUnFiltered.avoidanceRadiousMultiplier = loadedData.avoidanceRadiusMultiplayer;

            switch (loadedData.fishId)
            {
                case 0:
                    flockUnFiltered.agentPrefab = fishAgent_1;
                    break;
                case 1:
                    flockUnFiltered.agentPrefab = fishAgent_2;
                    break;
                case 2:
                    flockUnFiltered.agentPrefab = fishAgent_3;
                    break;
                default:
                    flockUnFiltered.agentPrefab = fishAgent_1;
                    break;
            }

            flockUnFiltered.startingCount = PlayerPrefs.GetInt("flock" + id + "Amount", 100);
            flockUnFiltered.gameObject.SetActive(true);
        }
        
    }
}
