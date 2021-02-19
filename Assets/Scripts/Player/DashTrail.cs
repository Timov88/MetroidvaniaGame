using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashTrail : MonoBehaviour
{
    List<GameObject> trailParts = new List<GameObject>();
    void SpawnTrailPart()
    {
        GameObject trailPart = new GameObject();
        SpriteRenderer trailPartRenderer = trailPart.AddComponent<SpriteRenderer>();
        trailPartRenderer.sprite = GetComponent<SpriteRenderer>().sprite;
        trailPart.transform.position = transform.position;
        //if child object use
        //trailPart.transform.localScale = transform.parent.transform.localScale;
        trailPart.transform.localScale = transform.localScale;
        trailParts.Add(trailPart);
        

        StartCoroutine(FadeTrailPart(trailPartRenderer));
        Destroy(trailPart, 0.3f); // replace 0.5f with needed lifeTime
    }

    IEnumerator FadeTrailPart(SpriteRenderer trailPartRenderer)
    {
        
        Color color = trailPartRenderer.color;
        color.a -= 0.5f;
        color.r -= 0.2f;
        color.g -= 0.4f;// replace 0.5f with needed alpha decrement
        trailPartRenderer.color = color;

        yield return new WaitForEndOfFrame();
        
    }
    IEnumerator DestroyTrailPart(GameObject trailPart, float delay)
    {
        yield return new WaitForSeconds(delay);

        trailParts.Remove(trailPart);
        Destroy(trailPart);
    }
    public void FlipTrail()
    {
        if(trailParts.Count != 0)
        {
            foreach (GameObject trailPart in trailParts)
            {
                if(trailPart != null)
                {
                    Vector3 trailPartLocalScale = trailPart.transform.localScale;
                    trailPartLocalScale.x = transform.parent.localScale.x;
                    trailPart.transform.localScale = transform.parent.localScale;
                }
                
            }
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
