    using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsAnimals;
    float spawnRangeX = 20;
    float spawnPosZ = 20;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, prefabsAnimals.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(prefabsAnimals[animalIndex], spawnPos, prefabsAnimals[animalIndex].transform.rotation);
    }
}
