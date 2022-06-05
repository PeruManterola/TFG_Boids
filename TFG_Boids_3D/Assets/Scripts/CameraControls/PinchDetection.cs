using System;
using System.Collections;

using UnityEngine;

public class PinchDetection : MonoBehaviour
{
    [SerializeField]
    private float speed = 4;

    private TouchControls controls;
    private Coroutine zoomCoroutine;
    private Transform cameraTransform;

    private void Awake()
    {
        controls = new TouchControls();
        cameraTransform = Camera.main.transform;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Start()
    {
        controls.Touch.SecondaryTouchContact.started += _ => ZoomStart();
        controls.Touch.SecondaryTouchContact.canceled += _ => ZoomEnd();

    }
    private void ZoomStart()
    {
        zoomCoroutine = StartCoroutine(ZoomDetectionIE());
    }
    private void ZoomEnd()
    {
        StopCoroutine(zoomCoroutine);
    }



    IEnumerator ZoomDetectionIE()
    {
        float previousDistance = Vector2.Distance(controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>(), controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>());
        float distance = 0;
        while (true)
        {
            distance = Vector2.Distance(controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>(), controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>());
            //Zoom in
            if (distance > previousDistance)
            {
                Vector3 targetPosition = cameraTransform.position;
                targetPosition.z += 1;
                cameraTransform.position = Vector3.Slerp(cameraTransform.position, targetPosition, Time.deltaTime * speed);
            }
            //Zoom Out
            else if (distance < previousDistance)
            {
                Vector3 targetPosition = cameraTransform.position;
                targetPosition.z -= 1;
                cameraTransform.position = Vector3.Slerp(cameraTransform.position, targetPosition, Time.deltaTime * speed);
            }
            previousDistance = distance;
            yield return null;
        }
    }
}
