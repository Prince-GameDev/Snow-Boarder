using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dust : MonoBehaviour
{
    [SerializeField] ParticleSystem dustPartcle;

     void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag =="Ground")
        {
            dustPartcle.Play();
           
        }
       
    }

    void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground")
        {
            dustPartcle.Stop();
        }
    }

    
}
