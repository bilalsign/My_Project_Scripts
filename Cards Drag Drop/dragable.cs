using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dragable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
   public Transform parentToReturnTo = null;
   GameObject placeholder = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = this.transform.parent;
       // Debug.Log("OnBeginDrag");
        
        placeholder = new GameObject();
        placeholder.transform.SetParent(this.transform.parent);

        LayoutElement le = placeholder.AddComponent<LayoutElement>();
        le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
        le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;

        le.flexibleWidth = 0;
        le.flexibleHeight = 0;
        placeholder.transform.SetSiblingIndex ( this.transform.GetSiblingIndex());

        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent); 
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("OnDrag");
        this.transform.position = eventData.position;


        int newSiblingIndex = parentToReturnTo.childCount;

        for(int i=0; i<parentToReturnTo.childCount;i++)
        {
            if(this.transform.position.x < parentToReturnTo.GetChild(i).position.x)
            {
                newSiblingIndex = i;

                if(placeholder.transform.GetSiblingIndex() < newSiblingIndex)
                    newSiblingIndex-- ;

                break;
            }
        }
        placeholder.transform.SetSiblingIndex(newSiblingIndex);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       Debug.Log("OnEndDrag");
       this.transform.SetParent(parentToReturnTo);
       this.transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
       GetComponent<CanvasGroup>().blocksRaycasts = true;
       Destroy(placeholder);

    }
}

