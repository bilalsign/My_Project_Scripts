using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public int colleect;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
        {
            coinCount += 1;
            other.gameObject.SetActive(false);
            Debug.Log("Collected");

        }
        else if (other.gameObject.tag == "Boss")
        {
            coinCount -= 2;
            other.gameObject.SetActive(false);
            Debug.Log("Enemy Boss");
        }
        else if (other.gameObject.tag == "Enemy")
        {
            coinCount -= 1;
            other.gameObject.SetActive(false);
            Debug.Log("Enemy");
        }


    }

    public void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = "" + coinCount;
    }

}
