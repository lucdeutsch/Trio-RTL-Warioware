using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadioRTL
{
    /// <summary>
    /// Théo Valet
    /// </summary>
}
public class PlayerBehavior : MonoBehaviour
{
    public bool strikeUnlock = false;
    public Sprite preparation;
    public Sprite frappe;
    public Sprite frappe2;
    Sprite baseSprite;
    public float animFrappe;
    bool isInAnim;

    private void Start()
    {
        baseSprite = gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    void Update()
    {

        if (Input.GetKey("a"))
        {
            strikeUnlock = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = preparation;
        }
        else if (strikeUnlock)
        {
            StartCoroutine(animfrappe());
        }
        else if (!strikeUnlock)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = baseSprite;
        }
    }
    IEnumerator animfrappe()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = frappe;
        yield return new WaitForSeconds(animFrappe);
        strikeUnlock = false;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(Input.GetKeyUp("a"))
        {
            NormalCrabBehaviour ncb = other.GetComponent<NormalCrabBehaviour>();
            CrabParrotBehavior cpb = other.GetComponent<CrabParrotBehavior>();

            if(ncb != null)
            {
                ncb.isShot = true;
            }
            else if (cpb != null)
            {
                cpb.isShot = true;
            }
        }
    }
  
}
