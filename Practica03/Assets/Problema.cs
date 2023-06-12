using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema : MonoBehaviour
{

    int Problema(){

        private int [] Nums = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        private int numeroMayor = 0;
        private int numeroActual = 0;
        private int ind1, ind2, i, temp, resultado;


        for(i= 0; i<=Nums.Length-2; i++)
        {
            numeroActual = Nums[i]+Nums[i+1];

            if( numeroActual > numeroMayor)
            {
                numeroMayor = numeroActual;
                ind1 = i;
                ind2 = i+1;
            }
        }

        temp=numeroMayor;

        while(numeroMayor < (numeroMayor + Nums[ind2++]))
        {
            numeroMayor = numeroMayor + Nums[ind2];
        }

        while(temp < (temp + Nums[ind1--]))
        {
            temp = temp + Nums[ind1];
        }

        if(temp>numeroMayor) resultado = temp;
        else if (numeroMayor>temp) resultado = numeroMayor;
        Debug.Console("Su resultado es" + resultado);
        return resultado;
    }



    // Start is called before the first frame update
    void Start()
    {
        
        Problema();

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
