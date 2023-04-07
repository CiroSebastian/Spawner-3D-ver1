using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reiniciar : MonoBehaviour
{
    public float health = 100f; 
    public float damage = 10f; 
    public Transform respawnPoint;

    public Text Salud;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health -= damage; 
            if (health <= 0f)
            {
                Die(); 
            }
            else
            {
                Respawn(); 
            }
        }
    }

    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }

    void Respawn()
    {
        transform.position = respawnPoint.position; 
    }

    private void Update()
    {
        Salud.text = "Salud: " + health.ToString();
    }
}
