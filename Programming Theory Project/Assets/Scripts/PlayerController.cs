using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float jumpHeight = 10;
    public bool isOnGround = true;
    private Rigidbody playerRb;

    // Update is called once per frame
    public void Update()
    {
        PlayerMovement();
    }

    public void PlayerMovement()
    {
        //Player Movement Left and Right
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Player Can only Jump when on Ground, also only when the game isnt over.
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb = GetComponent<Rigidbody>();
            playerRb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
