using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_bullet : MonoBehaviour
{

    public float bulletSpeed = 10f;
    void Start()
    {
        Audio_manager.instance.PlaySFX(2);
    }

    
    void Update()
    {
        transform.position += new Vector3(-bulletSpeed * transform.localScale.x * Time.deltaTime, 0f, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")|| other.CompareTag("bullet"))
        {
            player_health_control.instant.dealDamage();
        }
        Audio_manager.instance.PlaySFX(1);
        Destroy(gameObject);
    }
}
