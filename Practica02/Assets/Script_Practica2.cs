using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Script_Practica2 : MonoBehaviour
{

    private string input;
    private int[] nums = new int [4];
    private int[] output = new int [2];
    private int target;

    public InputField EntradaTexto;
    private int actualizacion = 0;



    public int[] SumaDos(int[] nums, int target) {

        for(int i=0; i<4; i++){

            for(int j=0; j<4; j++){

                if(j != i){

                    if(nums[i]+nums[j] == target){
                    Debug.Log("Output = ["+i+","+j+"]");
                    output[0] = i;
                    output[1] = j;
                    actualizacion = 0;
                    return output;
                    }

                }

            }
        }

        output[0] = 0;
        output[1] = 0;
        return output;

    }

    public void ReadStringInput(string s){

        input = s;
        Debug.Log("Su entrada es: " + input);
        EntradaTexto.text = "";

        actualizacion++;
        
    }




    //-----------------------------------------------------------------------------------------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bienvenido a la Practica 2");
        Debug.Log("Introduce los valores de entrada: ");
    }

    // Update is called once per frame
    void Update()
    {

        if(actualizacion==10){
            target = Convert.ToInt32(input);
            SumaDos(nums, target);
            actualizacion = 0 ;
            Debug.Log("Introduce otros valores para volver a empezar: ");
        }

        else if(actualizacion==8){
            Debug.Log("Introduce el valor target: ");
            actualizacion++;
        }

        else if(actualizacion == 7){
            nums[3] = Convert.ToInt32(input);
            actualizacion++;
        }

        else if(actualizacion == 5){
            nums[2] = Convert.ToInt32(input);
            actualizacion++;
        }

        else if(actualizacion == 3){
            nums[1] = Convert.ToInt32(input);
            actualizacion++;
        }

        else if(actualizacion == 1){
            nums[0] = Convert.ToInt32(input);
            actualizacion++;
        }
    }
}
