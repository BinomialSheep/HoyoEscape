using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    GameObject director;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        this.director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if(transform.position.y  < -5.0f)
        {
            Destroy(gameObject);
        }

        // “–‚½‚è”»’è
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f, r2 = 1.0f;
        if(d < r1 + r2)
        {
            // Õ“Ë
            this.director.GetComponent<GameDirector>().DecreaseHp();
            Destroy(gameObject);
        }

    }
}
