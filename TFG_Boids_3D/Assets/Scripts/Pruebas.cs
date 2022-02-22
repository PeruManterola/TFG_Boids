using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Pruebas : MonoBehaviour
{
    [DrawWithUnity]
    public List<Item> Inventory;

    private void Awake()
    {
        Inventory = new List<Item>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
