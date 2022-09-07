using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Inventory : MonoBehaviour
{
    public Text DiamondCounter;
    public Text coinCounter;

    private int Diamond = 0;
    private int coin = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("collectible"))
        {
            Collect(other.GetComponent<collectible>());
        }

    }

    private void Collect(collectible collectible)
    {
        if (collectible.Collect())
        {
            if(collectible is Diamondcollectible)
            {
                Diamond++;
            }
            else if(collectible is coincollectible)
            {
                coin++;
            }
            UpdateGUI();
        }
    }

    private void UpdateGUI()
    {
        DiamondCounter.text = Diamond.ToString();
        coinCounter.text = coin.ToString();
    }
}
