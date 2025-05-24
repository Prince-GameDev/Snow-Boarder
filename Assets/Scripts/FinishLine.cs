using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float LoadDeday = 2f;
    [SerializeField] ParticleSystem ParticleEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ParticleEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", LoadDeday);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
