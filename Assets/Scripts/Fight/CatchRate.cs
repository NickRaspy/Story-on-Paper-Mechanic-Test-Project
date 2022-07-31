using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchRate : MonoBehaviour
{
    public float MCR; //Modified catch rate
    public float hpMax;
    public float hpCurrent;
    public float rate;
    public float ball;
    public float status;
    public float shakeProbability;

    public void TryCatch()
    {
        int attemptedShake = 0;
        MCR = (3f * hpMax - 2f * hpCurrent) * rate * ball / (3f * hpMax) * status;
        shakeProbability = 65536/Mathf.Pow(255/MCR, 0.1875f);
        Debug.Log("MCR: " + MCR);
        Debug.Log("Shake Probability: " + shakeProbability);
        //Critical catch
        if(MCR >= 255f)
        {
            Debug.Log("Successful catch");
        }
        else
        {
            //3 shakes, if random number will be 
            for (int i = 1; i < 4; i++)
            {
                int random = Random.Range(0, 65535);
                if (random < shakeProbability)
                {
                    Debug.Log("Random: " + random + " < " + "Shake Probability: " + shakeProbability);
                    attemptedShake++;
                    Debug.Log("Attempted Shake: " + attemptedShake);
                }
                else
                {
                    Debug.Log("Random: " + random + " >= " + "Shake Probability: " + shakeProbability);
                    break;
                }
            }
            if (attemptedShake == 3)
            {
                Debug.Log("Successful catch");
            }
            else
            {
                Debug.Log("Unsuccessful catch");
            }
        }
    }
}
