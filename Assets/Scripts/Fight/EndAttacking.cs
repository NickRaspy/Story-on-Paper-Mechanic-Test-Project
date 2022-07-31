using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndAttacking : MonoBehaviour
{
    public bool set = false;
    private int hp = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartAttack()
    {
        GetComponent<PlayerAttack>().notAttack = false;
    }
    public void Damage()
    {
        GameObject enemyHP = GameObject.Find("Canvas").transform.Find("EnemyHP").gameObject;
        hp = int.Parse(enemyHP.GetComponent<Text>().text);
        enemyHP.GetComponent<Text>().text = (hp - 10).ToString();
    }

    public void EndAttack()
    {
        GetComponent<PlayerAttack>().isReached = false;
        GetComponent<PlayerAttack>().goBack = true;
    }
}
