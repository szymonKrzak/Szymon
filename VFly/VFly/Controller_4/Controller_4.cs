using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using VFlyGit.Controller_4.Interfaces;

namespace VFlyGit.Controller_4
{
    class Controller_4 : IFrame
    {
        public DO0 Button0 { get; set; } = new DO0();
        public DO1 Button1 { get; set; } = new DO1();
        public DO2 Button2 { get; set; } = new DO2();
        public DO3 Button3 { get; set; } = new DO3();
        public DO4 Button4 { get; set; } = new DO4();
        public DO5 Button5 { get; set; } = new DO5();
        public DO6 Button6 { get; set; } = new DO6();
        public DO7 Button7 { get; set; } = new DO7();

        public byte[] Frame
        {
            get
            {
                List<byte> list = new List<byte>();
                list.Add(Button0.Value);
                //dokonczyc
                //
                //
                //
                return list.ToArray();
            }

            set
            {
                value[0] = Button0.Value;
            }
        }
    }

    public class DO0:ByteBase, IByteValue
    {

        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];
                Bit[0] = AU_TEL;
                Bit[1] = AU_COM1_2;
                Bit[2] = AU_COM3;
                Bit[3] = AU_COM3_MIC;
                Bit[4] = AU_COM2;
                Bit[5] = AU_COM2_MIC;
                Bit[6] = AU_COM1;
                Bit[7] = AU_COM1_MIC;
                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);
                AU_TEL = Bit[0];
                AU_COM1_2 = Bit[1];
                AU_COM3 = Bit[2];
                AU_COM3_MIC = Bit[3];
                //dokonczyc
            }
            
        }

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_TEL;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM1_2;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM3;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM3_MIC;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM2;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM2_MIC;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM1;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM1_MIC;


    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DO1
    {

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(0)]
        public bool AU_NAV2;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(1)]
        public bool AU_ADF;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(2)]
        public bool AU_NAV1;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(3)]
        public bool AU_DME;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(4)]
        public bool AU_HI_SENS;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(5)]
        public bool AU_MKR_MUTE;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(6)]
        public bool AU_SPKR;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(7)]
        public bool AU_PA;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DO2
    {
        [Description("Połączony z PILOT_A - w prawo rośnie 00->11, w lewo maleje 11->00, wciśnięty daje 00, puszczony 11")]
        [FieldOffset(0)]
        public bool PILOT_B;

        [Description("Połączony z PILOT_B - w prawo rośnie 00->11, w lewo maleje 11->00, wciśnięty daje 00, puszczony 11")]
        [FieldOffset(1)]
        public bool PILOT_A;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(3)]
        public bool AU_COPLT;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(4)]
        public bool AU_PILOT;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(5)]
        public bool AU_PLAY;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(6)]
        public bool AU_MAN_SQ;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(7)]
        public bool AU_AUX;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DO3
    {
        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(5)]
        public bool DISPLAY_BACKUP;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(6)]
        public bool PASS_B;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(7)]
        public bool PASS_A;
    }

    //brak informacji
    [StructLayout(LayoutKind.Explicit)]
    public struct DO4
    {
        [Description("")]
        [FieldOffset(2)]
        public bool FUEL_SELECTOR_RIGHT_3;

        [Description("")]
        [FieldOffset(3)]
        public bool FUEL_SELECTOR_RIGHT_2;

        [Description("")]
        [FieldOffset(4)]
        public bool FUEL_SELECTOR_RIGHT_1;

        [Description("")]
        [FieldOffset(5)]
        public bool FUEL_SELECTOR_LEFT_3;

        [Description("")]
        [FieldOffset(6)]
        public bool FUEL_SELECTOR_LEFT_2;

        [Description("")]
        [FieldOffset(7)]
        public bool FUEL_SELECTOR_LEFT_1;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DO6
    {
        [Description("Brak informacji - prawdopodobnie wyświetlane podczas włączonego symulatora")]
        [FieldOffset(3)]
        public bool FIRE_SYSTEM_CHECK;

        [Description("Brak informacji - prawdopodobnie wyświetlane podczas włączonego symulatora")]
        [FieldOffset(4)]
        public bool STBY_BATT_TEST;

        [Description("Brak informacji - prawdopodobnie wyświetlane podczas włączonego symulatora")]
        [FieldOffset(5)]
        public bool STBY_BATT_ARM;

        [Description("Połączone C172_PITCH_TRIM_A - 'koło w dolnej części kokpitu (NoseDown, NoseUp, TakeOff)', zmiana 00->11 w losowej kolejności")]
        [FieldOffset(6)]
        public bool C172_PITCH_TRIM_B;

        [Description("Połączone C172_PITCH_TRIM_B - 'koło w dolnej części kokpitu (NoseDown, NoseUp, TakeOff)', zmiana 00->11 w losowej kolejności")]
        [FieldOffset(7)]
        public bool C172_PITCH_TRIM_A;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DO7
    {
        [Description("Połączone C172_RUDDER_TRIM_A - 'koło w dolnej części kokpitu (NoseLeft, NoseRight)', zmiana 00->11 w losowej kolejności")]
        [FieldOffset(6)]
        public bool C172_RUDDER_TRIM_B;

        [Description("Połączone C172_RUDDER_TRIM_B - 'koło w dolnej części kokpitu (NoseLeft, NoseRight)', zmiana 00->11 w losowej kolejności")]
        [FieldOffset(7)]
        public bool C172_RUDDER_TRIM_A;
    }
}
