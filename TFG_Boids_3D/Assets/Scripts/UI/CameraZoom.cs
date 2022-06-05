using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class CameraZoom : MonoBehaviour
{

    public CinemachineFreeLook cinemachineCamera;
    public Slider zoomSlider;

    public void ZoomController()
    {
        cinemachineCamera.m_Lens.FieldOfView = zoomSlider.value;
    }

}
