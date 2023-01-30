using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    private Rigidbody playerRb;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    public int maxJump = 2;
    private int jump;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(0);
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
       Physics.gravity *= gravityModifier;
       playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R) && !gameOver)
        {
            score += 5;
            UpdateScore(0);
        }
        if (!gameOver)
        {
        score += 1;
        UpdateScore(0);
        } 
        if (Input.GetKeyDown(KeyCode.Space) && jump < maxJump && !gameOver)
        {
             playerAudio.PlayOneShot(jumpSound, 1.0f);
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            jump++;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
        }
        
    }
    
    
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jump = 0;
            isOnGround = true;
            dirtParticle.Play();
        }
         else if (collision.gameObject.CompareTag("Obstacle")) 
        {
            playerAudio.PlayOneShot(crashSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
        }
    }
    public void UpdateScore(int scoreToAdd)
    {
        scoreText.text = "Score: " + score;
    }
}