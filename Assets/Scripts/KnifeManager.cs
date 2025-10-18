using UnityEngine;

public class KnifeManager : MonoBehaviour
{
    public GameObject knifePrefab;
    public Transform spawnPoint;
    public int totalKnives = 5; // number of knives you can throw
    private bool canThrow = true;

    void Update()
    {
        if (canThrow && Input.GetMouseButtonDown(0))
        {
            ThrowKnife();
        }
    }

    void ThrowKnife()
    {
        if (totalKnives > 0)
        {
            Instantiate(knifePrefab, spawnPoint.position, Quaternion.identity);
            totalKnives--;
        }

        if (totalKnives <= 0)
        {
            canThrow = false;
            Debug.Log("No knives left!");
        }
    }
}
