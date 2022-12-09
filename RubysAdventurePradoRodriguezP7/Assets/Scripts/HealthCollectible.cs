using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class HealthCollectible : MonoBehaviour
{ 
 public void OnTriggerEnter2(Collider2D other)  
 {
    RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}