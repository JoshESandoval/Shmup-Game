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
    public GameObject HealthImage;
    public bool gameover = false;
    float deathScreen = 0;



    // Start is called before the first frame update
    void Start()
    {
        gameover = false;
        currentHealth = maxHealth;
        RenderHearts();
    }


    // Update is called once per frame
    void Update()
    {
        if(currentHealth == 0)
        {
            gameover = true;
        }

        if (gameover)
        {
            deathScreen += Time.deltaTime;
            if (Input.anyKey && deathScreen > 8)
            {
                gameover = false;
            }
        }


    }

    public void RenderHearts()
    {

        for (int i = 0; i < currentHealth; i++)
        {
            GameObject heart = Instantiate(HealthImage);
            heart.transform.SetParent(startPos.transform);
            heart.transform.localScale = new Vector3(1, 1, 1);
        }

    }

    public void RemoveHearts() {
        currentHealth--;

        if (startPos.transform.childCount > 0 && !gameover)
        {
            int child = startPos.transform.childCount;
            Destroy(startPos.transform.GetChild(child - 1).gameObject);
        }
    }


}
