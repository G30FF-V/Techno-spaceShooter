using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasergauche : MonoBehaviour
{
    [SerializeField] int speed;
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
        transform.Translate(Vector3.left * Time.deltaTime * speed);

    }
}
