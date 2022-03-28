using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameGanarator : MonoBehaviour
{
    public InputField nameField, numberSymbolsField;
    void Start()
    {
        numberSymbolsField.text = "6";
        nameField.text = GenerateName(int.Parse(numberSymbolsField.text));
    }

    public static string GenerateName(int len)
    {
        System.Random r = new System.Random();
        string[] consonants = { "б", "в", "г" , "д" , "ж" , "з" , "к" , "л" , "м" , "н" , "п" , "р" , "с" , "т" , "ф" , "х" , "ц" , "ч" , "ш" , "щ" };
        string[] volwels = { "а", "е", "ё", "и", "э", "ю", "я", "о", "у" };
        string name = "";
        name += consonants[r.Next(consonants.Length)].ToUpper();
        name += volwels[r.Next(volwels.Length)];
        int b = 2; //b показывает, сколько символов уже есть в имени. На данный момент она равна 2
        int intlen = 3;
        while (b < len)
        {
            name += consonants[r.Next(consonants.Length)];
            b++;
            name += volwels[r.Next(volwels.Length)];
            b++;
        }
        for (int i = 0; i < intlen; i++)
        {
            name += Random.Range(0, 9);
        }
        return name;
    }
    public void OnChangeNameButtonClicked()
    {
        nameField.text = GenerateName(int.Parse(numberSymbolsField.text));
    }
}
