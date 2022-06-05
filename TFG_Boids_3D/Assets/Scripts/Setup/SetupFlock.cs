using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class SetupFlock : MonoBehaviour
{
    [Range(0,2)]
    public int flockID=0;

    public StayInRadiousBehaviour stayInRadiousBehaviour;
    public InterestPointBehaviour interestPointBehaviour;

    public Toggle sameFlock;

    public Slider radiusSlider;
    public Slider hungerSlider;
    public Slider speedSlider;
    public Slider neighbourSlider;
    public Slider avoidanceSlider;

    public Slider flockAmount;

    public TMP_Dropdown foodType;
    public TMP_Dropdown fishType;

    public GameObject food0;
    public GameObject food1;
    public GameObject food2;

    private void Start()
    {
        UpdateData();
    }

    private void UpdateData()
    {
        FlockData savedData = LoadFlockDataFromJson(flockID);
        sameFlock.isOn = savedData.sameFlockOnly;
        radiusSlider.value = PlayerPrefs.GetFloat("radius", 50f);
        hungerSlider.value = PlayerPrefs.GetFloat("hunger", 6);
        speedSlider.value = savedData.speed;
        neighbourSlider.value = savedData.neighbourRadius;
        avoidanceSlider.value = savedData.avoidanceRadiusMultiplayer;
        foodType.value = PlayerPrefs.GetInt("foodType"+flockID, 0);
        fishType.value = savedData.fishId;

        flockAmount.value = PlayerPrefs.GetInt("flock"+flockID+"Amount",100);
    }

    public void SaveToJson()
    {
        FlockData flockData = new FlockData();
        flockData.sameFlockOnly = sameFlock.isOn;
        flockData.speed = speedSlider.value;
        flockData.neighbourRadius = neighbourSlider.value;
        flockData.avoidanceRadiusMultiplayer = avoidanceSlider.value;
        flockData.fishId = fishType.value;

        string json = JsonUtility.ToJson(flockData, true);
        File.WriteAllText(Application.persistentDataPath + "/FlockDataFile"+flockID+".json",json);
    }
  
    public FlockData LoadFlockDataFromJson(int id)
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/FlockDataFile"+id+".json");

        FlockData data = JsonUtility.FromJson<FlockData>(json);
       // UpdateData();
        return data;
    }

    public void SetFishAmount()
    {
        PlayerPrefs.SetInt("flock"+flockID+"Amount", (int)flockAmount.value);         
    }

    public void SetFoodType()
    {
        switch (foodType.value)
        {
            case 0:
                interestPointBehaviour.interestPoint = food0;
                break;
            case 1:
                interestPointBehaviour.interestPoint = food1;
                break;
            case 2:
                interestPointBehaviour.interestPoint = food2;
                break;
            default:
                interestPointBehaviour.interestPoint = food0;
                break;
        }
        PlayerPrefs.SetInt("foodType"+flockID, foodType.value);
    }

    public void SetRadius()
    {
        PlayerPrefs.SetFloat("radius", radiusSlider.value);
        stayInRadiousBehaviour.radius = radiusSlider.value;

    }

    public void SetHunger()
    {
        PlayerPrefs.SetFloat("hunger", hungerSlider.value);
        interestPointBehaviour.distanceThreshold = hungerSlider.value;
    }

    public void TestLoading()
    {
        FlockData savedData= LoadFlockDataFromJson(0);
        Debug.Log("Same flock? " + savedData.sameFlockOnly);
    }

}

public class FlockData
{
    public int fishId;
    public bool sameFlockOnly;
    public float speed;
    public float neighbourRadius;
    public float avoidanceRadiusMultiplayer;
}
