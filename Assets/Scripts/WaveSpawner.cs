using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public static int enamiesAlive = 0;

    public Wave[] waves;

    public Transform spawnPoint;

    public float timeBetweenwaves = 5f;
    private float countdown = 5f;

    public Text waveCoundownText;

    public GameManager gameManager;

    private int waveIndex = 0;

    void Update () 
    {
        if (enamiesAlive > 0)
        {
            return;
        }

        if (waveIndex == waves.Length)
        {
            gameManager.WinLevel();
            this.enabled = false;
        }   

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenwaves;
            return;
        }

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCoundownText.text = string.Format("{0:00.00}", countdown);

    }

    IEnumerator SpawnWave()
    {       
        PlayerStats.Rounds++;

        Wave wave = waves[waveIndex];

        enamiesAlive = wave.count;

        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.enemyVariety[Random.Range(0, wave.enemyVariety.Length)]);
            yield return new WaitForSeconds(1f/wave.rate);
        }

        waveIndex++;

         
    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }

}
