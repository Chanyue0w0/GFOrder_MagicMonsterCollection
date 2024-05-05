using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{

    //public List<Card> displayCard = new List<Card>();
    public int displayID = 0;

    public int id;
    public string cardName;
    public int cost;//�l��O��
    public int mana;//��e�x�s�k�ƶq
    public int ability1_power;//�ޯ�1���Ӫk�N�q
    public int ability2_power;//�ޯ�2���Ӫk�ƶq
    public string ability1_Descrpition;
    public string ability2_Descrpition;

    public Text nameText;
    public Text costText;
    public Text ability1_Text;
    public Text ability2_Text;

    public Image thisImage;
    public Image artImage;

    public bool cardBack;//�d�I�O�_�ҥ�
    public GameObject cardBackObject;
    //public static bool staticCardBack;//�d�I�O�_�ҥ� static �A�H�ѥ���ϥΡA�����@���M��ç���Ӫ���


    void Start()
    {
        DisplayCardInfo();


        //displayCard[0] = CardDatabase.cardList[displayID];

        //id = displayCard[0].id;
        //cardName = displayCard[0].cardName;
        //cost = displayCard[0].cost;
        //ability1_power = displayCard[0].ability1_power;
        //ability2_power = displayCard[0].ability2_power;
        //ability1_Descrpition = displayCard[0].ability1_Descrpition;
        //ability2_Descrpition = displayCard[0].ability2_Descrpition;

        //nameText.text = "" + cardName;
        //costText.text = "" + cost;
        //ability1_Text.text = "" + ability1_Descrpition;
        //ability2_Text.text = "" + ability2_Descrpition;
        //artImage.sprite = displayCard[0].thisImage;
    }
    void DisplayCardInfo()
    {
        if (displayID <= CardDatabase.cardList.Count) //displayID �å��W�Xindex
        {
            Card card = CardDatabase.cardList[displayID];

            nameText.text = "" + card.cardName;
            costText.text = "" + card.cost;
            if (card.ability1_Descrpition != "")//�Y���ޯ�
                ability1_Text.text = "" + card.ability1_Descrpition + "\n (Power: " + card.ability1_power + ")";
            else
                ability1_Text.text = "";

            if (card.ability2_Descrpition != "")//�Y���ޯ�
                ability2_Text.text = "" + card.ability2_Descrpition + "\n (Power: " + card.ability2_power + ")";
            else
                ability2_Text.text = "";
            //thisImage = 
            artImage.sprite = Resources.Load<Sprite>(card.imagePath);
        }
        else
        {
            Debug.LogError("Card ID out of range: " + displayID);
        }
    }

    void Update()
    {
        if (cardBack)
            cardBackObject.SetActive(true);
        else
            cardBackObject.SetActive(false);
        //staticCardBack = cardBack;
        //if (cardBack != staticCardBack)
        //{ 
        //    staticCardBack = cardBack;
        //    Debug.Log("staticCardBack updated to: " + staticCardBack);
        //}

    }
}
