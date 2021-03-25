using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupInterface : MonoBehaviour
{
    [SerializeField]
    private InputField numberField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressNext()
    {
        int numberOfPlayer = -1;
        bool isPass = false;
        try
        {
            numberOfPlayer = int.Parse(numberField.text);
            if(numberOfPlayer >= 2 && numberOfPlayer <= 4)
            {
                isPass = true;
            }
            else
            {
                Debug.LogWarning("Number must be 2 to 4");
            }
        }
        catch
        {
            Debug.LogWarning("Number only");
        }
        if (isPass)
        {
            GameSystem.Instance.Setup(numberOfPlayer);
            gameObject.SetActive(false);
        }
    }
}
