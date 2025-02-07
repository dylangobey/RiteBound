using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public CardDescription_SO activeCard;
    
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _cardName;
    [SerializeField] private TextMeshProUGUI _cardDescription;
    [SerializeField] private TextMeshProUGUI _might;
    [SerializeField] private TextMeshProUGUI _rite;
    [SerializeField] private TextMeshProUGUI _cardType;

    private void Start()
    {
        _image.sprite = activeCard.cardIcon;
        _cardName.text = activeCard.cardName;
        _cardDescription.text = activeCard.cardDescription;
        _might.text = activeCard.mightInt.ToString();
        _rite.text = activeCard.riteInt.ToString();
        int enumInt = (int)activeCard.cardType;
        _cardType.text = enumInt.ToString();
    }
}
