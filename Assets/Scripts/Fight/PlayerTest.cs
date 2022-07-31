using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    public bool isAttacking = false;
    public void OnMouseDown()
    {
        if (!isAttacking)
        {
            GameObject playerButtons = GameObject.Find("ObjectEnabler");
            playerButtons.GetComponent<EnableObject>().playerButtons.SetActive(true);
            playerButtons.GetComponent<EnableObject>().playerButtons.transform.Find("AttackButton").GetComponent<AttackButton>().player = gameObject;
        }
    }
}
