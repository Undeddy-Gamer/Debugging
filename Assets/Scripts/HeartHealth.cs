using UnityEngine;
using UnityEngine.UI;

public class HeartHealth : MonoBehaviour
{
    [Header("Player Stats")]
    public float curHealth;
    public float maxHealth;
    [Header("Heart Slots")]
    public Image[] heartSlots;
    public Sprite[] heartSprites;

    private float healthPerSection;
    

    private void Start()
    {
        //Calculate the health points per section
        healthPerSection = maxHealth / (heartSlots.Length * 4);
    }

    private void Update()
    {
        UpdateHeart();
    }


    void UpdateHeart()
    {
        
        //for all the hearts in heart slots        
        
        for (int i = 0; i < heartSlots.Length; i++)
        {
            if (curHealth >= (healthPerSection * 4) + healthPerSection*4*i)
            {
                heartSlots[i].sprite = heartSprites[0];
            }
            else if (curHealth >= (healthPerSection * 3) + healthPerSection * 4 * i)
            {
                heartSlots[i].sprite = heartSprites[1];
            }
            else if (curHealth >= (healthPerSection * 2) + healthPerSection * 4 * i)
            {
                heartSlots[i].sprite = heartSprites[2];
            }
            else if (curHealth >= (healthPerSection * 1) + healthPerSection * 4 * i)
            {
                heartSlots[i].sprite = heartSprites[3];
            }           
            else
            {
                heartSlots[i].sprite = heartSprites[4];
            }
        }

    }

}



