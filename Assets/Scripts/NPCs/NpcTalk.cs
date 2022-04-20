using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTalk : MonoBehaviour
{
    
    public bool talks;
    public string message;

    
    public void Message()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
                //Message();
                Debug.Log("Hi daddy, look i catch a lot of Bugs" + collision.gameObject.name + " HAS COLLISIONED with me");
            
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
                //Message();
                Debug.Log("Hi daddy, look i catch a lot of Bugs" + collision.gameObject.name + " HAS COLLISIONED with me");
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }
}
