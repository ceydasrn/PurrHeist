using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatM : MonoBehaviour
{
   public bool isDead;
   public float moveSpeed = 5f;
   public Rigidbody2D rb;
   public Animator animator;
   Vector2 movement;
   public GameManager managerGame;

   [SerializeField] private AudioSource collectionSoundEffect;

   void Update()
   {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
   }

   void FixedUpdate()
   {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
          if(other.CompareTag("Death"))
          {
               isDead = true;
               Time.timeScale = 0;
               SceneManager.LoadSceneAsync(2);
          }
          if(other.CompareTag("ScoreArea"))
          {
               collectionSoundEffect.Play();
               managerGame.UpdateScore();
          }
   }
}
