using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Text Text;

    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<Timer>().enabled = false;
        Text.fontSize = 90;
        Text.color = Color.green;
    }
}
