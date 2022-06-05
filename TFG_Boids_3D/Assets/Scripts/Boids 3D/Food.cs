using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private float randomTime;
    public string foodName;

    void Start()
    {
        randomTime = Random.Range(2f, 6f);
        Invoke("DestroyFood", randomTime);
    }

    private void DestroyFood()
    {
        gameObject.SetActive(false);
    }
}
