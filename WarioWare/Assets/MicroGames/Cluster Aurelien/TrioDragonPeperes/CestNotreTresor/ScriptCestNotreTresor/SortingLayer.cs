using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingLayer : MonoBehaviour
{
    /*private SpriteRenderer parentRenderer;

    private List<Obstacle> obstacles = new List<Obstacle>();

    private void Start()
    {
        parentRenderer = transform.parent.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            Obstacle obs = collision.GetComponent<Obstacle>();
            obs.FadeOut();


            if (obstacles.Count == 0 || obs.MySpriteRenderer.sortingOrder - 1 < parentRenderer.sortingOrder)
            {
                parentRenderer.sortingOrder = parentRenderer.sortingOrder = obs.MySpriteRenderer.sortingOrder - 1;
            }

            obstacles.Add(obs);

            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            Obstacle obs = collision.GetComponent<Obstacle>();
            obs.FadeIn();

            obstacles.Remove(obs);


            if (obstacles.Count == 0)
            {
                parentRenderer.sortingOrder = 200;
            }
            else
            {
                obstacles.Sort();
                parentRenderer.sortingOrder = obstacles[0].MySpriteRenderer.sortingOrder - 1;
            }
        }

        transform.parent.GetComponent<SpriteRenderer>().sortingOrder = 200;
    }*/
}
