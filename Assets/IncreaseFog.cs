using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class IncreaseFog : MonoBehaviour
{
    public Player player;
    public Renderer rend;
    private float change;
    private float playerRan;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        rend = GameObject.Find("Fog").GetComponent<Renderer>();
        rend.material.shader = Shader.Find("FogShader");
        change = 5;
        playerRan = player.distance;
    }

    // Update is called once per frame
    void Update()
    {

        if(playerRan >= 100)
        {
            change += 5;
            rend.material.SetFloat("_FogSize", change);
        }

        if (playerRan >= 400)
        {
            change += 5;
            rend.material.SetFloat("_FogSize", change);
        }


        if (playerRan >= 600)
        {
            change += 5;
            rend.material.SetFloat("_FogSize", change);
        }

        if (playerRan >= 800)
        {
            change += 5;
            rend.material.SetFloat("_FogSize", change);
        }

    }
}
