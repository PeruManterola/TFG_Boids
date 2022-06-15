using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public int id;
    [SerializeField]
    private InterestPointBehaviour interestPointBehaviour;
  
    public GameObject food;
    public float radius = 5;
    private GameObject toDelete;
    private GameObject newGO;
    private FoodManager foodManager;
    Vector3 origin = new Vector3(0.910000026f, 22.8799992f, 2.06999993f);

    private void Start()
    {
        origin=transform.position; 
        foodManager = FindObjectOfType<FoodManager>();
        food = foodManager.GetFoodType(PlayerPrefs.GetInt("foodType" + id, 0));
        interestPointBehaviour = foodManager.GetInterestBehaviour(id);
        newGO = Instantiate(food, transform.position, Quaternion.identity, transform);
        interestPointBehaviour.interestPoint = newGO;
        ActivateFood();
        NewPosition();
        newGO.SetActive(false);
    }

    private void ActivateFood()
    {
        newGO.SetActive(true);
    }

    public void SpawnFood()
    {
        toDelete = interestPointBehaviour.interestPoint;
        Destroy(toDelete);
        newGO = Instantiate(food, transform.position, Quaternion.identity, transform);
        interestPointBehaviour.interestPoint = newGO;
        ActivateFood();
        NewPosition();
    }

    private void NewPosition()
    {
        Vector2 pos = Random.insideUnitCircle * radius;
        Vector3 newPosition = new Vector3(pos.x, 22.8799992f, pos.y);
        transform.position = newPosition;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(origin, radius);
    }
}
