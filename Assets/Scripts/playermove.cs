using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermove : MonoBehaviour
{
    public float speed = 0.18f;
    //public float jumph = 500f;
    public Rigidbody2D rb;
    public float jumpAmount = 350f;

    //[SerializeField] AudioClip sndPickup;
    //AudioSource audioSource;

    [SerializeField] ProgressBar pb;
    [SerializeField] GameObject ImGameOver;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //audioSource = GetComponent<audioSource>();
    }

    void Start() 
    { 
        print("Start"); 
    }



    void Update()
    {
        Vector3 dp = new Vector3();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("ok jump");
            //rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
           // rb.AddForce(new Vector2(0, jumpAmount));
            dp.y += jumpAmount;
        }

        

        if (Input.GetKey(KeyCode.A))
        {
            dp.x -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            dp.x += speed;
        }

        transform.position += dp;
    }

    public void ChoukapiDead()
    {
        Debug.Log("Choukapi DEAD");
        GetComponent<playermove>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            //audioSource.PlayOneShot(sndPickup);
        }
    }

    public void GameOver()
    {
        ImGameOver.SetActive(true);
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");

    }
}
