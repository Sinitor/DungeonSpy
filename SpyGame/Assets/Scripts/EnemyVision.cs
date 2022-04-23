using UnityEngine;
using UnityEngine.UI;

public class EnemyVision : MonoBehaviour
{
    public Image loseImage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            loseImage.gameObject.SetActive(true);
        }
    }
}
