using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEditor;

[CreateAssetMenu(menuName = "Flock/Behaviour/Composite")]
[InlineEditor]
public class CompositeBehaviour : FlockBehaviour
{
    [HorizontalGroup("Split", 0.8f)]
    public FlockBehaviour[] behaviours;

    [HorizontalGroup("Split/Right")]
    public float[] weights;

    public override Vector3 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        //handle data mismatch
        if (weights.Length != behaviours.Length)
        {
            Debug.LogError("Data mismatch in " + name, this);
            return Vector3.zero;
        }

        //set up move
        Vector3 move = Vector3.zero;

        //iterate through behaviours
        for (int i = 0; i < behaviours.Length; i++)
        {
            Vector3 partialMove = behaviours[i].CalculateMove(agent, context, flock) * weights[i];

            if (partialMove != Vector3.zero)
            {
                if (partialMove.sqrMagnitude > weights[i] * weights[i])
                {
                    partialMove.Normalize();
                    partialMove *= weights[i];
                }

                move += partialMove;
            }
        }

        return move;
    }

    [Button]
    void AddBehaviour()
    {
        int oldCount = (behaviours != null) ? behaviours.Length : 0;
        FlockBehaviour[] newBehaviours = new FlockBehaviour[oldCount + 1];
        float[] newWeights = new float[oldCount + 1];
        for (int i = 0; i < oldCount; i++)
        {
            newBehaviours[i] = behaviours[i];
            newWeights[i] = weights[i];
        }
        newWeights[oldCount] = 1f;
        behaviours = newBehaviours;
        weights = newWeights;
#if UNITY_EDITOR
        EditorUtility.SetDirty(this);

#endif

    }
    [Button]
    void RemoveBehaviour()
    {
        int oldCount = behaviours.Length;
        if (oldCount == 1)
        {
            behaviours = null;
            weights = null;
            return;
        }
        FlockBehaviour[] newBehaviours = new FlockBehaviour[oldCount - 1];
        float[] newWeights = new float[oldCount - 1];
        for (int i = 0; i < oldCount - 1; i++)
        {
            newBehaviours[i] = behaviours[i];
            newWeights[i] = weights[i];
        }
        behaviours = newBehaviours;
        weights = newWeights;
#if UNITY_EDITOR
        EditorUtility.SetDirty(this);
#endif

    }
}
