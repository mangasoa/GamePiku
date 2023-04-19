using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
    [SerializeField] private int startCountDown = 60;

    [SerializeField] TextMeshProUGUI TxtCountDown;
    // Start is called before the first frame update
    void Start()
    {
        TxtCountDown.text = "Time left : " + startCountDown;
        StartCoroutine(Pause());
    }

    IEnumerator Pause()
    {
        while (startCountDown>0)
        {
            yield return new WaitForSeconds(1f);
            startCountDown--;
            TxtCountDown.text = "Time left : " + startCountDown;

        }
        Debug.Log("U are DEAD");
        //GameObject.Find("Player").GetComponent<playermove>().GameOver();
        GameObject.Find("Player").GetComponent<playermove>().GameOver();
        
    }
}
