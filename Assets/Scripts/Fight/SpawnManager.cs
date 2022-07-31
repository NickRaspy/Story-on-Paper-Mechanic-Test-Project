using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] entities;
    public List<GameObject> playerSpawns;
    public List<GameObject> enemySpawns;
    public List<GameObject> playersInScene;
    public List<GameObject> enemiesInScene;
    public void Spawn(int number, bool isPlayer)
    {
        if(playersInScene.Count > 0 && isPlayer)
        {
            for(int i = 0; i < playersInScene.Count; i++)
            {
                Destroy(playersInScene[i]);
            }
            playersInScene.Clear();
        }
        if (enemiesInScene.Count > 0 && !isPlayer)
        {
            for (int i = 0; i < enemiesInScene.Count; i++)
            {
                Destroy(enemiesInScene[i]);
            }
            enemiesInScene.Clear();
        }
        if (isPlayer)
        {
            switch (number)
            {
                case 1:
                    playersInScene.Add(Instantiate(entities[0], playerSpawns[0].transform.Find("P1PointSpawn").transform));
                    break;
                case 2:
                    playersInScene.Add(Instantiate(entities[0], playerSpawns[1].transform.Find("P1PointSpawn").transform));
                    playersInScene.Add(Instantiate(entities[1], playerSpawns[1].transform.Find("P2PointSpawn").transform));
                    break;
                case 3:
                    playersInScene.Add(Instantiate(entities[0], playerSpawns[2].transform.Find("P1PointSpawn").transform));
                    playersInScene.Add(Instantiate(entities[1], playerSpawns[2].transform.Find("P2PointSpawn").transform));
                    playersInScene.Add(Instantiate(entities[1], playerSpawns[2].transform.Find("P3PointSpawn").transform));
                    break;
                case 4:
                    playersInScene.Add(Instantiate(entities[0], playerSpawns[3].transform.Find("P1PointSpawn").transform));
                    playersInScene.Add(Instantiate(entities[1], playerSpawns[3].transform.Find("P2PointSpawn").transform));
                    playersInScene.Add(Instantiate(entities[1], playerSpawns[3].transform.Find("P3PointSpawn").transform));
                    playersInScene.Add(Instantiate(entities[1], playerSpawns[3].transform.Find("P4PointSpawn").transform));
                    break;
            }
        }
        else
        {
            switch (number)
            {
                case 1:
                    enemiesInScene.Add(Instantiate(entities[2], enemySpawns[0].transform.Find("E1PointSpawn").transform));
                    break;
                case 2:
                    enemiesInScene.Add(Instantiate(entities[2], enemySpawns[1].transform.Find("E1PointSpawn").transform));
                    enemiesInScene.Add(Instantiate(entities[2], enemySpawns[1].transform.Find("E2PointSpawn").transform));
                    break;
                case 3:
                    enemiesInScene.Add(Instantiate(entities[2], enemySpawns[2].transform.Find("E1PointSpawn").transform));
                    enemiesInScene.Add(Instantiate(entities[2], enemySpawns[2].transform.Find("E2PointSpawn").transform));
                    enemiesInScene.Add(Instantiate(entities[2], enemySpawns[2].transform.Find("E3PointSpawn").transform));
                    break;
                case 4:
                    enemiesInScene.Add(Instantiate(entities[2], enemySpawns[3].transform.Find("E1PointSpawn").transform));
                    enemiesInScene.Add(Instantiate(entities[2], enemySpawns[3].transform.Find("E2PointSpawn").transform));
                    enemiesInScene.Add(Instantiate(entities[2], enemySpawns[3].transform.Find("E3PointSpawn").transform));
                    enemiesInScene.Add(Instantiate(entities[2], enemySpawns[3].transform.Find("E4PointSpawn").transform));
                    break;
            }
        }
    }
}
