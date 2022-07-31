using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    public void OnMouseDown()
    {
        Redirect redirect = GameObject.Find("Redirection").GetComponent<Redirect>();
        if (redirect.isChoosing)
        {
            redirect.chosenEnemy = gameObject;
            redirect.isChoosing = false;
            redirect.SetAttack();
        }
    }
}
