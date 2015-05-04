﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC_Simulator
{
    class Quarzfrequenz
    {
        public const int _50kHz = 0;
        public const int _100kHz = 1;
        public const int _250kHz=2;
        public const int _500kHz=3;
        public const int _1MHz = 4;
        public const int _1_5MHz=5;
        public const int _2MHz = 6;
        public const int _2_5MHz = 7;
        public const int _3MHz = 8;
        public const int _3_5MHz = 9;
        public const int _4MHZ = 10;
        public const int _4_5MHz = 11;
        public const int _5MHZ = 12;
        public const int _6MHZ = 13;
        public const int _7MHz = 14;
        public const int _8MHz = 15;
        public const int _9MHz = 16;
        public const int _10MHz = 17;
        private Frequenz[] Frequenzen = new Frequenz[]{
            new Frequenz("50 kHz",50000),
            new Frequenz("100 kHz",100000),
            new Frequenz("250 kHz",250000),
            //TODO weitere Werte ergänzen            
        };
        private int frequenz=0;


        public void set(int Auswahl)
        {
            frequenz = Auswahl;
        }

        public int get_frequenz()
        {
            return Frequenzen[frequenz].Wert;
        }

        public double get_time()
        {
            return 1000000.0 / get_frequenz();
        }
        public String get_String_frequenz()
        {
            return Frequenzen[frequenz].Name;
        }

        public String get_String_frequenz(int index)
        {
            return Frequenzen[index].Name;
        }

        public String ToString_time()
        {
            return get_time().ToString("F4") + " µs";
        }
    }
}
