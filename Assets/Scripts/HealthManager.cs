using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 3,
               currentHealth = 0;
    public float offsetX;
    public GameObject startPos;
    public Image HealthImage;

    public Image[] HealthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        renderHearts();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void renderHearts()
    {
        for(int i = 0; i < currentHealth; i++)
        {
            startPos.AddComponent<Image>();
            HealthBar[i] = Instantiate(HealthImage);
            Image temp = startPos.GetComponent<Image>();
            temp = HealthBar[i];
        }
        

    }
}
