using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugFrames : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    int fps = 0;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        fps = (int)(1 / Time.deltaTime);
        textMesh.text = $"FPS: {fps}";
    }
}
