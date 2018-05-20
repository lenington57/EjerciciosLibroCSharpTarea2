using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EjerciciosLibroCSharpTarea2.Capítulo_7
{
    public class Ejercicios1_2_5
    {
        public void SieteUno()
        {
            int calif, cantidad = 0;
            int n = 0;
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 105.0f;
            float maxima = 0.0f; 
            Console.Write("Dame la cantidad de alumnos: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            ArrayList alCalif = new ArrayList(cantidad);
                
            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Dame la calificación: ");
                calif = Convert.ToInt32(Console.ReadLine());
                alCalif .Add(calif);
                suma += calif;
                if (calif < minima)
                    minima = calif;
                if (calif > maxima)
                    maxima = calif;
            }
            promedio = suma / cantidad;
            Console.WriteLine("\nEl promedio es {0}", promedio);
            Console.WriteLine("La calificación mínima es {0}", minima);
            Console.WriteLine("La calificación máxima es {0}", maxima);
        }

        public void SieteDos()
        {
            Hashtable miTabla = new Hashtable();
            miTabla.Add("Anjá", "Es una expresión que significa: 'Como!?', 'Wao!?', 'cáspita!'");
            miTabla.Add("Andá", "Es una expresión muy usada por los dominicanos, similar a 'que pena', 'es lamentable'.");
            miTabla.Add("Abombarse", "Proceso de putrefacción del agua, frutas o los alimentos.");
            miTabla.Add("Abombao", "Haber comido mucho, lleno de alimentos.");
            miTabla.Add("Abimbao", "Dícese de la persona que acaban de dar una paliza o muchos golpes, hinchada.");
            miTabla.Add("Abri' ga'", "Abrir gas, salir corriendo, escapar.");
            miTabla.Add("Abruzarse", "Pelearse, darse golpes. Ver ajebrarse, embojotarse.");
            miTabla.Add("Acotejar", "Acomodar, asentarse, establecerse, arreglar. Ejemplo:'ya te acotéjate después de la mudanza?'");
            miTabla.Add("Aficie", "(asfixie), estar aficiao, estar locamente enamorado, emperrao. Ejemplo: 'esa jeva ta' aficiá de ese tipo', 'tiene un aficie que se va volver loca'.");
            miTabla.Add("Aficéalo", "Asfíxialo! Ahógalo !. Acábalo !.");
            miTabla.Add("Afueriar", "Sacar, botar o dejar a una persona. Ejemplo: 'a Pedro lo afueriaron del grupo', 'la novia lo afuerió'.");
            miTabla.Add("Ajumao", "Borracho. Viene de juma que significa borrachera.");
            miTabla.Add("Apechurrao", "(Apeñucao), (Apiñao).apretado, o grupo de personas o cosas muy apretados que casi no caben en un lugar.");
            miTabla.Add("Aplatao", "Acción de defecar en posición de cuclillas.");
            miTabla.Add("Agentao", "Querer aparentar gente. Es muy parecido al Afrentoso.");
            miTabla.Add("Aguaita", "Usado en la región del Cibao, significa 'Mira!', 'fijate en eso!' Ejemplo: 'Aguaita, mira ese con su camisa nueva'.");
            miTabla.Add("Agallú", "Codicioso, egoísta. Persona que pretende abarcar muchas cosas.");
            miTabla.Add("Aguajero", "Persona altanera y que siempre está propagando cosas buenas de si misma sin ser ciertas. Ver Allantoso, boca-aguá, fantamoso, Baboso.");
            miTabla.Add("Aguanta-gorro", "Persona (generalmente sin pareja) que tiene que soportar los afectos y besos de una pareja que esta frente a el.");
            miTabla.Add("Añemiao", "Desganado, sin fuerzas, bobo, tonto, en el limbo. Ver Pariguayo, Bolsa.");

            Console.Write("Diccionario de Palabra Dominicanas...\n");
            foreach (DictionaryEntry datos in miTabla)
                Console.WriteLine("\n–{0}:   {1}", datos.Key, datos.Value);
        }

        public void SieteCinco()
        {
            Hashtable miTabla = new Hashtable();
            string nomb, num;
            int cant;
            Console.Write("Este programa guarda contactos de una Agenda...");
            Console.Write("\nDigite cantidad de personas que desea agregar a la agenda: ");
            cant = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Escriba el nombre de la persona: ");
                nomb = Console.ReadLine();
                Console.WriteLine("\nDigite el numero de telefono para {0}:", nomb);
                num = Console.ReadLine();
                miTabla.Add(nomb, num);
                Console.WriteLine("Contacto Agregado...\n");
            }

            Console.WriteLine("Usted agregó: \n");
            foreach (DictionaryEntry datos in miTabla)
                Console.WriteLine("–{0}:   {1}", datos.Key, datos.Value);
        }
    }
}

