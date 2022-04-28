using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RedLightGreenLight : MonoBehaviour
{

    public float speed;
    Vector3 movementVector;

    public float minRedTime, maxRedTIme, minGreenTime, maxGreenTime;
    public bool wonGame, canMove;
    bool reactionTimeActive;
    public Transform respawnPoint;
    public MeshRenderer stoplight;
    public Color greenColor, redColor;
    public float reactionTime = .4f;



    // Start is called before the first frame update
    void Start()
    {
        canMove = false;
        StartCoroutine(RLGL());
        wonGame = false;
        reactionTimeActive = false;
     
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            transform.position = transform.position + movementVector * Time.deltaTime * speed;
        }
        else
        {
            if(movementVector.magnitude > .1f && !reactionTimeActive)
            {
                // move player back to start if they try to move during red light
                transform.position = respawnPoint.position;
            }
        }
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 movementVector2 = context.ReadValue<Vector2>();
        movementVector = new Vector3(movementVector2.x, 0, movementVector2.y);
    }

    IEnumerator RLGL()
    {
        while (!wonGame)
        {
            if (canMove)
            {
                // set light to red
                canMove = false;
                stoplight.material.color = redColor;
                StartCoroutine(ReactionTime());

                yield return new WaitForSeconds(Random.Range(minRedTime, maxRedTIme));

            }
            else

            {
                canMove = true;
                stoplight.material.color = greenColor;
                yield return new WaitForSeconds(Random.Range(minGreenTime, maxGreenTime));
            }

        }
    }
    IEnumerator ReactionTime()
    {
        reactionTimeActive = true;
        yield return new WaitForSeconds(reactionTime);
        reactionTimeActive = false;


    }
}
