using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class AddElements : MonoBehaviour
{
    public TMP_Text emptyListText;
    [SerializeField] private Transform scrollViewContent;

    [SerializeField] private Button prefab;
    [SerializeField] private Sprite[] modelIcons;
    [SerializeField] private Button englishButton;

    [SerializeField] private Button italianButton;
    // Start is called before the first frame update
    void Start()
    {
        //ButtonManager.ColosseumFav = true;
        //ButtonManager.NFav = 1;
        if (LanguageSetting.Language == "italian")
        {
            Instantiate(englishButton);
            englishButton.gameObject.SetActive(true);
        }
        else
        {
            Instantiate(italianButton);
            italianButton.gameObject.SetActive(true);
        }
      
        if (ButtonManager.NFav == 0)
        {
            emptyListText.text = LanguageSetting.Language == "italian"
                ? "Non ci sono ancora elementi salvati."
                : "There are no favorite items yet.";
            emptyListText.gameObject.SetActive(true);
        }
        else
        {
            if (ButtonManager.ColosseumFav)
            {
                var colosseum = Instantiate(prefab, scrollViewContent);
                colosseum.name = "Colosseum";
                colosseum.transform.GetChild(0).GetComponent<Image>().sprite = modelIcons[0];
                colosseum.GetComponentInChildren<TMP_Text>().text = LanguageSetting.Language == "italian" ? "Colosseo" : "Colosseum";
                colosseum.gameObject.SetActive(true);
                
            }
            if (ButtonManager.StonehengeFav)
            { 
                var stonehenge = Instantiate(prefab, scrollViewContent);
                stonehenge.name = "Stonehenge";
                stonehenge.transform.GetChild(0).GetComponent<Image>().sprite = modelIcons[1];
                stonehenge.GetComponentInChildren<TMP_Text>().text = "Stonehenge";
                stonehenge.gameObject.SetActive(true);
            }
            if (ButtonManager.BigBenFav)
            {
                var bigBen = Instantiate(prefab, scrollViewContent);
                bigBen.name = "BigBen";
                bigBen.transform.GetChild(0).GetComponent<Image>().sprite = modelIcons[2];
                bigBen.GetComponentInChildren<TMP_Text>().text = "Big Ben";
                bigBen.gameObject.SetActive(true);
            }
            if (ButtonManager.BurjKhalifaFav)
            {
                var burjKhalifa = Instantiate(prefab, scrollViewContent);
                burjKhalifa.name = "BurjKhalifa";
                burjKhalifa.transform.GetChild(0).GetComponent<Image>().sprite = modelIcons[3];
                burjKhalifa.GetComponentInChildren<TMP_Text>().text = "Burj Khalifa";
                burjKhalifa.gameObject.SetActive(true);
            }
            if (ButtonManager.EiffelTowerFav)
            {
                var eiffel = Instantiate(prefab, scrollViewContent);
                eiffel.name = "EiffelTower";
                eiffel.transform.GetChild(0).GetComponent<Image>().sprite = modelIcons[4];
                eiffel.GetComponentInChildren<TMP_Text>().text = LanguageSetting.Language == "italian" ? "Torre Eiffel" : "Eiffel Tower";
                eiffel.gameObject.SetActive(true);
            }
            if (ButtonManager.PisaTowerFav)
            {
                var pisa = Instantiate(prefab, scrollViewContent);
                pisa.name = "PisaTower";
                pisa.transform.GetChild(0).GetComponent<Image>().sprite = modelIcons[5];
                pisa.GetComponentInChildren<TMP_Text>().text = LanguageSetting.Language == "italian" ? "Torre Pendente" : "Leaning Tower";
                pisa.gameObject.SetActive(true);
            }
            if (ButtonManager.WhiteHouseFav)
            { 
                var whiteHouse = Instantiate(prefab, scrollViewContent);
                whiteHouse.name = "WhiteHouse";
                whiteHouse.transform.GetChild(0).GetComponent<Image>().sprite = modelIcons[6];
                whiteHouse.GetComponentInChildren<TMP_Text>().text = LanguageSetting.Language == "italian" ? "Casa Bianca" : "White House"; 
                whiteHouse.gameObject.SetActive(true);
            }
            if (ButtonManager.StatueOfLibertyFav)
            {
                var statueOfLiberty = Instantiate(prefab, scrollViewContent);
                statueOfLiberty.name = "StatueOfLiberty";
                statueOfLiberty.transform.GetChild(0).GetComponent<Image>().sprite = modelIcons[7];
                statueOfLiberty.GetComponentInChildren<TMP_Text>().text = LanguageSetting.Language == "italian" ? "Statua della liberta'" : "Statue of Liberty";
                statueOfLiberty.gameObject.SetActive(true);
            }
            if (ButtonManager.TajMahalFav)
            {
                var tajMahal = Instantiate(prefab, scrollViewContent);
                tajMahal.name = "TajMahal";
                tajMahal.transform.GetChild(0).GetComponent<Image>().sprite = modelIcons[8];
                tajMahal.GetComponentInChildren<TMP_Text>().text = "Taj Mahal";
                tajMahal.gameObject.SetActive(true);

            }
            if (ButtonManager.EmpirestateBuildingFav)
            {
                var empireState = Instantiate(prefab, scrollViewContent);
                empireState.name = "EmpireStateBuilding";
                empireState.transform.GetChild(0).GetComponent<Image>().sprite = modelIcons[9];
                empireState.GetComponentInChildren<TMP_Text>().text = "Empire State Building";
                empireState.gameObject.SetActive(true);
            }

        }
    }
    
    

}