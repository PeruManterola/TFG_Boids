using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramerateManager : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 60;
        DontDestroyOnLoad(this.gameObject);
    }
}
