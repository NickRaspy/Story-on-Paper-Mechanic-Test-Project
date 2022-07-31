using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButton : MonoBehaviour
{
    public GameObject player;
    public Redirect redirect;
    public void Attack()
    {
        player.GetComponent<PlayerTest>().isAttacking = true;
        redirect.isChoosing = true;
        redirect.activePlayer = player;
        GameObject.Find("ObjectEnabler").GetComponent<EnableObject>().playerButtons.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
