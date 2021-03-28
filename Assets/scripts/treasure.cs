using UnityEngine;
using UnityEngine.UI;

public class treasure : MonoBehaviour
{
    // public GameManager gameManager;
    public GameObject explosionPrefab;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (GameManager.gm!=null)
            {
            //    Debug.Log("HELLO"); 
               GameManager.gm.Scorexx();
            }
            if (explosionPrefab != null) {
				Instantiate (explosionPrefab, transform.position, Quaternion.identity);
			}
			
			// destroy after collection
			Destroy (gameObject);
        }
    }
}
