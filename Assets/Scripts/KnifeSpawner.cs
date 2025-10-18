using UnityEngine;

public class KnifeSpawner : MonoBehaviour
{
    public GameObject knifePrefab;
    public Transform spawnPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(knifePrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
