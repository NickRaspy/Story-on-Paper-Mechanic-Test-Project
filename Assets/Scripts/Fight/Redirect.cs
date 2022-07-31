using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redirect : MonoBehaviour
{
    public bool isChoosing = false;
    public GameObject activePlayer;
    public GameObject chosenEnemy;
    public void SetAttack()
    {
        PlayerAttack playerAttack = activePlayer.GetComponent<PlayerAttack>();
        playerAttack.ePos = chosenEnemy.transform.Find("DefPoint").transform.position;
        playerAttack.isReady = true;
        playerAttack.isGoing = true;
    }
}
