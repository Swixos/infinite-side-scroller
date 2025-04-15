using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject trapPrefab;
    public GameObject coinPrefab;
    public float spawnInterval = 1.4f;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 1f, spawnInterval);
    }

    void Spawn()
    {
        int trapCount = Random.Range(1, 4);
        float baseX = 18f;

        for (int i = 0; i < trapCount; i++)
        {
            Vector3 trapPos = new Vector3(baseX + i * 1f, 0.573f, 0f);
            Instantiate(trapPrefab, trapPos, Quaternion.identity);

            if (Random.value < 0.5f)
            {
                Vector3 coinPos = trapPos + new Vector3(0f, 1.5f, 0f);
                Instantiate(coinPrefab, coinPos, Quaternion.identity);
            }
        }
    }
}
