using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FlockSpawner : MonoBehaviour
{
    [SerializeField]
    private Flock flock;
    [Space(10)]
    [SerializeField]
    private Slider spawnSlider;
    [SerializeField]
    private TextMeshProUGUI textMeshProUGUI;

    private void Update()
    {
        textMeshProUGUI.text = $"Cantidad: {spawnSlider.value}";

    }

    public void SpawnFlock()
    {
        flock.startingCount = (int)spawnSlider.value;
        flock.gameObject.SetActive(true);
    }
}
