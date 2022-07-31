using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButtons : MonoBehaviour
{
    public int number;
    public bool isPlayer;
    public SpawnManager spawnManager;
    public void DoSpawn()
    {
        spawnManager.Spawn(number, isPlayer);
    }
}
