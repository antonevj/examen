using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenParcial.Models
{
    public class Test
    {
        public string Sintomas1 { get; set; }
        public string Sintomas2{ get; set; }
        public string Sintomas3 { get; set; }
        public string Sintomas4 { get; set; }
        public string Sintomas5 { get; set; }
        public string Sintomas6 { get; set; }
        public string Sintomas7 { get; set; }
        public string Sintomas8 { get; set; }
        public string Sintomas9 { get; set; }
        public string Sintomas10 { get; set; }
        public string Sintomas11 { get; set; }
        public string Sintomas12 { get; set; }

        public float GradoEstres()
        {
            int rpta1 = 0;
          
            switch (Sintomas1)
            {
                case "1": rpta1 = 1; break;
                case "2": rpta1 = 2; break;
                case "3": rpta1 = 3; break;
                case "4": rpta1 = 4; break;
                case "5": rpta1 = 5; break;
                case "6": rpta1 = 6; break;
            }
            int rpta2 = 0;
            switch (Sintomas2)
            {
                case "1": rpta2 = 1; break;
                case "2": rpta2 = 2; break;
                case "3": rpta2 = 3; break;
                case "4": rpta2 = 4; break;
                case "5": rpta2 = 5; break;
                case "6": rpta2 = 6; break;
            }
            int rpta3 = 0;
            switch (Sintomas3)
            {
                case "1": rpta3 = 1; break;
                case "2": rpta3 = 2; break;
                case "3": rpta3 = 3; break;
                case "4": rpta3 = 4; break;
                case "5": rpta3 = 5; break;
                case "6": rpta3 = 6; break;
            }
            int rpta4 = 0;
            switch (Sintomas4)
            {
                case "1": rpta4 = 1; break;
                case "2": rpta4 = 2; break;
                case "3": rpta4 = 3; break;
                case "4": rpta4 = 4; break;
                case "5": rpta4 = 5; break;
                case "6": rpta4 = 6; break;
            }
            int rpta5 = 0;
            switch (Sintomas5)
            {
                case "1": rpta5 = 1; break;
                case "2": rpta5 = 2; break;
                case "3": rpta5 = 3; break;
                case "4": rpta5 = 4; break;
                case "5": rpta5 = 5; break;
                case "6": rpta5 = 6; break;
            }
            int rpta6 = 0;
            switch (Sintomas6)
            {
                case "1": rpta6 = 1; break;
                case "2": rpta6 = 2; break;
                case "3": rpta6 = 3; break;
                case "4": rpta6 = 4; break;
                case "5": rpta6 = 5; break;
                case "6": rpta6 = 6; break;
            }
            int rpta7 = 0;
            switch (Sintomas7)
            {
                case "1": rpta7 = 1; break;
                case "2": rpta7 = 2; break;
                case "3": rpta7 = 3; break;
                case "4": rpta7 = 4; break;
                case "5": rpta7 = 5; break;
                case "6": rpta7 = 6; break;
            }
            int rpta8 = 0;
            switch (Sintomas8)
            {
                case "1": rpta8 = 1; break;
                case "2": rpta8 = 2; break;
                case "3": rpta8 = 3; break;
                case "4": rpta8 = 4; break;
                case "5": rpta8 = 5; break;
                case "6": rpta8 = 6; break;
            }
            int rpta9 = 0;
            switch (Sintomas9)
            {
                case "1": rpta9 = 1; break;
                case "2": rpta9 = 2; break;
                case "3": rpta9 = 3; break;
                case "4": rpta9 = 4; break;
                case "5": rpta9 = 5; break;
                case "6": rpta9 = 6; break;
            }
            int rpta10 = 0;
            switch (Sintomas10)
            {
                case "1": rpta10 = 1; break;
                case "2": rpta10 = 2; break;
                case "3": rpta10 = 3; break;
                case "4": rpta10 = 4; break;
                case "5": rpta10 = 5; break;
                case "6": rpta10 = 6; break;
            }
            int rpta11 = 0;
            switch (Sintomas11)
            {
                case "1": rpta11 = 1; break;
                case "2": rpta11 = 2; break;
                case "3": rpta11 = 3; break;
                case "4": rpta11 = 4; break;
                case "5": rpta11 = 5; break;
                case "6": rpta11 = 6; break;
            }
            int rpta12 = 0;
            switch (Sintomas12)
            {
                case "1": rpta12 = 1; break;
                case "2": rpta12 = 2; break;
                case "3": rpta12 = 3; break;
                case "4": rpta12 = 4; break;
                case "5": rpta12 = 5; break;
                case "6": rpta12 = 6; break;
            }


            int total = rpta1 + rpta2+ rpta3 + rpta4 + rpta5 + rpta6 + rpta7 + rpta8 + rpta9 + rpta10 + rpta11 + rpta12;
         

            return total ;
        }


    }

    }