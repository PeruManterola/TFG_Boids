using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/Interest")]
public class InterestPointBehaviour : FlockBehaviour
{
    public GameObject interestPoint;
    private Vector3 center;
    public float radius = 4f;
    public float distanceThreshold = 5f;

    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        if (interestPoint.activeSelf == true && interestPoint != null && Vector3.Distance(interestPoint.transform.position,agent.transform.position) <= distanceThreshold)
        {
            center = interestPoint.transform.position;
            Vector3 centerOffset = center - agent.transform.position;
            float t = centerOffset.magnitude / radius;
            if (t < 0.9f)
            {
                return Vector3.zero;
            }
            return centerOffset * t * t;
        }
        else
        {
            return Vector3.zero;
        }
    }
}
