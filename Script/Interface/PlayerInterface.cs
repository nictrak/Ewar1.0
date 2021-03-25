using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInterface : MonoBehaviour
{
    [SerializeField]
    private Text populationText;
    [SerializeField]
    private Text sizeText;
    [SerializeField]
    private Text brainText;
    [SerializeField]
    private Text intestineText;
    [SerializeField]
    private Text stomachText;

    [SerializeField]
    private Text fishText;
    [SerializeField]
    private Text meatText;
    [SerializeField]
    private Text leafText;
    [SerializeField]
    private Text grassText;
    [SerializeField]
    private Text fruitText;

    [SerializeField]
    private Text attackText;
    [SerializeField]
    private Text defenseText;

    [SerializeField]
    private Text dnaText;

    private Player player;

    [SerializeField]
    private int updateFrame;

    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(counter >= updateFrame)
        {
            UpdateInterface();
            counter = 0;
        }counter++;
    }

    private void UpdateInterface()
    {
        populationText.text = player.Status.Population.ToString();
        sizeText.text = player.Status.Size.ToString();
        brainText.text = player.Status.Brain.ToString();
        intestineText.text = player.Status.Intestine.ToString();
        stomachText.text = player.Status.Stomach.ToString();

        fishText.text = player.FoodValue.FishValue.ToString();
        meatText.text = player.FoodValue.MeatValue.ToString();
        leafText.text = player.FoodValue.LeafValue.ToString();
        grassText.text = player.FoodValue.GrassValue.ToString();
        fruitText.text = player.FoodValue.FruitValue.ToString();

        attackText.text = player.Combat.Attack.ToString();
        defenseText.text = player.Combat.Defense.ToString();

        dnaText.text = player.Dna.ToString();
    }
}
