using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Filter/Physics Layer")]
public class PhysicsLayerFilter : ContextFilter
{
    public LayerMask mask;
    //public Transform newItem;

    public override List<Transform> Filter(FlockAgent agent, List<Transform> original)
    {
        List<Transform> filtered = new List<Transform>();

        foreach (Transform item in original)
        {

            //Vector3 closestPoint = item.gameObject.GetComponent<Collider>().ClosestPoint(agent.transform.position);



            if (mask == (mask | (1 << item.gameObject.layer)))
            {
                //item.position = closestPoint;
                filtered.Add(item);
            }
        }
        return filtered;
    }
}
