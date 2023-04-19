using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] ProgressBar pbFood;

    [SerializeField] float decreaseFood = 1f, decreaseRate = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DecreaseHunger());
    }

 

    IEnumerator DecreaseHunger()
    {
        while(pbFood.Val>0)
        {
            pbFood.Val -= decreaseFood;
            yield return new WaitForSeconds(decreaseRate);
        }

        GameObject.FindGameObjectWithTag("Player").GetComponent<playermove>().ChoukapiDead();
    }
}
