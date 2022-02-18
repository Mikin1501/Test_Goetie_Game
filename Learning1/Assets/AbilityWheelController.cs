using UnityEngine;
using UnityEngine.UI;


public class AbilityWheelController : MonoBehaviour
{
    public Animator anim;
    private bool abilitywheelSelected = false;
    public Image selectedItem;
    public Sprite noImage;
    public static int abilityID;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            abilitywheelSelected = !abilitywheelSelected;
        }

        if (abilitywheelSelected)
        {
            anim.SetBool("OpenAbilityWheel", true);
        }
        else
        {
            anim.SetBool("OpenAbilityWheel", false);
        }

        switch (abilityID)
        {
            case 0: //není vybráno nic
                selectedItem.sprite = noImage;
                break;
            case 1: //Bael
                Debug.Log("Bael");
                break;
            case 2: //Belial
                Debug.Log("Belial");
                break;
            case 3: //Balam
                Debug.Log("Balam");
                break;
            case 4: //Vine
                Debug.Log("Vine");
                break;
            case 5: //Zagan
                Debug.Log("Zagan");
                break;
            case 6: //Asmoday
                Debug.Log("Asmoday");
                break;
            case 7: //Beleth
                Debug.Log("Beleth");
                break;
        }
    }
}
