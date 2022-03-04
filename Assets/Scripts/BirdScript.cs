using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class BirdScript : MonoBehaviour
{
    // this global variable will be set from the inspector.
    public Vector2 jumpForce = new Vector2(); //Represents bird jump force

    void Start()
    {
        // position the bird
        transform.position = new Vector2(-2f, 0f);
    }

    void Update()
    {
        // waiting for mouse input
        if (Input.GetButtonDown("Fire1"))
        {
            // setting bird's Rigidbody2D velocity to zero
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            // adding jump force to bird's rigid body
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }
        // getting the real position, of the bird on the stage
        Vector2 stagePos = Camera.main.WorldToScreenPoint(transform.position);
        // if the bird leaves the stage...
        if (stagePos.y > Screen.height || stagePos.y < 0)
        {
            // ... call die function
            StartCoroutine("Die");
        }
    }
    // function to be executed once the bird enters in collision with anything
    void OnCollisionEnter2D()
    {
        // call die function
        StartCoroutine("Die");
    }

    IEnumerator Die()
    {
        // reload the current scene - actually restart the game
        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene("Level_02");
    }
}
