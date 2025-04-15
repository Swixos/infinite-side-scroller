using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Camera mainCamera;
    public float shakeDuration = 0.3f;
    public float shakeMagnitude = 0.2f;

    private Vector3 initialCamPos;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void GameOver()
    {
        Debug.Log("Game Over!");
        if (mainCamera == null)
            mainCamera = Camera.main;

        initialCamPos = mainCamera.transform.position;
        StartCoroutine(ShakeAndRestart());
    }

    System.Collections.IEnumerator ShakeAndRestart()
    {
        float elapsed = 0f;

        while (elapsed < shakeDuration)
        {
            float offsetX = Random.Range(-1f, 1f) * shakeMagnitude;
            float offsetY = Random.Range(-1f, 1f) * shakeMagnitude;
            mainCamera.transform.position = initialCamPos + new Vector3(offsetX, offsetY, 0);
            elapsed += Time.deltaTime;
            yield return null;
        }

        mainCamera.transform.position = initialCamPos;
        ScoreManager.Instance?.ResetScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
