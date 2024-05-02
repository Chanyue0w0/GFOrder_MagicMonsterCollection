using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{

    public static List<Card> displayCard = new List<Card>();
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

    public Image artImage;


    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayID];
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        ability1_power = displayCard[0].ability1_power;
        ability2_power = displayCard[0].ability2_power;
        ability1_Descrpition = displayCard[0].ability1_Descrpition;
        ability2_Descrpition = displayCard[0].ability2_Descrpition;

        nameText.text = cardName;
        costText.text = cost.ToString();
        ability1_Text.text = ability1_Descrpition;
        ability2_Text.text = ability2_Descrpition;
        artImage.sprite = displayCard[0].thisImage;
    }

    void Update()
    {
        

    }
}
