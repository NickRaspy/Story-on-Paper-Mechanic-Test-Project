using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Vector3 ePos;
    public bool isReached = false;
    public bool goBack = false;
    public bool isGoing = false;
    public bool notAttack = true;
    public bool isReady = false;
    // Update is called once per frame
    void Update()
    {
        if (isReady)
        {
            if (isGoing)
            {
                transform.position = Vector3.Lerp(transform.position, ePos, Time.deltaTime * 10);
            }
            if (transform.position == ePos)
            {
                isGoing = false;
                isReached = true;
            }
            if (isReached && notAttack)
            {
                GetComponent<Animator>().Play("Attack");
            }
            if (goBack)
            {
                transform.position = Vector3.Lerp(transform.position, transform.parent.transform.position, Time.deltaTime * 10);
            }
            if (transform.position == transform.parent.transform.position)
            {
                notAttack = true;
                isReached = false;
                goBack = false;
                isReady = false;
                GetComponent<PlayerTest>().isAttacking = false;
            }
        }
    }
}
