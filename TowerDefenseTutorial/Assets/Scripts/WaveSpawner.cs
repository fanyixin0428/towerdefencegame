using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class WaveSpawner : MonoBehaviour
{
    public static int EnemiesAlive = 0;
    private int starEnemiesAlive = 0;

    public Wave[] waves;
    
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public Text waveCountdownText;

    public GameManager gameManager;

    private int waveIndex = 0;

    void Start()
    {
        EnemiesAlive = starEnemiesAlive;
    }

    void Update()
    {
        if (EnemiesAlive > 0)
        {
            return;
        }



        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = string.Format("{0:00.00}",countdown);
    }

    IEnumerator SpawnWave()
    {

        PlayerStats.Rounds++;

        Wave wave = waves[waveIndex];

        EnemiesAlive = wave.count;

        for (int i = 0; i < wave.count; i++)
        {
            SpwanEnemy(wave.enemy);
            yield return new WaitForSeconds(1f/wave.rate);
        }
        waveIndex++;
        //numOfEnemies = Waves[waveNumber].count;

        //numOfEnemies = waveNumber * waveNumber + 1;

        if (waveIndex == waves.Length)
        {
            gameManager.WinLevel();
            this.enabled=false;

        }

    }

    void SpwanEnemy(GameObject enemy)
    {
        Instantiate(enemy,spawnPoint.position,spawnPoint.rotation);
        
    }


  

}
