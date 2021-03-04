using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideBackground : MonoBehaviour
{
  private SpriteRenderer spriteRenderer;
  private Color color = new Color(0f,0f,0f,255f);
  private float tempa = 1f;
  private float velocity = 0.0f;
  public bool isFaded;

  void Start()
  {
      spriteRenderer = GetComponent<SpriteRenderer>();
  }
  void Update()
  {
      if(isFaded == false)
    {
      FadeOut();
    }
    if(isFaded == true)
    {
        FadeIn();
    }
  }
  public void FadeOut()
  {
      if(tempa > 0)
      {
      tempa = Mathf.SmoothDamp(tempa, 0f, ref velocity, .1f);
      spriteRenderer.color = new Color(0f,0f,0f,tempa);
    }
  }
  public void FadeIn()
  {
      if(tempa <= 1)
      {
        tempa = Mathf.SmoothDamp(tempa, 1f, ref velocity, .1f);
        spriteRenderer.color = new Color(0f,0f,0f,tempa);
      }
  }
}
