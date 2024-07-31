using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    Player player;
    TMP_Text distanceText;

    GameObject results;
    TMP_Text finalDistanceText;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        distanceText = GameObject.Find("DistanceText").GetComponent<TMP_Text>();
        results = GameObject.Find("Results");
        finalDistanceText = GameObject.Find("FinalDistanceText").GetComponent<TMP_Text>();

        results.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int distance = Mathf.FloorToInt(player.distance);
        distanceText.text = "Score" + ": " + distance;

        if (player.isDead)
        {
            results.SetActive(true);
            finalDistanceText.text = "Score" + ": "+ distance;
        }
    }


    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }

    
}
