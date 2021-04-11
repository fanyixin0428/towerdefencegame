using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;
    
    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public Text waveCountdownText;

    private int waveIndex = 0;

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = string.Format("{0:00.00}",countdown);
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;

        for (int i = 0; i < waveIndex; i++)
        {
            SpwanEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        //numOfEnemies = Waves[waveNumber].count;

        //numOfEnemies = waveNumber * waveNumber + 1;

        ;

    }

    void SpwanEnemy()
    {
        Instantiate(enemyPrefab,spawnPoint.position,spawnPoint.rotation);

    }


  

}
