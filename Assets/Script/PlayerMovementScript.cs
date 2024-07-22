using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour
{
    public float health = 50f;
    public Rigidbody rb;
    public float moveForce = 10f;
    public GameObject gameOverPanel;
    public Button restartButton;
    public GameObject gameoverText; 
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        RandomMovement();
        restartButton.enabled = false;
        gameOverPanel.SetActive(false);
        
    }

    public void RandomMovement()
    {
        Vector3 randomDirection = Random.insideUnitSphere.normalized;
        randomDirection.y = 0f;
        rb.AddForce(randomDirection * moveForce , ForceMode.Impulse);
        Invoke("RandomMovement", Random.Range(1f, 2f));
    }

    public void GetDamage(float damage)
    {
        health -= damage;   

        if(health <= 0f)
        {
            Debug.Log("Health");
            //Destroy(this.gameObject);
            restartButton.onClick.AddListener(RestartButtonPress);
            gameOverPanel.SetActive(true);
            restartButton.enabled = true;


        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("bullet"))
        {
            Debug.Log("bullet touch");
            GetDamage(10f);
        }
    }

    public void RestartButtonPress()
    {
        SceneManager.LoadScene(0);
        
       
    }
}
