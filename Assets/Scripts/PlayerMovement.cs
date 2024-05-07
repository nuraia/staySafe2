using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) && gameObject.transform.position.y <= 3.87f) { 
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, 
                gameObject.transform.position.y + playerSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S) && gameObject.transform.position.y >= -3.87f)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x,
               gameObject.transform.position.y - playerSpeed * Time.deltaTime);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            GameManager.instance.GameOver();
        }
    }
   
}
