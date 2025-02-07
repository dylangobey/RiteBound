using UnityEngine;

[CreateAssetMenu(fileName = "Card_SO", menuName = "Card_SO", order = 1)]
public class CardDescription_SO : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public int mightInt;
    public int riteInt;
    public Sprite cardIcon;
    public CardType cardType;
}

public enum CardType
{
    Dystopian = 0,
    Afterlife = 1,
    Underworld = 2,
    Nature = 3,
    Mystery = 4
}