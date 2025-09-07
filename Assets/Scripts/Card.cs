using UnityEngine;
using DG.Tweening;

public class Card : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer CardRenderer;

    [SerializeField]
    private Sprite animalSprite;


    [SerializeField]
    private Sprite backSprite;

    private bool isFlipped= false;
    private bool isFlipping=false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FlipCard()
    {

        isFlipping = true;

        Vector3 originalScale = transform.localScale;
        Vector3 targetScale = new Vector3(0f, originalScale.y, originalScale.z);

        transform.DOScale(targetScale, 0.2f).OnComplete(() =>
        {
            isFlipped = !isFlipped;

            if (isFlipped)
            {
                CardRenderer.sprite = animalSprite;
            }
            else
            {
                CardRenderer.sprite = backSprite;
            }

            transform.DOScale(originalScale, 0.2f).OnComplete(() => 
            {
                isFlipping = false;
            }
            );

        }
        );

        


        
    }

    void OnMouseDown()
    {
        if(!isFlipping)  //if(isFlipping==false){}랑 같은말
        {  
            FlipCard();   
        }
    }
}
