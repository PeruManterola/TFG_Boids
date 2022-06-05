using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    [SerializeField]
    private GameObject shrimp;
    [SerializeField]
    private GameObject catFood;
    [SerializeField]
    private GameObject plankton;

    [SerializeField]
    private InterestPointBehaviour interestPointBehaviour_Flock0;
    [SerializeField]
    private InterestPointBehaviour interestPointBehaviour_Flock1;
    [SerializeField]
    private InterestPointBehaviour interestPointBehaviour_Flock2;

    public GameObject GetFoodType(int id)
    {
        switch (id)
        {
            case 0:
                return shrimp;
            case 1:
                return catFood;
            case 2:
                return plankton;
            default:
                return shrimp;
        }
    }

    public InterestPointBehaviour GetInterestBehaviour(int id)
    {
        switch (id)
        {
            case 0:
                return interestPointBehaviour_Flock0;
            case 1:
                return interestPointBehaviour_Flock1;
            case 2:
                return interestPointBehaviour_Flock2;
            default:
                return interestPointBehaviour_Flock0;
        }
    }
}
