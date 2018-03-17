using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterButtonBehavior : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    private Button pb;
    public Sprite newSprite;
    public Sprite oldSprite;

    void Start()
    {
        pb = GetComponent<Button>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        pb.image.sprite = newSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        pb.image.sprite = oldSprite;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
