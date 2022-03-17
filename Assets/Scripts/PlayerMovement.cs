using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    bool alive = true;

    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplyer = 2f;

    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplyer;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5) // change this to x position that is boardered as the boundary
        {
            Die();
        }
    }

    public void Die()
    {
        alive = false;
        //restart the game
        Invoke("Restart", 2); //calls to restart after 2 seconds
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //change this to menu scene number
    }

}
