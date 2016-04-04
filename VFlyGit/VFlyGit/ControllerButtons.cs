using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace VFlyGit
{
    class ControllerButtons : IFrame
    {
        public DO0 Button0 { get; set; }
        public DO1 Button1 { get; set; }
        public DO2 Button2 { get; set; }
        public DO3 Button3 { get; set; }
        public DO4 Button4 { get; set; }
        public DO6 Button6 { get; set; }
        public DO7 Button7 { get; set; }
    }


    [StructLayout(LayoutKind.Explicit)]
    public struct DO0
    {
        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(0)]
        public int AU_TEL;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(1)]
        public int AU_COM1_2;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(2)]
        public int AU_COM3;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(3)]
        public int AU_COM3_MIC;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(4)]
        public int AU_COM2;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(5)]
        public int AU_COM2_MIC;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(6)]
        public int AU_COM1;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(7)]
        public int AU_COM1_MIC;

    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DO1
    {

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(0)]
        public int AU_NAV2;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(1)]
        public int AU_ADF;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(2)]
        public int AU_NAV1;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(3)]
        public int AU_DME;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(4)]
        public int AU_HI_SENS;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(5)]
        public int AU_MKR_MUTE;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(6)]
        public int AU_SPKR;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(7)]
        public int AU_PA;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DO2
    {
        [Description("Połączony z PILOT_A - w prawo rośnie 00->11, w lewo maleje 11->00, wciśnięty daje 00, puszczony 11")]
        [FieldOffset(0)]
        public int PILOT_B;

        [Description("Połączony z PILOT_B - w prawo rośnie 00->11, w lewo maleje 11->00, wciśnięty daje 00, puszczony 11")]
        [FieldOffset(1)]
        public int PILOT_A;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(3)]
        public int AU_COPLT;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(4)]
        public int AU_PILOT;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(5)]
        public int AU_PLAY;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(6)]
        public int AU_MAN_SQ;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(7)]
        public int AU_AUX;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DO3
    {
        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(5)]
        public int DISPLAY_BACKUP;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(6)]
        public int PASS_B;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        [FieldOffset(7)]
        public int PASS_A;
    }

    //brak informacji
    [StructLayout(LayoutKind.Explicit)]
    public struct DO4
    {
        [Description("")]
        [FieldOffset(2)]
        public int FUEL_SELECTOR_RIGHT_3;

        [Description("")]
        [FieldOffset(3)]
        public int FUEL_SELECTOR_RIGHT_2;

        [Description("")]
        [FieldOffset(4)]
        public int FUEL_SELECTOR_RIGHT_1;

        [Description("")]
        [FieldOffset(5)]
        public int FUEL_SELECTOR_LEFT_3;

        [Description("")]
        [FieldOffset(6)]
        public int FUEL_SELECTOR_LEFT_2;

        [Description("")]
        [FieldOffset(7)]
        public int FUEL_SELECTOR_LEFT_1;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DO6
    {
        [Description("Brak informacji - prawdopodobnie wyświetlane podczas włączonego symulatora")]
        [FieldOffset(3)]
        public int FIRE_SYSTEM_CHECK;

        [Description("Brak informacji - prawdopodobnie wyświetlane podczas włączonego symulatora")]
        [FieldOffset(4)]
        public int STBY_BATT_TEST;

        [Description("Brak informacji - prawdopodobnie wyświetlane podczas włączonego symulatora")]
        [FieldOffset(5)]
        public int STBY_BATT_ARM;

        [Description("Połączone C172_PITCH_TRIM_A - 'koło w dolnej części kokpitu (NoseDown, NoseUp, TakeOff)', zmiana 00->11 w losowej kolejności")]
        [FieldOffset(6)]
        public int C172_PITCH_TRIM_B;

        [Description("Połączone C172_PITCH_TRIM_B - 'koło w dolnej części kokpitu (NoseDown, NoseUp, TakeOff)', zmiana 00->11 w losowej kolejności")]
        [FieldOffset(7)]
        public int C172_PITCH_TRIM_A;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DO7
    {
        [Description("Połączone C172_RUDDER_TRIM_A - 'koło w dolnej części kokpitu (NoseLeft, NoseRight)', zmiana 00->11 w losowej kolejności")]
        [FieldOffset(6)]
        public int C172_RUDDER_TRIM_B;

        [Description("Połączone C172_RUDDER_TRIM_B - 'koło w dolnej części kokpitu (NoseLeft, NoseRight)', zmiana 00->11 w losowej kolejności")]
        [FieldOffset(7)]
        public int C172_RUDDER_TRIM_A;
    }
}
