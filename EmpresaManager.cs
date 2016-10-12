using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Obligatorio_P2;

public class EmpresaManager
{
    private List<Mecanico> mecanicosList = new List<Mecanico>();
    private List<Embarcacion> embarcacionlist = new List<Embarcacion>();

    private static EmpresaManager _inst;

    private EmpresaManager() {
        //constructor de singleton
        
    }

    public static EmpresaManager Inst
    {
        get
        {
            //si la instancia del manager es null, creo una 
            if (_inst == null)
            {
                _inst = new EmpresaManager();
            }
            return _inst;
        }
    }

    public List<Mecanico> MecanicosList
    {
        get
        {
            return mecanicosList;
        }

        set
        {
            mecanicosList = value;
        }
    }

    public List<Embarcacion> Embarcacionlist
    {
        get
        {
            return embarcacionlist;
        }

        set
        {
            embarcacionlist = value;
        }
    }

    //to do: implementar listas y funciones de add para otros objetos
    public void AddMecanico(Mecanico mecanico)
    {
        MecanicosList.Add(mecanico);
    }
    public void AddEmbarcacion(Embarcacion emb)
    {
        Embarcacionlist.Add(emb);
    }





    public bool NumeroDeRegistroDuplicado(int num) // Pide un numero entero
    {
        foreach (Mecanico mec in MecanicosList)//recorro la lista de mecanicos
        {
            if (mec.NumeroRegistro == num)//Si el numero de registro de CADA instancia de MECANICOS en la LISTA aparece aunque sea 1 vez en el bucle, retornamos TRUE y SI existe un duplicado.
                return true;
           
        }

        return false;
    }


}

