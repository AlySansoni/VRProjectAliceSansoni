using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class LanguageFavoriteManager : MonoBehaviour
{ 
    
    public Button englishButton;
    public Button italianButton;
    public GameObject confirmLanguageChange;
    public GameObject confirmRemoveFav;
    public GameObject removedFav;
    [FormerlySerializedAs("_pendingModel")] public static string PendingModel;

    public void SwitchLanguage()
    {
        TMP_Text phrase = confirmLanguageChange.GetComponentInChildren<TMP_Text>();
        Button[] confirmButtons = confirmLanguageChange.GetComponentsInChildren<Button>();
        
        if (LanguageSetting.Language == "italian")
        {
            phrase.text = "Confermi di voler cambiare lingua?";
            confirmButtons[0].GetComponentInChildren<TMP_Text>().text = "Conferma";
            confirmButtons[1].GetComponentInChildren<TMP_Text>().text = "Annulla";
            englishButton.gameObject.SetActive(false);

        }
        else
        {
            phrase.text = "Are you sure you want to change the language?";
            confirmButtons[0].GetComponentInChildren<TMP_Text>().text = "Confirm";
            confirmButtons[1].GetComponentInChildren<TMP_Text>().text = "Delete";
            italianButton.gameObject.SetActive(false);
        }

        confirmLanguageChange.SetActive(true);
    }
    
    
    public void ConfirmLanChange()
    {
        if (LanguageSetting.Language == "italian")
        {
            LanguageSetting.Language = "english";
            englishButton.gameObject.SetActive(false);
            italianButton.gameObject.SetActive(true);
        }
        else
        {
            LanguageSetting.Language = "italian";
            englishButton.gameObject.SetActive(true);
            italianButton.gameObject.SetActive(false);
        }
        
        confirmLanguageChange.SetActive(false);
        SceneManager.LoadScene("FavouriteList");
    }
    
    public void DeleteLanChange()
    {
        confirmLanguageChange.SetActive(false);
        if (LanguageSetting.Language == "italian")
        {
            englishButton.gameObject.SetActive(true);
        }
        else
        {
            italianButton.gameObject.SetActive(true);
        }
    }
    

    public void ONTrashClick(Button favButton)
    {
        PendingModel = favButton.name;
        ShowConfirmRemoveModel();
    }

    private void ShowConfirmRemoveModel()
    {
        TMP_Text phrase = confirmRemoveFav.GetComponentInChildren<TMP_Text>();
        Button[] confirmFavButtons = confirmRemoveFav.GetComponentsInChildren<Button>();
        
        if (LanguageSetting.Language == "italian")
        {
            phrase.text = "Confermi di voler rimuovere l'elemento selezionato dai preferiti?";
            confirmFavButtons[0].GetComponentInChildren<TMP_Text>().text = "Conferma";
            confirmFavButtons[1].GetComponentInChildren<TMP_Text>().text = "Annulla";

        }
        else
        {
            phrase.text = "Are you sure you want to remove the selected element from favourites?";
            confirmFavButtons[0].GetComponentInChildren<TMP_Text>().text = "Confirm";
            confirmFavButtons[1].GetComponentInChildren<TMP_Text>().text = "Delete";
        }
        
        confirmRemoveFav.SetActive(true);
    }

    public void ConfirmRemoveModel()
    {
        TMP_Text confPhrase = removedFav.GetComponentInChildren<TMP_Text>();
        switch (PendingModel)
        {
            case "Colosseum":
                ButtonManager.ColosseumFav = false;
                PlayerPrefs.SetInt("Colosseum", 0);
                break;
            case "Stonehenge":
                ButtonManager.StonehengeFav = false;
                PlayerPrefs.SetInt("Stonehenge", 0);
                break;
            case "BigBen":
                ButtonManager.BigBenFav = false;
                PlayerPrefs.SetInt("BigBen", 0);
                break;
            case "BurKhalifa":
                ButtonManager.BurjKhalifaFav = false;
                PlayerPrefs.SetInt("BurjKhalifa", 0);
                break;
            case "EiffelTower":
                ButtonManager.EiffelTowerFav = false;
                PlayerPrefs.SetInt("EiffelTower", 0);
                break;
            case "PisaTower":
                ButtonManager.PisaTowerFav = false;
                PlayerPrefs.SetInt("PisaTower", 0);
                break;
            case "WhiteHouse":
                ButtonManager.WhiteHouseFav = false;
                PlayerPrefs.SetInt("WhiteHouse", 0);
                break;
            case "StatueOfLiberty":
                ButtonManager.StonehengeFav = false;
                PlayerPrefs.SetInt("StatueOfLiberty", 0);
                break;
            case "TajMahal":
                ButtonManager.TajMahalFav = false;
                PlayerPrefs.SetInt("TajMahal", 0);
                break;
            case "EmpireStateBuilding":
                ButtonManager.EmpirestateBuildingFav = false;
                PlayerPrefs.SetInt("EmpireState", 0);
                break; 
        }

        ButtonManager.NFav--;
        PlayerPrefs.SetInt("NFav", ButtonManager.NFav);
        confirmRemoveFav.SetActive(false);
        if (LanguageSetting.Language == "italian")
            confPhrase.text = "Rimosso dai preferiti";
        else
            confPhrase.text = "Removed from favourites";
        
        //Destroy(GameObject.Find(PendingModel));
        removedFav.SetActive(true);
        Invoke("HidePanel", 1f);
        SceneManager.LoadScene("FavouriteList");

    }
    
    private void HidePanel()
    {
        removedFav.SetActive(false);
    }
    
    public void DeleteRemoveModel()
    {
        confirmRemoveFav.SetActive(false);
    }
    
    public void ONModelClick(Button favButton)
    {
        PendingModel = favButton.name;
        SceneManager.LoadScene("3DView");
    }


    

}
