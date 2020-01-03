using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public static Bird birdInstant = null;
    [SerializeField] private bool BirdDead = false;
    [SerializeField] private Rigidbody2D rgBird;
    [SerializeField] private Animator aniBrid;
    [SerializeField] private  float UpForce;
    public int sorce;
    
    private void Start()
    { 
        if (birdInstant == null)
        {
            birdInstant = this;
        }
        else
        {
            if(birdInstant != this)
            {
                Destroy(gameObject);
            }
        }
      
    }
    void Update()
    {
        if (BirdDead == false)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Submit"))
            {
                SoundManager.soundManager.FlappBrid();
                aniBrid.SetBool("Flapp", true);
                rgBird.AddForce(new Vector3 (0,UpForce,0));              
                Debug.Log("Flapp");
                aniBrid.SetBool("Flapp", false);
            }
        }
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Ground"))
        {
            rgBird.velocity = Vector2.zero;
            BirdDead = true;
            aniBrid.SetTrigger("Die");
            Background.instanceBackground.MovingBackground = false;
            Column.ColumnManager.isMovingColumn = false;
            GameManager.gameManager.isActiveColumn = false;
            SoundManager.soundManager.BirdDead();
            SceneManager.LoadScene("GameOver",LoadSceneMode.Single);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision.gameObject.CompareTag("Column"))
        {
            collision.isTrigger = false;
            rgBird.velocity = Vector2.zero;
            BirdDead = true;
            aniBrid.SetTrigger("Die");
            Background.instanceBackground.MovingBackground = false;
            GameManager.gameManager.isActiveColumn = false;       
            Column.ColumnManager.isMovingColumn = false;
            SoundManager.soundManager.BirdDead();
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);

        }
        if (collision.gameObject.CompareTag("Sorce"))
        {
            sorce++;
            SoundManager.soundManager.BridSorce();
        }
    }
}
