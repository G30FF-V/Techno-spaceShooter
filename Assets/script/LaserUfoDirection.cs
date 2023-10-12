using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserUfoDirection : MonoBehaviour
{
    [SerializeField] float speed;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Vaisseau"))
        {
            Destroy(this.gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        
    }
}
